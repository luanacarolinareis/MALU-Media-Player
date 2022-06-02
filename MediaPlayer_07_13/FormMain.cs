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
    public partial class FormMain : Form
    {
        // Threads usadas para abrir o formulário de áudio e de vídeo
        Thread videoPlayer, audioPlayer;

        // Variáveis que controlam cliques em botões
        int maximizeClick = 0;

        // Os valores que vão ser adicionados à barra de carregamento inicial vão ser randomizados
        Random number = new Random();

        public FormMain()
        {
            InitializeComponent();

            // Muda as configurações de cores do MenuStripOptions
            menuStripOptions.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());

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
                this.Height = 613;
                this.Width = 928;
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
            audioPlayer = new Thread(abrirJanelaAudio);
            audioPlayer.SetApartmentState(ApartmentState.STA);
            audioPlayer.Start();
        }

        /// <summary>
        /// Abre o formulário específico para reprodução de vídeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemVideoPlayer_Click(object sender, EventArgs e)
        {
            this.Close();
            videoPlayer = new Thread(abrirJanelaVideo);
            videoPlayer.SetApartmentState(ApartmentState.STA);
            videoPlayer.Start();
        }

        #endregion

        #region Métodos de abertura dos Forms

        /// <summary>
        /// Timer para a abertura do programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Se a barra de progresso já tiver atingido o valor 100 significa que o programa já foi carregado e deve ser aberto
                if (bunifuProgressBarInitial.Value >= 100)
                {
                    // O painel fica visível e tanto o logótipo como a barra de progresso ficam invisíveis 
                    panel2.Visible = true;
                    bunifuProgressBarInitial.Visible = false;
                    bunifuPictureBoxInitial.Visible = false;
                    labelTitle.Visible = false;

                    // Aparecem a caixa de novidades e a descrição
                    bunifuGroupBox.Visible = true;
                    labelNews.Visible = true;
                    labelDescription.Visible = true;
                }

                // Senão, deve-se adicionar algo ao seu valor
                else
                {
                    bunifuProgressBarInitial.Value += number.Next(1, 20);
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Abre a janela FormVideoPlayer
        /// </summary>
        /// <param name="obj"></param>
        private void abrirJanelaVideo(object obj)
        {
            Application.Run(new FormVideoPlayer());
        }

        /// <summary>
        /// Abre a janela FormAudioPlayer
        /// </summary>
        /// <param name="obj"></param>
        private void abrirJanelaAudio(object obj)
        {
            Application.Run(new FormAudioPlayer());
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
