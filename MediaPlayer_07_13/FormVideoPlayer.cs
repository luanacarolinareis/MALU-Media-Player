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
            axWindowsMediaPlayer1.Ctlenabled = false;

            // Muda as configurações de cores do MenuStripOptions
            menuStripOptions.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());

            // Visibilidade inicial da label de volume
            labelVolume.Visible = false;
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
        /// "Maximiza" o formulário (sem ocultar a TaskBar do Windows)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            // Se está normal passa para "maximizada" (WindowState permanece Normal)
            if (maximizeClick == 0)
            {
                // Não oculta a TaskBar do Windows
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
            // Fecha o formulário atual
            this.Close();

            // Abre o formulário de áudio (configurações da Thread)
            audioPlayer = new Thread(abrirJanela);
            audioPlayer.SetApartmentState(ApartmentState.STA);
            audioPlayer.Start();
        }

        #endregion

        #region Escolha do ficheiro

        /// <summary>
        /// Escolha do ficheiro e filtro de extensões (.mp4 | .mov | .wmv | .avi | .mkv)
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

                // A bunifuProgressBar recebe o novo valor
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

                // A bunifuProgressBar recebe o novo valor
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

            // Se o volume for 0
            if (bunifuVolumeBar.Value == 0)
            {
                // Altera a imagem do botão para "mute"
                btnMute.Image = Properties.Resources.mute;

                // Alteração do valor do controlador para 1
                muteClick = 1;
            }

            // Senão, se o volume for diferente de 0
            else
            {
                // Altera a imagem do botão para "sound"
                btnMute.Image = Properties.Resources.sound;

                // Alteração do valor do controlador para 0
                muteClick = 0;
            }
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
            // Se o controlador "fullScreenClick" for 0, é porque o vídeo está normal e deve ser colocado em full screen
            if (fullScreenClick == 0)
            {
                this.WindowState = FormWindowState.Maximized;
                panel2.Visible = false;

                // O painel de controlos fica invisível
                panel3.Height = 0;

                // Alteração do valor do controlador para 1
                fullScreenClick = 1;
            }

            // Se o controlador "fullScreenClick" for 1, é porque o vídeo está em full screen e deve ser colocado em modo normal
            else if (fullScreenClick == 1)
            {
                this.WindowState = FormWindowState.Normal;
                panel2.Visible = true;

                // Alteração do valor do controlador para 0
                fullScreenClick = 0;
            }
        }

        /// <summary>
        /// Coloca o vídeo em modo "Picture-in-picture"
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
                    // Se o ecrã estiver em fullScreen
                    if (fullScreenClick == 1)
                    {
                        // Voltar a colocar o painel do topo visível
                        panel2.Visible = true;

                        // O estado do form passa para normal
                        this.WindowState = FormWindowState.Normal;
                    }

                    // Definição de sobreposição
                    this.TopMost = true;

                    // Definições de tamanho e de posição do form
                    this.Height = 196;
                    this.Width = 390;
                    this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10,
                                  Screen.PrimaryScreen.WorkingArea.Height - this.Height - 10);

                    // Coloca invisíveis os paineis que não são necessários neste modo
                    panel3.Visible = false;
                    menuStripOptions.Visible = false;
                    btnClose.Visible = false;
                    btnMaximize.Visible = false;
                    btnMinimize.Visible = false;

                    // Redefine o tamanho do painel do topo (diminui-lhe a altura)
                    panel2.Height = 25;

                    // O botão de saída do modo "Picture-in-picture" passa a estar visível
                    btnExitPIP.Visible = true;

                    // Alteração do valor do controlador para 1
                    pictureInPictureClick = 1;
                }
            }
        }

        /// <summary>
        /// Saída do modo "Picture-in-picture"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExitPIP_Click(object sender, EventArgs e)
        {
            // Se estiver "maximizado" mas não em fullScreen
            if (maximizeClick == 1 && fullScreenClick == 0)
            {
                // Quando se sai do modo "Picture-in-picture" volta ao estado inicial ("maximizado")
                this.Location = new Point(0, 0);
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            }

            // Se estiver "maximizado" e em fullScreen
            else if (maximizeClick == 1 && fullScreenClick == 1)
            {
                // Quando se sai do modo "Picture-in-picture" volta ao estado inicial (fullScreen)
                this.Location = new Point(0, 0);
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.WindowState = FormWindowState.Maximized;

                // O painel superior volta a ficar invisível
                panel2.Visible = false;
            }

            // Se não estiver "maximizado" mas estiver em fullScreen
            else if (maximizeClick == 0 && fullScreenClick == 1)
            {
                // Quando se sai do modo "Picture-in-picture" volta ao estado inicial (fullScreen)
                this.Height = 567;
                this.Width = 1042;
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                this.WindowState = FormWindowState.Maximized;
                panel2.Visible = false;
            }

            // Se não estiver maximizado nem em fullScreen
            else if (maximizeClick == 0 && fullScreenClick == 0)
            {
                // Quando se sai do modo "Picture-in-picture" volta ao estado inicial (normal)
                this.Height = 567;
                this.Width = 1042;
                this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            }

            // Alteração do valor do controlador para 0
            pictureInPictureClick = 0;

            // Definição de sobreposição
            this.TopMost = false;

            // Os painéis necessários voltam a ficar visíveis
            panel3.Visible = true;
            menuStripOptions.Visible = true;
            btnClose.Visible = true;
            btnMaximize.Visible = true;
            btnMinimize.Visible = true;

            // Alteração do tamanho do painel (regresso ao seu valor inicial)
            panel2.Height = 41;

            // O botão de saída do modo "Picture-in-Picture" deixa de estar visível
            btnExitPIP.Visible = false;
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

                // Se o vídeo está em reprodução
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

        /// <summary>
        /// Scroll da barra de progresso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuProgressBar_MouseUp(object sender, MouseEventArgs e)
        {
            // O vídeo vai para a posição definida na bunifuProgressBar pelo utilizador
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = bunifuProgressBar.Value;
        }

        /// <summary>
        /// Quando se clica por cima do player, os controlos aparecem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axWindowsMediaPlayer1_MouseUpEvent(object sender, AxWMPLib._WMPOCXEvents_MouseUpEvent e)
        {
            // Se estiver em full screen ou "maximizado"
            if (fullScreenClick == 1 || maximizeClick == 1)
            {
                // Se o painel de controlos estiver oculto
                if (panel3.Height == 0)
                {
                    // Os botões ficam visíveis
                    btnFullScreen.Height = 54;
                    btnPictureInPicture.Height = 54;
                    btnRestart.Height = 54;
                    btnReset.Height = 54;
                    btnPlay.Height = 54;
                    btnJumpBack.Height = 54;
                    btnJumpForward.Height = 54;
                    btnMute.Height = 49;
                    labelVolume.Height = 17;
                    bunifuVolumeBar.Height = 15;

                    // O painel fica gradualmente visível
                    for (int i = 1; i <= 9; i++)
                    {
                        panel3.Height += 9;
                    }
                }

                // Senão, se o painel de controlos estiver visível
                else
                {
                    // Os botões ficam invisíveis
                    btnFullScreen.Height = 0;
                    btnPictureInPicture.Height = 0;
                    btnRestart.Height = 0;
                    btnReset.Height = 0;
                    btnPlay.Height = 0;
                    btnJumpBack.Height = 0;
                    btnJumpForward.Height = 0;
                    btnMute.Height = 0;
                    labelVolume.Height = 0;
                    bunifuVolumeBar.Height = 0;

                    // O painel fica gradualmente invisível
                    for (int i = 9; i >= 1; i--)
                    {
                        panel3.Height -= 9;
                    }
                }

            }
            
            // Se não estiver em full screen nem "maximizado"
            else
            {
                panel3.Height = 81;
            }
        }

        #endregion

        #region Teclas de atalho

        /// <summary>
        /// Teclas para acessibilidade do utilizador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVideoPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            // Se pressionar "Esc"
            if (e.KeyCode == Keys.Escape)
            {
                // Se estiver em modo full screen
                if (fullScreenClick == 1)
                {
                    btnFullScreen.PerformClick();

                    // Se o painel de controlos estiver invisível
                    if (panel3.Height == 0)
                    {
                        // Os botões ficam visíveis
                        btnFullScreen.Height = 54;
                        btnPictureInPicture.Height = 54;
                        btnRestart.Height = 54;
                        btnReset.Height = 54;
                        btnPlay.Height = 54;
                        btnJumpBack.Height = 54;
                        btnJumpForward.Height = 54;
                        btnMute.Height = 49;
                        labelVolume.Height = 17;
                        bunifuVolumeBar.Height = 15;

                        // O painel fica gradualmente visível
                        for (int i = 1; i <= 9; i++)
                        {
                            panel3.Height += 9;
                        }
                    }
                }

                // Senão, se estiver em modo "Picture-in-Picture"
                else if (pictureInPictureClick == 1)
                {
                    btnExitPIP.PerformClick();
                }
            }

            // Senão, se pressionar "P" faz um clique no botão play / pause
            else if (e.KeyCode == Keys.P)
            {
                btnPlay.PerformClick();
            }

            // Senão, se pressionar "F" faz um clique no botão full screen
            else if (e.KeyCode == Keys.F)
            {
                btnFullScreen.PerformClick();

                // Os botões ficam visíveis
                btnFullScreen.Height = 54;
                btnPictureInPicture.Height = 54;
                btnRestart.Height = 54;
                btnReset.Height = 54;
                btnPlay.Height = 54;
                btnJumpBack.Height = 54;
                btnJumpForward.Height = 54;
                btnMute.Height = 49;
                labelVolume.Height = 17;
                bunifuVolumeBar.Height = 15;

                // Se o painel de controlos estiver invisível
                if (panel3.Height == 0)
                {
                    // O painel fica gradualmente visível
                    for (int i = 1; i <= 9; i++)
                    {
                        panel3.Height += 9;
                    }
                }
            }

            // Senão, se pressionar "M" faz um clique no botão de mute
            else if (e.KeyCode == Keys.M)
            {
                btnMute.PerformClick();
            }

            // Senão, se pressionar "seta esquerda" faz um clique no botão de jump back
            else if (e.KeyCode == Keys.Left)
            {
                btnJumpBack.PerformClick();
            }

            // Senão, se pressionar "seta direita" faz um clique no botão de jump forward
            else if (e.KeyCode == Keys.Right)
            {
                btnJumpForward.PerformClick();
            }

            // Senão, se pressionar "R" faz um clique no botão de reset
            else if (e.KeyCode == Keys.R)
            {
                btnReset.PerformClick();
            }

            // Senão, se pressionar "L" faz um clique no botão de restart
            else if (e.KeyCode == Keys.L)
            {
                btnRestart.PerformClick();
            }

            // Senão, se pressionar "I" faz um clique no botão de picture-in-picture
            else if (e.KeyCode == Keys.I)
            {
                // Vai para modo "Picture-in-Picture"
                if (pictureInPictureClick == 0)
                {
                    btnPictureInPicture.PerformClick();
                }

                // Sai do modo "Picture-in-picture"
                else
                {
                    btnExitPIP.PerformClick();
                }
            }
        }
        #endregion
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
