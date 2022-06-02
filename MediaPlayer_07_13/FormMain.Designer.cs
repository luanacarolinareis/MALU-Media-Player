namespace MediaPlayer_07_13
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFicheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMultimedia = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAudioPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVideoPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMaximize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnExitPIP = new Bunifu.UI.WinForms.BunifuImageButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTitle = new System.Windows.Forms.Label();
            this.bunifuPictureBoxInitial = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuProgressBarInitial = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.bunifuGroupBox = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.labelNews = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.menuStripOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxInitial)).BeginInit();
            this.bunifuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.menuStripOptions);
            this.panel2.Controls.Add(this.btnMaximize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnExitPIP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 58);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveImage = null;
            this.btnMinimize.AllowAnimations = true;
            this.btnMinimize.AllowBuffering = false;
            this.btnMinimize.AllowToggling = false;
            this.btnMinimize.AllowZooming = false;
            this.btnMinimize.AllowZoomingOnFocus = false;
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ErrorImage")));
            this.btnMinimize.FadeWhenInactive = false;
            this.btnMinimize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMinimize.Image = global::MediaPlayer_07_13.Properties.Resources.minimize_window;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.ImageLocation = null;
            this.btnMinimize.ImageMargin = 20;
            this.btnMinimize.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMinimize.ImageZoomSize = new System.Drawing.Size(55, 55);
            this.btnMinimize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.InitialImage")));
            this.btnMinimize.Location = new System.Drawing.Point(1058, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0;
            this.btnMinimize.ShowActiveImage = true;
            this.btnMinimize.ShowCursorChanges = true;
            this.btnMinimize.ShowImageBorders = true;
            this.btnMinimize.ShowSizeMarkers = false;
            this.btnMinimize.Size = new System.Drawing.Size(55, 55);
            this.btnMinimize.TabIndex = 29;
            this.btnMinimize.ToolTipText = "";
            this.btnMinimize.WaitOnLoad = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.ZoomSpeed = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // menuStripOptions
            // 
            this.menuStripOptions.BackColor = System.Drawing.Color.Transparent;
            this.menuStripOptions.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripOptions.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFicheiro,
            this.ToolStripMenuItemMultimedia,
            this.ToolStripMenuItemAjuda});
            this.menuStripOptions.Location = new System.Drawing.Point(9, 13);
            this.menuStripOptions.Name = "menuStripOptions";
            this.menuStripOptions.Size = new System.Drawing.Size(269, 30);
            this.menuStripOptions.TabIndex = 0;
            this.menuStripOptions.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFicheiro
            // 
            this.ToolStripMenuItemFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSair});
            this.ToolStripMenuItemFicheiro.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemFicheiro.Name = "ToolStripMenuItemFicheiro";
            this.ToolStripMenuItemFicheiro.Size = new System.Drawing.Size(83, 26);
            this.ToolStripMenuItemFicheiro.Text = "Ficheiro";
            // 
            // ToolStripMenuItemSair
            // 
            this.ToolStripMenuItemSair.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItemSair.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemSair.Name = "ToolStripMenuItemSair";
            this.ToolStripMenuItemSair.Size = new System.Drawing.Size(122, 26);
            this.ToolStripMenuItemSair.Text = "Sair";
            this.ToolStripMenuItemSair.Click += new System.EventHandler(this.ToolStripMenuItemSair_Click);
            // 
            // ToolStripMenuItemMultimedia
            // 
            this.ToolStripMenuItemMultimedia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAudioPlayer,
            this.ToolStripMenuItemVideoPlayer});
            this.ToolStripMenuItemMultimedia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ToolStripMenuItemMultimedia.Name = "ToolStripMenuItemMultimedia";
            this.ToolStripMenuItemMultimedia.Size = new System.Drawing.Size(110, 26);
            this.ToolStripMenuItemMultimedia.Text = "Multimédia";
            // 
            // ToolStripMenuItemAudioPlayer
            // 
            this.ToolStripMenuItemAudioPlayer.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItemAudioPlayer.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemAudioPlayer.Name = "ToolStripMenuItemAudioPlayer";
            this.ToolStripMenuItemAudioPlayer.Size = new System.Drawing.Size(190, 26);
            this.ToolStripMenuItemAudioPlayer.Text = "Audio Player";
            this.ToolStripMenuItemAudioPlayer.Click += new System.EventHandler(this.ToolStripMenuItemAudioPlayer_Click);
            // 
            // ToolStripMenuItemVideoPlayer
            // 
            this.ToolStripMenuItemVideoPlayer.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItemVideoPlayer.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemVideoPlayer.Name = "ToolStripMenuItemVideoPlayer";
            this.ToolStripMenuItemVideoPlayer.Size = new System.Drawing.Size(190, 26);
            this.ToolStripMenuItemVideoPlayer.Text = "Video Player";
            this.ToolStripMenuItemVideoPlayer.Click += new System.EventHandler(this.ToolStripMenuItemVideoPlayer_Click);
            // 
            // ToolStripMenuItemAjuda
            // 
            this.ToolStripMenuItemAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAcercaDe});
            this.ToolStripMenuItemAjuda.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemAjuda.Name = "ToolStripMenuItemAjuda";
            this.ToolStripMenuItemAjuda.Size = new System.Drawing.Size(68, 26);
            this.ToolStripMenuItemAjuda.Text = "Ajuda";
            this.ToolStripMenuItemAjuda.Click += new System.EventHandler(this.ToolStripMenuItemVideoPlayer_Click);
            // 
            // ToolStripMenuItemAcercaDe
            // 
            this.ToolStripMenuItemAcercaDe.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItemAcercaDe.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemAcercaDe.Name = "ToolStripMenuItemAcercaDe";
            this.ToolStripMenuItemAcercaDe.Size = new System.Drawing.Size(181, 26);
            this.ToolStripMenuItemAcercaDe.Text = "Acerca de...";
            this.ToolStripMenuItemAcercaDe.Click += new System.EventHandler(this.ToolStripMenuItemAcercaDe_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.ActiveImage = null;
            this.btnMaximize.AllowAnimations = true;
            this.btnMaximize.AllowBuffering = false;
            this.btnMaximize.AllowToggling = false;
            this.btnMaximize.AllowZooming = false;
            this.btnMaximize.AllowZoomingOnFocus = false;
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaximize.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.ErrorImage")));
            this.btnMaximize.FadeWhenInactive = false;
            this.btnMaximize.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMaximize.Image = global::MediaPlayer_07_13.Properties.Resources.maximize_window;
            this.btnMaximize.ImageActive = null;
            this.btnMaximize.ImageLocation = null;
            this.btnMaximize.ImageMargin = 20;
            this.btnMaximize.ImageSize = new System.Drawing.Size(35, 35);
            this.btnMaximize.ImageZoomSize = new System.Drawing.Size(55, 55);
            this.btnMaximize.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.InitialImage")));
            this.btnMaximize.Location = new System.Drawing.Point(1119, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Rotation = 0;
            this.btnMaximize.ShowActiveImage = true;
            this.btnMaximize.ShowCursorChanges = true;
            this.btnMaximize.ShowImageBorders = true;
            this.btnMaximize.ShowSizeMarkers = false;
            this.btnMaximize.Size = new System.Drawing.Size(55, 55);
            this.btnMaximize.TabIndex = 28;
            this.btnMaximize.ToolTipText = "";
            this.btnMaximize.WaitOnLoad = false;
            this.btnMaximize.Zoom = 20;
            this.btnMaximize.ZoomSpeed = 10;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = false;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::MediaPlayer_07_13.Properties.Resources.close_app;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(55, 55);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1180, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(55, 55);
            this.btnClose.TabIndex = 27;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExitPIP
            // 
            this.btnExitPIP.ActiveImage = null;
            this.btnExitPIP.AllowAnimations = true;
            this.btnExitPIP.AllowBuffering = false;
            this.btnExitPIP.AllowToggling = false;
            this.btnExitPIP.AllowZooming = false;
            this.btnExitPIP.AllowZoomingOnFocus = false;
            this.btnExitPIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitPIP.BackColor = System.Drawing.Color.Transparent;
            this.btnExitPIP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExitPIP.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnExitPIP.ErrorImage")));
            this.btnExitPIP.FadeWhenInactive = false;
            this.btnExitPIP.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnExitPIP.Image = global::MediaPlayer_07_13.Properties.Resources.picture_in_picture;
            this.btnExitPIP.ImageActive = null;
            this.btnExitPIP.ImageLocation = null;
            this.btnExitPIP.ImageMargin = 20;
            this.btnExitPIP.ImageSize = new System.Drawing.Size(38, 38);
            this.btnExitPIP.ImageZoomSize = new System.Drawing.Size(58, 58);
            this.btnExitPIP.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnExitPIP.InitialImage")));
            this.btnExitPIP.Location = new System.Drawing.Point(1180, -11);
            this.btnExitPIP.Name = "btnExitPIP";
            this.btnExitPIP.Rotation = 0;
            this.btnExitPIP.ShowActiveImage = true;
            this.btnExitPIP.ShowCursorChanges = true;
            this.btnExitPIP.ShowImageBorders = true;
            this.btnExitPIP.ShowSizeMarkers = false;
            this.btnExitPIP.Size = new System.Drawing.Size(58, 58);
            this.btnExitPIP.TabIndex = 30;
            this.btnExitPIP.ToolTipText = "";
            this.btnExitPIP.Visible = false;
            this.btnExitPIP.WaitOnLoad = false;
            this.btnExitPIP.Zoom = 20;
            this.btnExitPIP.ZoomSpeed = 10;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(488, 623);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(261, 37);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "MALU Media Player";
            // 
            // bunifuPictureBoxInitial
            // 
            this.bunifuPictureBoxInitial.AllowFocused = false;
            this.bunifuPictureBoxInitial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBoxInitial.AutoSizeHeight = true;
            this.bunifuPictureBoxInitial.BorderRadius = 188;
            this.bunifuPictureBoxInitial.Image = global::MediaPlayer_07_13.Properties.Resources.Aimp_Player_350px;
            this.bunifuPictureBoxInitial.IsCircle = true;
            this.bunifuPictureBoxInitial.Location = new System.Drawing.Point(431, 185);
            this.bunifuPictureBoxInitial.Name = "bunifuPictureBoxInitial";
            this.bunifuPictureBoxInitial.Size = new System.Drawing.Size(376, 376);
            this.bunifuPictureBoxInitial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBoxInitial.TabIndex = 4;
            this.bunifuPictureBoxInitial.TabStop = false;
            this.bunifuPictureBoxInitial.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuProgressBarInitial
            // 
            this.bunifuProgressBarInitial.AllowAnimations = false;
            this.bunifuProgressBarInitial.Animation = 0;
            this.bunifuProgressBarInitial.AnimationSpeed = 220;
            this.bunifuProgressBarInitial.AnimationStep = 10;
            this.bunifuProgressBarInitial.BackColor = System.Drawing.Color.Black;
            this.bunifuProgressBarInitial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBarInitial.BackgroundImage")));
            this.bunifuProgressBarInitial.BorderColor = System.Drawing.Color.Ivory;
            this.bunifuProgressBarInitial.BorderRadius = 10;
            this.bunifuProgressBarInitial.BorderThickness = 1;
            this.bunifuProgressBarInitial.Location = new System.Drawing.Point(359, 693);
            this.bunifuProgressBarInitial.Maximum = 100;
            this.bunifuProgressBarInitial.MaximumValue = 100;
            this.bunifuProgressBarInitial.Minimum = 0;
            this.bunifuProgressBarInitial.MinimumValue = 0;
            this.bunifuProgressBarInitial.Name = "bunifuProgressBarInitial";
            this.bunifuProgressBarInitial.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bunifuProgressBarInitial.ProgressBackColor = System.Drawing.Color.Black;
            this.bunifuProgressBarInitial.ProgressColorLeft = System.Drawing.Color.SteelBlue;
            this.bunifuProgressBarInitial.ProgressColorRight = System.Drawing.Color.SteelBlue;
            this.bunifuProgressBarInitial.Size = new System.Drawing.Size(520, 10);
            this.bunifuProgressBarInitial.TabIndex = 3;
            this.bunifuProgressBarInitial.Value = 0;
            this.bunifuProgressBarInitial.ValueByTransition = 0;
            // 
            // bunifuGroupBox
            // 
            this.bunifuGroupBox.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox.BorderRadius = 1;
            this.bunifuGroupBox.BorderThickness = 1;
            this.bunifuGroupBox.Controls.Add(this.labelNews);
            this.bunifuGroupBox.Controls.Add(this.labelDescription);
            this.bunifuGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox.LabelIndent = 10;
            this.bunifuGroupBox.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox.Location = new System.Drawing.Point(65, 173);
            this.bunifuGroupBox.Name = "bunifuGroupBox";
            this.bunifuGroupBox.Size = new System.Drawing.Size(1109, 464);
            this.bunifuGroupBox.TabIndex = 6;
            this.bunifuGroupBox.TabStop = false;
            this.bunifuGroupBox.Text = "bunifuGroupBox1";
            this.bunifuGroupBox.Visible = false;
            // 
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.BackColor = System.Drawing.Color.Transparent;
            this.labelNews.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNews.ForeColor = System.Drawing.Color.White;
            this.labelNews.Location = new System.Drawing.Point(23, 63);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(190, 40);
            this.labelNews.TabIndex = 0;
            this.labelNews.Text = "NOVIDADES!";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.ForeColor = System.Drawing.Color.White;
            this.labelDescription.Location = new System.Drawing.Point(30, 139);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(524, 220);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = resources.GetString("labelDescription.Text");
            this.labelDescription.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1238, 755);
            this.Controls.Add(this.bunifuPictureBoxInitial);
            this.Controls.Add(this.bunifuGroupBox);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.bunifuProgressBarInitial);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripOptions;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBoxInitial)).EndInit();
            this.bunifuGroupBox.ResumeLayout(false);
            this.bunifuGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFicheiro;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAjuda;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMultimedia;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAudioPlayer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVideoPlayer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSair;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinimize;
        private Bunifu.UI.WinForms.BunifuImageButton btnMaximize;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuImageButton btnExitPIP;
        private Bunifu.UI.WinForms.BunifuProgressBar bunifuProgressBarInitial;
        private System.Windows.Forms.Timer timer;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBoxInitial;
        private System.Windows.Forms.Label labelTitle;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelNews;
    }
}

