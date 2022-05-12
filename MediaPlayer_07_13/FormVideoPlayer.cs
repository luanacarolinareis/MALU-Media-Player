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
using Microsoft.DirectX.AudioVideoPlayback;

namespace MediaPlayer_07_13
{
    public partial class FormVideoPlayer : Form
    {
        Thread audioPlayer;

        public FormVideoPlayer()
        {
            InitializeComponent();
            volumeTrackBar.Value = 4;
            
        }
        private void FormVideoPlayer_Load(object sender, EventArgs e)
        {
            textBoxFile.Text = "https://youtu.be/mbbJ0rwkX8Q";
        }

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

        #region Método de abertura do FormAudioPlayer

        /// <summary>
        /// Abre a janela FormAudioPlayer
        /// </summary>
        /// <param name="obj"></param>
        private void abrirJanela(object obj)
        {
            Application.Run(new FormAudioPlayer());
        }

        #endregion

        private void timer_tick(object sender, EventArgs e)
        {

        }

        private void abrirFicheiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Diálogo para selecionar o ficheiro
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtro de ficheiros (.mp4, .mov, .wmv, .avi, .webm)
            openFileDialog.Filter = "Video Files(*.MP4; *.MOV; *.WMV; *.AVI) | *.MP4; *.MOV; *.WMV; *.AVI; | All Files(*.*) | *.*";

            // Propriedades
            openFileDialog.Multiselect = false;
            openFileDialog.Title = "Select a video file...";
            openFileDialog.InitialDirectory = "C:\\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = openFileDialog.FileName;
            }

        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            // Play / pause
            if (btnPlayPause.Text == "Pause")
            {
                btnPlayPause.Text = "Play";

            }
            else
            {
                btnPlayPause.Text = "Pause";
            }

        }

    
    }
}
