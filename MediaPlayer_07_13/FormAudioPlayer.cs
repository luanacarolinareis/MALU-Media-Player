using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MediaPlayer_07_13
{
    public partial class FormAudioPlayer : Form
    {
        Thread videoPlayer;

        // declaração de variáveis
        int audioState = 0; // a tocar: 0 , parado: 1
        int loopState = 0; // sem loop: 0 , loop da playlist: 1
        int muteState = 0; // não mutado: 0 , mutado: 1

        // iniciação de listas
        List<string> filePaths = new List<string>();

        // iniciação de arrays
        string[] filePathsArray, fileNamesArray;

        public FormAudioPlayer()
        {
            InitializeComponent();
            axWindowsMediaPlayer.uiMode = "none";

            // muda as configurações de cores do MenuStripOptions
            menuStripOptions.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());
        }

        #region Geral

        #region Botões de close, maximize and minimize

        /// <summary>
        /// Fecha o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            timer.Stop();
            axWindowsMediaPlayer.Ctlcontrols.stop();
            this.Close();
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
        /// Abre o formulário específico para reprodução de vídeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemVideoPlayer_Click(object sender, EventArgs e)
        {
            this.Close();
            videoPlayer = new Thread(abrirJanela);
            videoPlayer.SetApartmentState(ApartmentState.STA);
            videoPlayer.Start();
        }

        #endregion

        /// <summary>
        /// Abre a janela do FormVideoPlayer
        /// </summary>
        /// <param name="obj"></param>
        private void abrirJanela(object obj)
        {
            Application.Run(new FormVideoPlayer());
        }

        #endregion

        /// <summary>
        /// Detetor da mudança de estado da mídia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axWindowsMediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // condição responsável pela reprodução do Gif visualizador de áudio
            if (e.newState == 3) // áudio a tocar; o gif movimenta
            {
                pictureBoxAudioGif.Enabled = true;
            }
            else // áudio não a tocar, não movimenta
            {
                pictureBoxAudioGif.Enabled = false;
            }
        }

        /// <summary>
        /// Adiciona um ficheiro à playlist,
        /// Inicia o tocador no último ficheiro adicionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemTocar_Click(object sender, EventArgs e)
        {
            // abre a janela de pesquisa de ficheiros
            OpenFileDialog seletor = new OpenFileDialog
            {
                Filter = "All Media Files|*.wav;*.avi;*.mp3;*.WAV;*.AVI;*.MP3",
            };

            // a iniciação dos vários componentes só é feita se for selecionado um ficheiro
            if (seletor.ShowDialog() == DialogResult.OK)
            {
                // arrays recebem os nomes e caminhos dos ficheiros
                filePathsArray = seletor.FileNames;
                fileNamesArray = seletor.SafeFileNames;

                // a lista dos caminhos recebe os caminhos do array de caminhos
                for (int i = 0; i < filePathsArray.Length; i++)
                {
                    filePaths.Add(filePathsArray[i]);
                }

                // playlist recebe o nome dos ficheiros a tocar
                for (int i = 0; i < fileNamesArray.Length; i++)
                {
                    listBoxPlaylist.Items.Add(fileNamesArray[i]);
                }

                // tamanho da caixa da playlist
                listBoxPlaylist.Height = 16 * listBoxPlaylist.Items.Count;

                // selecionado o index do último ficheiro adicionado
                listBoxPlaylist.SelectedIndex = listBoxPlaylist.Items.Count - 1;
            }
        }

        /// <summary>
        /// Adiciona múltiplos ficheiros à playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemAdicionar_Click(object sender, EventArgs e)
        {
            // abre a janela de pesquisa de ficheiros
            OpenFileDialog seletor = new OpenFileDialog
            {
                Filter = "All Media Files|*.wav;*.avi;*.mp3;*.WAV;*.AVI;*.MP3",
                Multiselect = true
            };

            // a iniciação dos vários componentes só é feita se for selecionado um ficheiro
            if (seletor.ShowDialog() == DialogResult.OK)
            {
                // arrays recebem os nomes e caminhos dos ficheiros
                filePathsArray = seletor.FileNames;
                fileNamesArray = seletor.SafeFileNames;

                // a lista dos caminhos recebe os caminhos do array de caminhos
                for (int i = 0; i < filePathsArray.Length; i++)
                {
                    filePaths.Add(filePathsArray[i]);
                }

                // playlist recebe o nome dos ficheiros a tocar
                for (int i = 0; i < fileNamesArray.Length; i++)
                {
                    listBoxPlaylist.Items.Add(fileNamesArray[i]);
                }

                // tamanho da caixa da playlist
                listBoxPlaylist.Height = 16 * listBoxPlaylist.Items.Count;
            }
        }

        /// <summary>
        /// Mudança para o áudio selecionado na fila de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // faz aparecer o Gif visualizador de áudio
            pictureBoxAudioGif.Visible = true;

            // para o timer para não serem requisitadas coisas do áudio atual enquanto ele não está iniciado
            timer.Enabled = false;

            // tempo atual passa a 0
            labelCurrentTime.Text = "00:00";
            bunifuProgressBar.Value = 0;

            // o player recebe o ficheiro a reproduzir
            axWindowsMediaPlayer.URL = filePaths[listBoxPlaylist.SelectedIndex];

            // estado do áudio em reprodução
            audioState = 0;

            // inicia o timer para fazer o registo temporal
            timer.Enabled = true;
        }
        
        #region Botões funcionais

        /// <summary>
        /// Inicia e pausa a reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImgBtnPP_Click(object sender, EventArgs e)
        {
            // só executa a ação se já houver áudio a ser tocado
            if (axWindowsMediaPlayer.URL != "")
            {
                // quando o audioState for 0 (ficheiro em reprodução) o botão irá pausar
                if (audioState == 0)
                {
                    // desativa o timer para poupar recursos
                    timer.Enabled = false;

                    // coloca em pausa, muda audioState para pausa e muda a imagem
                    bunifuImgBtnPP.Image = Properties.Resources.play_audio;
                    axWindowsMediaPlayer.Ctlcontrols.pause();
                    audioState = 1;
                }
                else // quando o audioState for 1 (ficheiro em pausa) o botão irá iniciar
                {
                    // reativa o timer
                    timer.Enabled = true;

                    // inicia a reprodução, muda audioState para reproduzir e muda a imagem
                    bunifuImgBtnPP.Image = Properties.Resources.pause_audio;
                    axWindowsMediaPlayer.Ctlcontrols.play();
                    audioState = 0;
                }
            }
        }

        /// <summary>
        /// Avança 10 segundos, no tempo reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImgBtnSkipTen_Click(object sender, EventArgs e)
        {
            // só executa a ação se já houver áudio a ser tocado
            if (axWindowsMediaPlayer.URL != "")
            {
                // se ainda houver tempo de vídeo para avançar 10 segundos
                if ((int)axWindowsMediaPlayer.currentMedia.duration - (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition > 10)
                {
                    // são adicionados 10 segundos ao tempo de reprodução
                    axWindowsMediaPlayer.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition + 10;

                    // o valor apresentado no tempo atual também muda
                    bunifuProgressBar.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;
                    labelCurrentTime.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
                }
                else // senão passa para o próximo na playlist
                {
                    bunifuImgBtnNext.PerformClick();
                }
            }
        }

        /// <summary>
        /// Volta 10 segundos atrás, no tempo de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImgBtnBackTen_Click(object sender, EventArgs e)
        {
            // só executa a ação se já houver áudio a ser tocado
            if (axWindowsMediaPlayer.URL != "")
            {
                // são removidos 10 segundos ao tempo de reprodução
                axWindowsMediaPlayer.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition - 10;

                // o valor apresentado no tempo atual também muda
                bunifuProgressBar.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;
                labelCurrentTime.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
            }

        }

        /// <summary>
        /// Avança para o áudio seguinte da playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImgBtnNext_Click(object sender, EventArgs e)
        {
            // só realiza se a playlist já tiver algo
            if (listBoxPlaylist.Items.Count != 0)
            {
                timer.Enabled = false; // evita erros vindos de o timer iniciar sem o vídeo carregar
                // próximo item da playlist
                if (filePaths.Count() - (listBoxPlaylist.SelectedIndex + 1) > 0) // ainda há items na lista
                {
                    listBoxPlaylist.SelectedIndex++; // o index do item avança 1
                }
                else // último item da lista
                {
                    if (loopState == 1) // se estiver selecionado o loop de playlist
                    {
                        listBoxPlaylist.SelectedIndex = 0; // volta ao item index 0
                    }
                }
            }
        }

        /// <summary>
        /// Recua para o áudio anterior na playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImgBtnPrevious_Click(object sender, EventArgs e)
        {
            // só realiza se a playlist já tiver algo
            if (listBoxPlaylist.Items.Count != 0)
            {
                // item anterior na listBox
                if (listBoxPlaylist.SelectedIndex > 0)
                {
                    timer.Enabled = false; // evita erros vindos de o timer iniciar sem o vídeo carregar
                    listBoxPlaylist.SelectedIndex--; // o index do item retrocede 1
                }
            }
        }

        /// <summary>
        /// Esconde e mostra a playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImgBtnPlaylist_Click(object sender, EventArgs e)
        {
            // se a playlist estiver a aparecer, o botão faz desaparecer
            if (listBoxPlaylist.Visible == true)
            {
                // listbox deixa de ser vísivel
                listBoxPlaylist.Visible = false;

                // diminui o tamanho do panel que a contém
                panelLateral.Width = 41;

                // diminui o tamanho do formulário
                this.Width = 477;

                // deslocação do Gif visualizador de áudio
                pictureBoxAudioGif.Location = new Point(41, 45);
            }
            else // senão,a playlist está escondida, e o botão fá-la aparecer
            {
                // listbox passa a vísivel
                listBoxPlaylist.Visible = true;

                // aumenta o tamanho do panel que a contém
                panelLateral.Width = 180;

                // aumenta o tamanho do formulário
                this.Width = 616;

                // deslocação do Gif visualizador de áudio
                pictureBoxAudioGif.Location = new Point(180, 45);
            }
        }

        /// <summary>
        /// Controla se e o que vai repetir ao tocar o áudio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImgBtnLoop_Click(object sender, EventArgs e)
        {
            if (loopState == 0) // passa de não haver loop para fazer loop da música
            {
                loopState = 1; // em loop

                // imagem de loop ativado
                bunifuImgBtnLoop.Image = Properties.Resources.repeat_white_audio;
            }
            else if (loopState == 1) // passa de fazer loop da playlist para não haver loop
            {
                loopState = 0; // sem loop

                // imagem de loop desativado
                bunifuImgBtnLoop.Image = Properties.Resources.repeat_32px_audio;
            }
        }

        #endregion

        #region Controlo de volume

        /// <summary>
        /// Controla o volume da aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuVolumeBar_Scroll(object sender, Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs e)
        {
            // define o volume do player como o valor escolhido na trackBar
            axWindowsMediaPlayer.settings.volume = bunifuVolumeBar.Value;

            // representação escrita do valor do volume
            labelVolume.Text = bunifuVolumeBar.Value + "%";

            // se o valor passar a 0, faz o mesmo que mutar
            if (bunifuVolumeBar.Value == 0)
            {
                // imagem de mute
                bunifuImgBtnVolume.Image = Properties.Resources.mute_audio;

                // estado de mute 1 (está mutado)
                muteState = 1;
            }
            else // senão, retira o que o mute faz
            {
                // imagem de som
                bunifuImgBtnVolume.Image = Properties.Resources.sound_audio;

                // estado de mute 0 (não está mutado)
                muteState = 0;
            }
        }

        /// <summary>
        /// Label de volume aparece enquanto está a ser usada a barra 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuVolumeBar_MouseDown(object sender, MouseEventArgs e)
        {
            // visibilidade da label de volume
            labelVolume.Visible = true;
        }

        /// <summary>
        /// Label de volume desaparece quando a barra deixa de ser usada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuVolumeBar_MouseUp(object sender, MouseEventArgs e)
        {
            // visibilidade da label de volume
            labelVolume.Visible = false;
        }

        /// <summary>
        /// Muta/desmuta o áudio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImgBtnVolume_Click(object sender, EventArgs e)
        {
            // não está mutado, será mutado
            if (muteState == 0)
            {
                // volume passa a 0
                axWindowsMediaPlayer.settings.volume = 0;
                labelVolume.Text ="0%";

                // imagem de mute
                bunifuImgBtnVolume.Image = Properties.Resources.mute_audio;

                // estado de mute 1 (está mutado)
                muteState = 1;
            }
            else // mutado, será desmutado
            {
                // define o volume do player como o valor escolhido na trackBar
                axWindowsMediaPlayer.settings.volume = 50;

                // representação escrita do valor do volume
                labelVolume.Text = "50%";

                // imagem de som
                bunifuImgBtnVolume.Image = Properties.Resources.sound_audio;

                // estado de mute 0 (não está mutado)
                muteState = 0;
            }
        }

        #endregion

        #region Controlo temporal

        /// <summary>
        /// Tamanho da barra de progresso,
        /// Inicia o progresso da barra de tempo,
        /// Valores às labels que transmitem o tempo,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            // atribuição de valores às labels de tempo
            labelCurrentTime.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
            labelTotalTime.Text = axWindowsMediaPlayer.currentMedia.durationString;

            // o valor da progressBarTime é igual ao valor da posição atual do player
            bunifuProgressBar.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;

            // definição do valor máximo da barra de progresso
            bunifuProgressBar.Maximum = (int)axWindowsMediaPlayer.currentMedia.duration;

            // deteta o momento final do áudio atual e executa um clique no botão que faz tocar o seguinte
            if (labelCurrentTime.Text == "")
            {
                bunifuImgBtnNext.PerformClick();
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
