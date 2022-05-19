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
    public partial class FormVideoPlayer : Form
    {
        Thread audioPlayer;

        public FormVideoPlayer()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.uiMode = "none";
        }

        #region Botões de close, maximize and minimize

        private void btnClose_Click(object sender, EventArgs e)
        {
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

        private void abrirFicheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Diálogo para selecionar o ficheiro
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtro de ficheiros (.mp4, .mov, .wmv, .avi, .webm)
            openFileDialog.Filter = "Video Files(*.MP4; *.MOV; *.WMV; *.AVI) | *.MP4; *.MOV; *.WMV; *.AVI; | All Files(*.*) | *.*";

            // Propriedades
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select a video file...";
            //openFileDialog.InitialDirectory = "C:\\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                timer.Enabled = true;
            }
        }

        #endregion

        #region Botões funcionais

        /// <summary>
        /// Alterna entre play / pause
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            // Play / pause

            if (btnPlayPause.Text == "Pause")
            {
                // Coloca em pausa e o texto do botão passa para "Play"
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                btnPlayPause.Text = "Play";

                // desativa o timer para poupar recursos
                timer.Enabled = false;
            }
            else if (btnPlayPause.Text == "Play")
            {
                // Retoma a reprodução e o texto do botão passa para "Pause"
                axWindowsMediaPlayer1.Ctlcontrols.play();
                btnPlayPause.Text = "Pause";

                // ativa o timer
                timer.Enabled = true;
            }
        }

        /// <summary>
        /// Volta 10 segundos atrás, no tempo de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJumpBack_Click(object sender, EventArgs e)
        {
            // São removidos 10 segundos ao tempo de reprodução
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition - 10;
            progressBarTime.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            // O valor apresentado no tempo atual também muda
            labelCurrentTime.Text = timeCount(Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition));
        }

        /// <summary>
        /// Avança 10 segundos, no tempo de reprodução
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJumpForward_Click(object sender, EventArgs e)
        {
            // São adicionados 10 segundos ao tempo de reprodução
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition + 10;
            progressBarTime.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            // O valor apresentado no tempo atual também muda
            labelCurrentTime.Text = timeCount(Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition));
        }

        /// <summary>
        /// Configura o volume do vídeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            // Define o volume do player como o valor escolhido na trackBar
            axWindowsMediaPlayer1.settings.volume = volumeTrackBar.Value;

            // Apresentação do valor do volume ao utilizador
            labelVolume.Text = Convert.ToString(volumeTrackBar.Value) + "%";
        }

        #endregion

        #region Timer

        private void timer_Tick(object sender, EventArgs e)
        {
            // Definição do valor máximo da barra de progresso
            progressBarTime.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;

            // O valor da progressBarTime é igual ao valor da posição atual do player
            progressBarTime.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

            // Atribuição de valores às labels de tempo
            labelTotalTime.Text = timeCount(Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration));
            labelCurrentTime.Text = timeCount(Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition));
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Abre a janela FormAudioPlayer
        /// </summary>
        /// <param name="obj"></param>
        private void abrirJanela(object obj)
        {
            Application.Run(new FormAudioPlayer());
        }

        /// <summary>
        /// Converte o tempo de segundos para o formato minutos : segundos (02:10)
        /// </summary>
        /// <param name="secTotal"></param>
        /// <returns></returns>
        private string timeCount(int secTotal)
        {
            // Variáveis
            string tempo;
            int horas, minutos, segundos;

            horas = secTotal / 3600; // Divisão inteira por 3600 dá o valor de horas exatas
            secTotal = secTotal % 3600; // O resto da divisão por 3600 dá os segundos restantes, que precisam de ser convertidos em minutos e segundos

            minutos = secTotal / 60; // Divisão inteira por 60 dá o valor de minutos exatos

            segundos = secTotal % 60; // O resto da divisão por 60 dá o número de segundos exatos

            // De maneira a que a disposição seja sempre a mesma, é necessário adicionar o 0 das dezenas a valores somente nas unidade (<10)

            // Se as horas forem inferiores a 10, coloca um 0 à frente do número de horas
            if (horas < 10)
            {
                tempo = "0" + horas;

                // Se os minutos forem inferiores a 10, coloca um 0 à frente do número de minutos
                if (minutos < 10)
                {
                    tempo += ":0" + minutos;

                    // Se os segundos forem inferiores a 10, coloca um 0 à frente do número de segundos
                    if (segundos < 10)
                    {
                        tempo += ":0" + segundos;
                    }

                    // Senão, se os segundos forem superiores a 10, não coloca nada à frente do número de segundos
                    else
                    {
                        tempo += ":" + segundos;
                    }
                }

                // Senão, se os minutos forem superiores a 10, não coloca nada à frente do número de minutos
                else
                {
                    tempo += ":" + minutos;

                    // Se os segundos forem inferiores a 10, coloca um 0 à frente do número de segundos
                    if (segundos < 10)
                    {
                        tempo += ":0" + segundos;
                    }

                    // Senão, se os segundos forem superiores a 10, não coloca nada à frente do número de segundos
                    else
                    {
                        tempo += ":" + segundos;
                    }
                }
            }
            // Senão, se as horas forem superiores a 10, não coloca nada à frente do número de horas
            else
            {
                tempo = "" + horas;

                // Se os minutos forem inferiores a 10, coloca um 0 à frente do número de minutos
                if (minutos < 10)
                {
                    tempo += ":0" + minutos;

                    // Se os segundos forem inferiores a 10, coloca um 0 à frente do número de segundos
                    if (segundos < 10)
                    {
                        tempo += ":0" + segundos;
                    }

                    // Senão, se os segundos forem superiores a 10, não coloca nada à frente do número de segundos
                    else
                    {
                        tempo += ":" + segundos;
                    }
                }

                // Senão, se os minutos forem superiores a 10, não coloca nada à frente do número de minutos
                else
                {
                    tempo += ":" + minutos;

                    // Se os segundos forem inferiores a 10, coloca um 0 à frente do número de segundos
                    if (segundos < 10)
                    {
                        tempo += ":0" + segundos;
                    }

                    // Senão, se os segundos forem superiores a 10, não coloca nada à frente do número de segundos
                    else
                    {
                        tempo += ":" + segundos;
                    }
                }
            }

            // Devolve o tempo, no formato correto
            return tempo;
        }

        #endregion

      
    }
}
