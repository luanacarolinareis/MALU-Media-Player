using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MediaPlayer_07_13
{
    public partial class FormAudioPlayer : Form
    {
        string audioPlayerName;
        SoundPlayer audioPlayer;
        public FormAudioPlayer()
        {
            InitializeComponent();
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
        /// (placeholder) selects the file to be played and initiates it in the player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilePlaceholder_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            audioPlayerName = openFileDialog.FileName;
            audioPlayer = new SoundPlayer(audioPlayerName);
        }

        /// <summary>
        /// starts and stops reproduction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            int play = 0; // audio's state ( in play: play=1 ; stopped play=0 )
            if (play == 0)
            {
                
                audioPlayer.Play();
                play = 1;
            }
            else
            {
                audioPlayer.Stop();
                play = 0;
            }
        }

        
    }
}
