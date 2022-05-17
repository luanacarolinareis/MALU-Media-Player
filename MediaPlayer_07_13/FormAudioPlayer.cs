using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer_07_13
{
    public partial class FormAudioPlayer : Form
    {
        //declaração de variáveis
        int audioState = 1; //(a tocar: play=1 ; parado play=0)

        public FormAudioPlayer()
        {
            InitializeComponent();
            axWindowsMediaPlayer.uiMode = "none";
        }

        #region geral

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
            FormVideoPlayer formVideoPlayer = new FormVideoPlayer();
            formVideoPlayer.ShowDialog();
        }


        #endregion

        #endregion

        /// <summary>
        /// selects the file to be played and initiates it in the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemTocar_Click(object sender, EventArgs e)
        {
            // abre a janela de pesquisa de ficheiros
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            // o player recebe o ficheiro a reproduzir
            axWindowsMediaPlayer.URL = openFileDialog.FileName;
            //labelTotalTime.Text = axWindowsMediaPlayer.Time
        }

        /// <summary>
        /// inicia e pausa a reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            // quando o audioState for 1 (ficheiro em reprodução) o botão irá pausar
            if (audioState == 1)
            {
                axWindowsMediaPlayer.Ctlcontrols.pause();
                audioState = 0;
            }
            else // quando o audioState for 0 (ficheiro em pausa) o botão irá iniciar
            {
                axWindowsMediaPlayer.Ctlcontrols.play();
                audioState = 1;
            }
        }

        /// <summary>
        /// salta 10 segundos de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkipTen_Click(object sender, EventArgs e)
        {
            // são adicionados 10 segundos ao tempo de reprodução
            axWindowsMediaPlayer.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition + 10;
            progressBarTime.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;
        }

        /// <summary>
        /// volta 10 segundos atrás ao tempo de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackTen_Click(object sender, EventArgs e)
        {
            // são removidos 10 segundos ao tempo de reprodução
            axWindowsMediaPlayer.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition - 10;
            progressBarTime.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;
        }

        /// <summary>
        /// controlo do volume da aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            // define o volume do player como o valor escolhido na trackBar
            axWindowsMediaPlayer.settings.volume = trackBarVolume.Value;

            // representação escrita do valor do volume
            labelVolume.Text = Convert.ToString(trackBarVolume.Value);
        }

        /// <summary>
        /// analisa e representa o tempo do áudio e a posição natural em que ele está
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axWindowsMediaPlayer_StatusChange(object sender, EventArgs e)
        {
            // o valor da progressBarTime é igual ao valor da posição atual do player
            // só há a necessidade de mudar enquanto o vídeo está a tocar ou quando o tempo do vídeo é alterado
            progressBarTime.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;
        }
    }
}
