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
    // nao esquecer: mudar o controlo de play/pause para usar o playstate (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
    public partial class FormAudioPlayer : Form
    {
        Thread videoPlayer;

        // declaração de variáveis
        int audioState = 1; //(a tocar: play=1 ; parado play=0)

        // iniciação de arrays
        string[] paths, files;

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
            this.Close();
            axWindowsMediaPlayer.Ctlcontrols.stop();
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
        /// Seleciona o ficheiro a ser tocado,
        /// Inicia o tocador e o timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemTocar_Click(object sender, EventArgs e)
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
                files = seletor.FileNames;
                paths = seletor.FileNames;

                // playlist recebe os ficheiros a tocar
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxPlaylist.Items.Add(files[i]);
                }

                // seleciona-se o primeiro index (0) da playlist
                listBoxPlaylist.SelectedIndex = 0;

                // inicia o timer para fazer o registo temporal
                timer.Enabled = true;
            }
        }

        /// <summary>
        /// mudança para o áudio selecionado na fila de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // inicia o timer para fazer o registo temporal
            timer.Enabled = true;

            // tempo atual passa a 0
            labelCurrentTime.Text = "00:00";
            progressBarTime.Value = 0;

            // o player recebe o ficheiro a reproduzir
            axWindowsMediaPlayer.URL = files[listBoxPlaylist.SelectedIndex];

            // estado do áudio em reprodução
            audioState = 1;
        }

        #region Botões funcionais

        /// <summary>
        /// Inicia e pausa a reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.URL != "")
            {
                // quando o audioState for 1 (ficheiro em reprodução) o botão irá pausar
                if (audioState == 1)
                {
                    // coloca em pausa, muda audioState para pausa e muda a imagem
                    axWindowsMediaPlayer.Ctlcontrols.pause();
                    audioState = 0;

                    // desativa o timer para poupar recursos
                    timer.Enabled = false;
                }
                else // quando o audioState for 0 (ficheiro em pausa) o botão irá iniciar
                {
                    // inicia a reprodução, muda audioState para reproduzir e muda a imagem
                    axWindowsMediaPlayer.Ctlcontrols.play();
                    audioState = 1;

                    //reativa o timer
                    timer.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Avança 10 segundos, no tempo reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkipTen_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.URL != "")
            {
                // são adicionados 10 segundos ao tempo de reprodução
                axWindowsMediaPlayer.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition + 10;
                progressBarTime.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;

                // o valor apresentado no tempo atual também muda
                labelCurrentTime.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
            }
        }

        /// <summary>
        /// Volta 10 segundos atrás, no tempo de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackTen_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.URL != "")
            {
                // são removidos 10 segundos ao tempo de reprodução
                axWindowsMediaPlayer.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition - 10;
                progressBarTime.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;

                // o valor apresentado no tempo atual também muda
                labelCurrentTime.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
            }
        }

        /// <summary>
        /// avança para o áudio seguinte da playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImgBtnNext_Click(object sender, EventArgs e)
        {
            // próximo item da playlist
            if (files.Length - (listBoxPlaylist.SelectedIndex + 1) > 0)
            {
                listBoxPlaylist.SelectedIndex++;
            }
        }

        /// <summary>
        /// recua para o áudio anterior na playlist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImgBtnPrevious_Click(object sender, EventArgs e)
        {
            // item anterior na listBox
            if (listBoxPlaylist.SelectedIndex > 0)
            {
                listBoxPlaylist.SelectedIndex--;
            }
        }

        /// <summary>
        /// Controlo do volume da aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.URL != "")
            {
                // define o volume do player como o valor escolhido na trackBar
                axWindowsMediaPlayer.settings.volume = trackBarVolume.Value;

                // representação escrita do valor do volume
                labelVolume.Text = Convert.ToString(trackBarVolume.Value) + "%";
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
            // definição do valor máximo da barra de progresso
            progressBarTime.Maximum = (int)axWindowsMediaPlayer.currentMedia.duration;

            // o valor da progressBarTime é igual ao valor da posição atual do player
            progressBarTime.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;

            // atribuição de valores às labels de tempo
            labelTotalTime.Text = axWindowsMediaPlayer.currentMedia.durationString;
            labelCurrentTime.Text = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;

            // deteta o momento final do áudio atual e executa um clique no botão que faz tocar o seguinte
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (progressBarTime.Value == progressBarTime.Maximum)
                {
                    bunifuImgBtnNext.PerformClick();
                }
            }
        }

        #endregion

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
}
