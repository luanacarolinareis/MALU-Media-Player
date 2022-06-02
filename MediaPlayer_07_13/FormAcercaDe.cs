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
    public partial class FormAcercaDe : Form
    {
        public FormAcercaDe()
        {
            InitializeComponent();
        }

        #region Botão de close

        /// <summary>
        /// Fecha o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion

        #region Informações

        /// <summary>
        /// Abre a informação "O projeto"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProjeto_Click(object sender, EventArgs e)
        {
            // Fonte do título: REGULAR
            label1.Font = new Font(label1.Font, FontStyle.Regular);

            // Título do separador aberto
            label1.Text = "O PROJETO";

            // Descrição
            label2.Text = "O objetivo deste projeto é criar um reprodutor de mídia (vídeo e áudio) que seja funcional e acessível ao utilizador.\n" + "\n" +"Foi realizado no âmbito da disciplina de Aplicações Informáticas B, lecionada pelo professor Alexandre Ferraz.";

            // Os elementos necessários ficam visíveis
            pictureBoxVisualStudio.Visible = true;
            pictureBoxSourceCode.Visible = true;

            // Os elementos desnecessários ficam invisíveis
            bunifuRating.Visible = false;
            bunifuTextBoxFeedback.Visible = false;
            btnOkSubmit.Visible = false;
            labelFeedback.Visible = false;
            btnCarolina.Visible = false;
            btnHenrique.Visible = false;
            bunifuPictureBoxUs.Visible = false;
        }

        /// <summary>
        /// Abre a informação "Feedback"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            // Fonte do título: ITALIC
            label1.Font = new Font(label1.Font, FontStyle.Italic);

            // Título do separador aberto
            label1.Text = "FEEDBACK";

            // Descrição
            label2.Text = @"A sua opinião vale ouro! Avalie o nosso trabalho e dê-nos o seu feedback (bugs, melhorias e sugestões a implementar)...";

            bunifuRating.Value = 3;
            bunifuTextBoxFeedback.Text = "";

            // Os elementos desnecessários ficam invisíveis
            pictureBoxVisualStudio.Visible = false;
            pictureBoxSourceCode.Visible = false;
            labelFeedback.Visible = false;
            btnCarolina.Visible = false;
            btnHenrique.Visible = false;
            bunifuPictureBoxUs.Visible = false;

            // Os elementos necessários ficam visíveis
            bunifuRating.Visible = true;
            bunifuTextBoxFeedback.Visible = true;

        }

        /// <summary>
        /// Abre a informação "Quem somos"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuemSomos_Click(object sender, EventArgs e)
        {
            btnCarolina.Visible = true;
            btnHenrique.Visible = true;
        }

        /// <summary>
        /// Sobre "Carolina"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarolina_Click(object sender, EventArgs e)
        {
            // Fonte do título: REGULAR
            label1.Font = new Font(label1.Font, FontStyle.Regular);

            // Título do separador aberto
            label1.Text = "CAROLINA";

            // Descrição
            label2.Text = "\nResponsável pelo desenvolvimento da secção de reprodução de vídeo.\n" + "\n" + "Profissional em inventar problemas e em querer sempre mais funcionalidades (aka trabalhadora) :)";

            // Alteração da imagem
            bunifuPictureBoxUs.Image = Properties.Resources.lulu_aka_trabalhadora;

            // Os elementos necessários ficam visíveis
            bunifuPictureBoxUs.Visible = true;

            // Os elementos desnecessários ficam invisíveis
            bunifuRating.Visible = false;
            bunifuTextBoxFeedback.Visible = false;
            btnOkSubmit.Visible = false;
            labelFeedback.Visible = false;
            pictureBoxVisualStudio.Visible = false;
            pictureBoxSourceCode.Visible = false;
        }

        /// <summary>
        /// Sobre "Henrique"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHenrique_Click(object sender, EventArgs e)
        {
            // Fonte do título: REGULAR
            label1.Font = new Font(label1.Font, FontStyle.Regular);

            // Título do separador aberto
            label1.Text = "HENRIQUE";

            // Descrição
            label2.Text = "\nResponsável pelo desenvolvimento da secção de reprodução de áudio.\n" + "\n" + "Dorminhoco de serviço e calmante certificado da designer (aka trabalhadora)...";

            // Alteração da imagem
            bunifuPictureBoxUs.Image = Properties.Resources.jesus_boy;

            // Os elementos necessários ficam visíveis
            bunifuPictureBoxUs.Visible = true;

            // Os elementos desnecessários ficam invisíveis
            bunifuRating.Visible = false;
            bunifuTextBoxFeedback.Visible = false;
            btnOkSubmit.Visible = false;
            labelFeedback.Visible = false;
            pictureBoxVisualStudio.Visible = false;
            pictureBoxSourceCode.Visible = false;
        }

        #endregion

        #region Outras configurações e funções

        /// <summary>
        /// Oculta e extende o menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Se o painel estiver em modo reduzido
            if (panel1.Width == 64)
            {
                // Os botões ficam visíveis
                btnProjeto.Visible = true;
                btnFeedback.Visible = true;
                btnQuemSomos.Visible = true;
                bunifuPictureBoxLogo.Visible = true;
                labelTitle.Visible = true;

                // O comprimento do painel aumenta para 178
                panel1.Width = 178;

                // As caixas de texto ajustam-se e extendem-se
                bunifuGroupBox.Width = 376;
                bunifuGroupBox.Height = 284;
                label2.Width = 338;
                label2.Height = 164;
                bunifuGroupBox.Location = new Point(214, 67);
            }

            // Senão, se estiver em modo extendido
            else
            {
                // Os botões ficam invisíveis
                btnProjeto.Visible = false;
                btnFeedback.Visible = false;
                btnQuemSomos.Visible = false;
                bunifuPictureBoxLogo.Visible = false;
                labelTitle.Visible = false;
                btnCarolina.Visible = false;
                btnHenrique.Visible = false;

                // O comprimento do painel reduz para 64
                panel1.Width = 64;

                // As caixas de texto ajustam-se e reduzem-se
                bunifuGroupBox.Width = 488;
                bunifuGroupBox.Height = 284;
                label2.Width = 452;
                label2.Height = 164;
                bunifuGroupBox.Location = new Point(100, 67);
            }
        }

        /// <summary>
        /// Submissão da avaliação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOkSubmit_Click(object sender, EventArgs e)
        {
            // Remove os campos de avaliação para mostrar a mensagem de agradecimento
            bunifuRating.Visible = false;
            bunifuTextBoxFeedback.Visible = false;
            labelFeedback.Visible = true;

        }

        /// <summary>
        /// Quando a bunifuTextBoxFeedback tem texto, o botão "OK" aparece
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuTextBoxFeedback_TextChange(object sender, EventArgs e)
        {
            // Se tem texto
            if (bunifuTextBoxFeedback.Text != "")
            {
                btnOkSubmit.Visible = true;
            }

            // Senão, se não tem texto
            else
            {
                btnOkSubmit.Visible = false;
            }
        }

        /// <summary>
        /// Atalhos de teclado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAcercaDe_KeyDown(object sender, KeyEventArgs e)
        {
            // Quando o utilizador clica no "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                // Submete a avaliação
                btnOkSubmit.PerformClick();

                // Remoção do som de sistema do Windows
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        #endregion


       
    }
}