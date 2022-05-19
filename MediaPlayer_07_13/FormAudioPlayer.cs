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

        //declaração de variáveis
        int audioState = 1; //(a tocar: play=1 ; parado play=0)

        public FormAudioPlayer()
        {
            InitializeComponent();
            axWindowsMediaPlayer.uiMode = "none";
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
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "All Media Files|*.wav;*.avi;*.mp3;*.WAV;*.AVI;*.MP3"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // o player recebe o ficheiro a reproduzir
                axWindowsMediaPlayer.URL = openFileDialog.FileName;

                // inicia o timer para fazer o registo temporal
                timer.Enabled = true;
            }
        }

        #region Botões funcionais

        /// <summary>
        /// Inicia e pausa a reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayPause_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Avança 10 segundos, no tempo reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSkipTen_Click(object sender, EventArgs e)
        {
            // são adicionados 10 segundos ao tempo de reprodução
            axWindowsMediaPlayer.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition + 10;
            progressBarTime.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;

            // o valor apresentado no tempo atual também muda
            labelCurrentTime.Text = timeCount(Convert.ToInt32(axWindowsMediaPlayer.Ctlcontrols.currentPosition));
        }

        /// <summary>
        /// Volta 10 segundos atrás, no tempo de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackTen_Click(object sender, EventArgs e)
        {
            // são removidos 10 segundos ao tempo de reprodução
            axWindowsMediaPlayer.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition - 10;
            progressBarTime.Value = (int)axWindowsMediaPlayer.Ctlcontrols.currentPosition;

            // o valor apresentado no tempo atual também muda
            labelCurrentTime.Text = timeCount(Convert.ToInt32(axWindowsMediaPlayer.Ctlcontrols.currentPosition));
        }

        /// <summary>
        /// Controlo do volume da aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            // define o volume do player como o valor escolhido na trackBar
            axWindowsMediaPlayer.settings.volume = trackBarVolume.Value;

            // representação escrita do valor do volume
            labelVolume.Text = Convert.ToString(trackBarVolume.Value) + "%";
        }
        #endregion

        #region Controlo temporal

        /// <summary>
        /// Converte o tempo de segundos para o formato minutos : segundos
        /// </summary>
        /// <param name="secTotal"></param>
        /// <returns></returns>
        private string timeCount(int secTotal)
        {
            // variáveis
            int minutes, secEnd;

            minutes = secTotal / 60; // divisão inteira por 60 dá o valor em minutos
            secEnd = secTotal % 60; // o resto da divisão são quantos segundos a mais tem em relação ao último minuto

            // de maneira a que a disposição seja sempre a mesma é necessário adicionar o 0 das dezenas a valores somente nas unidade (<10)
            if (secEnd < 10)
            {
                return minutes + ":0" + secEnd;
            }
            else
            {
                return minutes + ":" + secEnd;
            }
        }

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
            labelTotalTime.Text = timeCount(Convert.ToInt32(axWindowsMediaPlayer.currentMedia.duration));
            labelCurrentTime.Text = timeCount(Convert.ToInt32(axWindowsMediaPlayer.Ctlcontrols.currentPosition));
        }

        #endregion
    }
}
