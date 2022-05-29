using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace MediaPlayer_07_13
{
    public partial class FormVideoPlayer : Form
    {
        // Thread usada para abrir o formulário de áudio
        Thread audioPlayer;

        // Variáveis que controlam cliques em botões
        int muteClick = 0;
        int restartClick = 0;
        int fullScreenClick = 0;
        int maximizeClick = 0;
        int pictureInPictureClick = 0;

        public FormVideoPlayer()
        {
            InitializeComponent();

            // Localização inicial do formulário
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            // Remoção dos controlos do "Windows Media Player"
            axWindowsMediaPlayer1.uiMode = "none";

            // Muda as configurações de cores do MenuStripOptions
            menuStripOptions.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());

            // Visibilidade inicial da label de volume
            labelVolume.Visible = false;

            // Localização dos botões
            btnPlay.Left = (this.Width - btnPlay.Width) / 2;
            btnJumpBack.Left = (this.Width - btnJumpBack.Width) / 2 - 70;
            btnJumpForward.Left = (this.Width - btnJumpForward.Width) / 2 + 70;

        }

        #region Botões de close, maximize and minimize

        /// <summary>
        /// Fecha o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Maximiza o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            // Se está normal passa para "maximizada" (WindowState permanece Normal)
            if (maximizeClick == 0)
            {
                // Não oculta a task bar do Windows
                this.Location = new Point(0, 0);
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;

                // Alteração do valor do controlador para 1
                maximizeClick = 1;
            }

            // Senão, se está "maximizada", passa para normal (WindowState permanece Normal)
            else
            {               
                this.Height = 567;
                this.Width = 1042;
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

                // Alteração do valor do controlador para 0
                maximizeClick = 0;
            }
        }

        /// <summary>
        /// Minimiza o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Opções do MenuStripOptions

        /// <summary>
        /// Saída protegida do formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemSair_Click(object sender, EventArgs e)
        {
            // Apenas sai se a resposta à MessageBox for positiva
            if (MessageBox.Show("Quer mesmo sair do programa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Abre o formulário de informações, em modo Modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemAcercaDe_Click(object sender, EventArgs e)
        {
            FormAcercaDe formAcercaDe = new FormAcercaDe();
            formAcercaDe.ShowDialog();
        }

        /// <summary>
        /// Abre o formulário específico para reprodução de áudio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemAudioPlayer_Click(object sender, EventArgs e)
        {
            this.Close();
            audioPlayer = new Thread(abrirJanela);
            audioPlayer.SetApartmentState(ApartmentState.STA);
            audioPlayer.Start();
        }

        #endregion

        #region Escolha do ficheiro

        /// <summary>
        /// Escolha do ficheiro e filtro de extensões (.mp4 | .mov | .wmv | .avi)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abrirFicheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Diálogo para selecionar o ficheiro
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtro de ficheiros (.mp4, .mov, .wmv, .avi, .webm, .mkv)
            openFileDialog.Filter = "Video Files(*.MP4; *.MOV; *.WMV; *.AVI; *.MKV) | *.MP4; *.MOV; *.WMV; *.AVI; *.MKV; | All Files(*.*) | *.*";

            // Propriedades
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Selecione um ficheiro de vídeo...";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            }
        }

        #endregion

        #region Botões funcionais

        /// <summary>
        /// Alterna entre "Play" e "Pause"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != "")
            {
                // Se o vídeo está em reprodução, deve ser pausado
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    // Coloca em pausa
                    axWindowsMediaPlayer1.Ctlcontrols.pause();

                    // Altera a imagem do botão para "play"
                    btnPlay.Image = Properties.Resources.play;
                }

                // Senão, se o vídeo está pausado, deve ser reproduzido
                else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    // Retoma a reprodução
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    // Altera a imagem do botão para "pause"
                    btnPlay.Image = Properties.Resources.pause;
                }
            }
        }

        /// <summary>
        /// Avança 10 segundos no tempo de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJumpForward_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != "")
            {
                // São adicionados 10 segundos ao tempo de reprodução
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition + 10;
                bunifuProgressBar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                // O valor apresentado no tempo atual também muda
                labelCurrentTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            }
        }

        /// <summary>
        /// Recua 10 segundos no tempo de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJumpBack_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != "")
            {
                // São removidos 10 segundos ao tempo de reprodução
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition - 10;
                bunifuProgressBar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                // O valor apresentado no tempo atual também muda
                labelCurrentTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            }
        }

        /// <summary>
        /// Controlo do volume de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuVolumeBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs e)
        {
            // Define o volume do player como o valor escolhido na trackBar
            axWindowsMediaPlayer1.settings.volume = bunifuVolumeBar.Value;

            // Apresentação do valor do volume ao utilizador
            labelVolume.Text = Convert.ToString(bunifuVolumeBar.Value) + "%";
        }

        /// <summary>
        /// Muta o som do vídeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMute_Click(object sender, EventArgs e)
        {
            // Se o controlador "muteClick" for 0, é porque o vídeo está com som e deve ser mutado
            if (muteClick == 0)
            {
                // Altera a imagem do botão para "mute"
                btnMute.Image = Properties.Resources.mute;

                // Define o volume do player para 0
                bunifuVolumeBar.Value = 0;
                axWindowsMediaPlayer1.settings.volume = 0;

                // Apresentação do valor do volume ao utilizador
                labelVolume.Text = Convert.ToString(bunifuVolumeBar.Value) + "%";

                // Alteração do valor do controlador para 1
                muteClick = 1;
            }

            // Senão, se o controlador "muteClick" for 1, é porque o vídeo está mutado e deve ficar com som
            else if (muteClick == 1)
            {
                // Altera a imagem do botão para "sound"
                btnMute.Image = Properties.Resources.sound;

                // Define o volume do player para 50
                bunifuVolumeBar.Value = 50;
                axWindowsMediaPlayer1.settings.volume = 50;

                // Apresentação do valor do volume ao utilizador
                labelVolume.Text = Convert.ToString(bunifuVolumeBar.Value) + "%";

                // Alteração do valor do controlador para 0
                muteClick = 0;
            }
        }

        /// <summary>
        /// Reprodução automática do vídeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Se o controlador "restartClick" for 0, é porque a função restart deve ser ativada
            if (restartClick == 0)
            {
                // Altera a imagem do botão para "repeat_white"
                btnRestart.Image = Properties.Resources.repeat_white;

                // Alteração do valor do controlador para 1
                restartClick = 1;
            }

            // Se o controlador "restartClick" for 1, é porque a função restart deve ser desativada
            else if (restartClick == 1)
            {
                // Altera a imagem do botão para "repeat_32px"
                btnRestart.Image = Properties.Resources.repeat_32px;

                // Alteração do valor do controlador para 0
                restartClick = 0;
            }
        }

        /// <summary>
        /// Reinicia a reprodução do vídeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != "")
            {
                // O tempo de reprodução volta a 0
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
                bunifuProgressBar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                // O valor apresentado no tempo atual também muda
                labelCurrentTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            }
        }

        /// <summary>
        /// Coloca o vídeo em full screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != "")
            {
                // Se o controlador "fullScreenClick" for 0, é porque o vídeo está normal e deve ser colocado em full screen
                if (fullScreenClick == 0)
                {
                    this.WindowState = FormWindowState.Maximized;
                    fullScreenClick = 1;
                }

                // Se o controlador "fullScreenClick" for 1, é porque o vídeo está em full screen e deve ser colocado em modo normal
                else if (fullScreenClick == 1)
                {
                    this.WindowState = FormWindowState.Normal;
                    fullScreenClick = 0;
                }
            }
        }

        #endregion

        #region Timer

        /// <summary>
        /// Timer para controlo de tempos de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Atribuição de valor à label de tempo atual
                labelCurrentTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;

                // Atribuição de valor à label de tempo total
                labelTotalTime.Text = axWindowsMediaPlayer1.currentMedia.durationString.ToString();

                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    // O valor da progressBar é igual ao valor da posição atual do player
                    bunifuProgressBar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                }
            }
            catch (Exception)
            {
                labelCurrentTime.Text = axWindowsMediaPlayer1.currentMedia.duration.ToString();
            }
        }

        #endregion

        #region Métodos adicionais

        /// <summary>
        /// Abre a janela FormAudioPlayer
        /// </summary>
        /// <param name="obj"></param>
        private void abrirJanela(object obj)
        {
            Application.Run(new FormAudioPlayer());
        }

        /// <summary>
        /// Quando o mouse clica na bunifuVolumeBar, a label de volume fica visível
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuVolumeBar_MouseDown(object sender, MouseEventArgs e)
        {
            // Visibilidade da label de volume
            labelVolume.Visible = true;
        }

        /// <summary>
        /// Quando o mouse solta a bunifuVolumeBar, a label de volume fica invisível
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuVolumeBar_MouseUp(object sender, MouseEventArgs e)
        {
            // Visibilidade da label de volume
            labelVolume.Visible = false;
        }

        /// <summary>
        /// Alteração no valor de playState do Windows Media Player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Se o vídeo está em reprodução
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Definição do valor máximo da barra de progresso
                bunifuProgressBar.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;

                // Início do timer
                timer.Start();
            }

            // Senão, se o vídeo está pausado
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                // Pausa do timer
                timer.Stop();
            }

            // Senão, se o vídeo está parado
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                // Pausa do timer
                timer.Stop();

                // bunifuProgressBar recebe o valor de 0
                bunifuProgressBar.Value = 0;

                // Se a opção de reprodução automática estiver ativa, reinicia o vídeo
                if (restartClick == 1)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }

                // As labels de tempo atual e total são resetadas
                labelCurrentTime.Text = "00:00:00";
                labelTotalTime.Text = "00:00:00";

                // Se a opção de reprodução automática estiver inativa, a URL do Windows Media Player é resetada
                if (restartClick == 0)
                {
                    axWindowsMediaPlayer1.URL = "";
                }
            }
        }

        #endregion


        /// <summary>
        /// Scrool da barra de progresso (!!!)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuProgressBar_MouseUp(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = bunifuProgressBar.Value;
        }

        /// <summary>
        /// Coloca o vídeo em modo picture in picture (!!!)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPictureInPicture_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.URL != "")
            {
                // Se o controlador "pictureInPictureClick" for 0, é porque o vídeo deve ser aberto em modo "Picture-in-picture"
                if (pictureInPictureClick == 0)
                {
                    // Definições de tamanho e de posição do form
                    this.TopMost = true;
                    this.Height = 196;
                    this.Width = 390;
                    this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10,
                                  Screen.PrimaryScreen.WorkingArea.Height - this.Height - 10);

                    // Remove os paineis que não são necessários neste modo
                    panel3.Dispose();
                    panel2.Dispose();

                    // Alteração do valor do controlador para 1
                    pictureInPictureClick = 1;
                }
            }
        }
    }

    #region ProfessionalColorTable para o "MenuStripOptions"

    public class MyColorTable : ProfessionalColorTable
    {

        // Borda dos submenus (topo, base, direita)
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.Black;
            }
        }

        // Borda lateral do submenus (esquerda)
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.MediumOrchid;
            }
        }

        // Borda exterior dos menus
        public override Color MenuBorder
        {
            get
            {
                return Color.Black;
            }
        }

        // Borda das opções selecionadas (mouse por cima)
        public override Color MenuItemBorder
        {
            get
            {
                return Color.Black;
            }
        }

        // Fundo das opções selecionadas (mouse por cima)
        public override Color MenuItemSelected
        {
            get
            {
                return Color.MediumOrchid;
            }
        }

        // Fundo dos menus principais (mouse por cima)
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.MediumOrchid;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.MediumOrchid;
            }
        }

        // Fundo dos menus principais (menu selecionado)
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.MediumOrchid;
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.MediumOrchid;
            }
        }
    } 

    #endregion

}
