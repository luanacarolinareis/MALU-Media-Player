namespace MediaPlayer_07_13
{
    partial class FormAudioPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAudioPlayer));
            this.panelTopo = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFicheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemabrirFicheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTocar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMultimedia = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVideoPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnSkipTen = new System.Windows.Forms.Button();
            this.btnBackTen = new System.Windows.Forms.Button();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelLateral = new System.Windows.Forms.Panel();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.panelBaixo = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.bunifuImgBtnNext = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImgBtnPrevious = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panelTopo.SuspendLayout();
            this.menuStripOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panelBaixo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.Black;
            this.panelTopo.Controls.Add(this.buttonClose);
            this.panelTopo.Controls.Add(this.menuStripOptions);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(724, 52);
            this.panelTopo.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Black;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.MediumOrchid;
            this.buttonClose.Location = new System.Drawing.Point(676, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(36, 31);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            this.menuStripOptions.Size = new System.Drawing.Size(271, 30);
            this.menuStripOptions.TabIndex = 0;
            this.menuStripOptions.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFicheiro
            // 
            this.ToolStripMenuItemFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSair,
            this.ToolStripMenuItemabrirFicheiro});
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
            this.ToolStripMenuItemSair.Size = new System.Drawing.Size(195, 26);
            this.ToolStripMenuItemSair.Text = "Sair";
            this.ToolStripMenuItemSair.Click += new System.EventHandler(this.ToolStripMenuItemSair_Click);
            // 
            // ToolStripMenuItemabrirFicheiro
            // 
            this.ToolStripMenuItemabrirFicheiro.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItemabrirFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTocar,
            this.ToolStripMenuItemAdicionar});
            this.ToolStripMenuItemabrirFicheiro.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemabrirFicheiro.Name = "ToolStripMenuItemabrirFicheiro";
            this.ToolStripMenuItemabrirFicheiro.Size = new System.Drawing.Size(195, 26);
            this.ToolStripMenuItemabrirFicheiro.Text = "Abrir Ficheiro";
            // 
            // ToolStripMenuItemTocar
            // 
            this.ToolStripMenuItemTocar.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItemTocar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemTocar.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemTocar.Name = "ToolStripMenuItemTocar";
            this.ToolStripMenuItemTocar.Size = new System.Drawing.Size(280, 32);
            this.ToolStripMenuItemTocar.Text = "Tocar Imediatamente";
            this.ToolStripMenuItemTocar.Click += new System.EventHandler(this.ToolStripMenuItemTocar_Click);
            // 
            // ToolStripMenuItemAdicionar
            // 
            this.ToolStripMenuItemAdicionar.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItemAdicionar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemAdicionar.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemAdicionar.Name = "ToolStripMenuItemAdicionar";
            this.ToolStripMenuItemAdicionar.Size = new System.Drawing.Size(280, 32);
            this.ToolStripMenuItemAdicionar.Text = "Adicionar a lista";
            // 
            // ToolStripMenuItemMultimedia
            // 
            this.ToolStripMenuItemMultimedia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVideoPlayer});
            this.ToolStripMenuItemMultimedia.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemMultimedia.Name = "ToolStripMenuItemMultimedia";
            this.ToolStripMenuItemMultimedia.Size = new System.Drawing.Size(110, 26);
            this.ToolStripMenuItemMultimedia.Text = "Multimédia";
            // 
            // ToolStripMenuItemVideoPlayer
            // 
            this.ToolStripMenuItemVideoPlayer.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItemVideoPlayer.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemVideoPlayer.Name = "ToolStripMenuItemVideoPlayer";
            this.ToolStripMenuItemVideoPlayer.Size = new System.Drawing.Size(189, 26);
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
            // btnPlayPause
            // 
            this.btnPlayPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.Location = new System.Drawing.Point(238, 17);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(50, 50);
            this.btnPlayPause.TabIndex = 4;
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnSkipTen
            // 
            this.btnSkipTen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSkipTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkipTen.Location = new System.Drawing.Point(294, 27);
            this.btnSkipTen.Name = "btnSkipTen";
            this.btnSkipTen.Size = new System.Drawing.Size(40, 40);
            this.btnSkipTen.TabIndex = 5;
            this.btnSkipTen.Text = "+ 10s";
            this.btnSkipTen.UseVisualStyleBackColor = true;
            this.btnSkipTen.Click += new System.EventHandler(this.btnSkipTen_Click);
            // 
            // btnBackTen
            // 
            this.btnBackTen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBackTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTen.Location = new System.Drawing.Point(192, 27);
            this.btnBackTen.Name = "btnBackTen";
            this.btnBackTen.Size = new System.Drawing.Size(40, 40);
            this.btnBackTen.TabIndex = 6;
            this.btnBackTen.Text = "- 10s";
            this.btnBackTen.UseVisualStyleBackColor = true;
            this.btnBackTen.Click += new System.EventHandler(this.btnBackTen_Click);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVolume.Location = new System.Drawing.Point(423, 23);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(100, 56);
            this.trackBarVolume.TabIndex = 8;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // progressBarTime
            // 
            this.progressBarTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarTime.Location = new System.Drawing.Point(62, 71);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(391, 20);
            this.progressBarTime.TabIndex = 9;
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.ForeColor = System.Drawing.Color.MediumOrchid;
            this.labelVolume.Location = new System.Drawing.Point(456, 4);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(36, 16);
            this.labelVolume.TabIndex = 11;
            this.labelVolume.Text = "50%";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTime.ForeColor = System.Drawing.Color.MediumOrchid;
            this.labelTotalTime.Location = new System.Drawing.Point(459, 71);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(55, 20);
            this.labelTotalTime.TabIndex = 12;
            this.labelTotalTime.Text = "00:00";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.ForeColor = System.Drawing.Color.MediumOrchid;
            this.labelCurrentTime.Location = new System.Drawing.Point(1, 71);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(55, 20);
            this.labelCurrentTime.TabIndex = 13;
            this.labelCurrentTime.Text = "00:00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelLateral.Controls.Add(this.listBoxPlaylist);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 52);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(198, 489);
            this.panelLateral.TabIndex = 14;
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.BackColor = System.Drawing.Color.MediumOrchid;
            this.listBoxPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.ItemHeight = 16;
            this.listBoxPlaylist.Location = new System.Drawing.Point(0, 0);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(198, 384);
            this.listBoxPlaylist.TabIndex = 16;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);
            // 
            // panelBaixo
            // 
            this.panelBaixo.BackColor = System.Drawing.Color.Black;
            this.panelBaixo.Controls.Add(this.bunifuImgBtnPrevious);
            this.panelBaixo.Controls.Add(this.bunifuImgBtnNext);
            this.panelBaixo.Controls.Add(this.progressBarTime);
            this.panelBaixo.Controls.Add(this.btnBackTen);
            this.panelBaixo.Controls.Add(this.labelVolume);
            this.panelBaixo.Controls.Add(this.labelTotalTime);
            this.panelBaixo.Controls.Add(this.labelCurrentTime);
            this.panelBaixo.Controls.Add(this.trackBarVolume);
            this.panelBaixo.Controls.Add(this.btnSkipTen);
            this.panelBaixo.Controls.Add(this.btnPlayPause);
            this.panelBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBaixo.Location = new System.Drawing.Point(198, 441);
            this.panelBaixo.Name = "panelBaixo";
            this.panelBaixo.Size = new System.Drawing.Size(526, 100);
            this.panelBaixo.TabIndex = 15;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(260, 136);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(334, 180);
            this.axWindowsMediaPlayer.TabIndex = 10;
            // 
            // bunifuImgBtnNext
            // 
            this.bunifuImgBtnNext.ActiveImage = null;
            this.bunifuImgBtnNext.AllowAnimations = true;
            this.bunifuImgBtnNext.AllowBuffering = false;
            this.bunifuImgBtnNext.AllowToggling = false;
            this.bunifuImgBtnNext.AllowZooming = true;
            this.bunifuImgBtnNext.AllowZoomingOnFocus = false;
            this.bunifuImgBtnNext.BackColor = System.Drawing.Color.MediumOrchid;
            this.bunifuImgBtnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImgBtnNext.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnNext.ErrorImage")));
            this.bunifuImgBtnNext.FadeWhenInactive = false;
            this.bunifuImgBtnNext.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImgBtnNext.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnNext.Image")));
            this.bunifuImgBtnNext.ImageActive = null;
            this.bunifuImgBtnNext.ImageLocation = null;
            this.bunifuImgBtnNext.ImageMargin = 20;
            this.bunifuImgBtnNext.ImageSize = new System.Drawing.Size(36, 43);
            this.bunifuImgBtnNext.ImageZoomSize = new System.Drawing.Size(56, 63);
            this.bunifuImgBtnNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnNext.InitialImage")));
            this.bunifuImgBtnNext.Location = new System.Drawing.Point(340, 4);
            this.bunifuImgBtnNext.Name = "bunifuImgBtnNext";
            this.bunifuImgBtnNext.Rotation = 0;
            this.bunifuImgBtnNext.ShowActiveImage = true;
            this.bunifuImgBtnNext.ShowCursorChanges = true;
            this.bunifuImgBtnNext.ShowImageBorders = true;
            this.bunifuImgBtnNext.ShowSizeMarkers = false;
            this.bunifuImgBtnNext.Size = new System.Drawing.Size(56, 63);
            this.bunifuImgBtnNext.TabIndex = 14;
            this.bunifuImgBtnNext.ToolTipText = "";
            this.bunifuImgBtnNext.WaitOnLoad = false;
            this.bunifuImgBtnNext.Zoom = 20;
            this.bunifuImgBtnNext.ZoomSpeed = 10;
            this.bunifuImgBtnNext.Click += new System.EventHandler(this.bunifuImgBtnNext_Click);
            // 
            // bunifuImgBtnPrevious
            // 
            this.bunifuImgBtnPrevious.ActiveImage = null;
            this.bunifuImgBtnPrevious.AllowAnimations = true;
            this.bunifuImgBtnPrevious.AllowBuffering = false;
            this.bunifuImgBtnPrevious.AllowToggling = false;
            this.bunifuImgBtnPrevious.AllowZooming = true;
            this.bunifuImgBtnPrevious.AllowZoomingOnFocus = false;
            this.bunifuImgBtnPrevious.BackColor = System.Drawing.Color.MediumOrchid;
            this.bunifuImgBtnPrevious.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImgBtnPrevious.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPrevious.ErrorImage")));
            this.bunifuImgBtnPrevious.FadeWhenInactive = false;
            this.bunifuImgBtnPrevious.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImgBtnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPrevious.Image")));
            this.bunifuImgBtnPrevious.ImageActive = null;
            this.bunifuImgBtnPrevious.ImageLocation = null;
            this.bunifuImgBtnPrevious.ImageMargin = 20;
            this.bunifuImgBtnPrevious.ImageSize = new System.Drawing.Size(36, 43);
            this.bunifuImgBtnPrevious.ImageZoomSize = new System.Drawing.Size(56, 63);
            this.bunifuImgBtnPrevious.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPrevious.InitialImage")));
            this.bunifuImgBtnPrevious.Location = new System.Drawing.Point(130, 2);
            this.bunifuImgBtnPrevious.Name = "bunifuImgBtnPrevious";
            this.bunifuImgBtnPrevious.Rotation = 0;
            this.bunifuImgBtnPrevious.ShowActiveImage = true;
            this.bunifuImgBtnPrevious.ShowCursorChanges = true;
            this.bunifuImgBtnPrevious.ShowImageBorders = true;
            this.bunifuImgBtnPrevious.ShowSizeMarkers = false;
            this.bunifuImgBtnPrevious.Size = new System.Drawing.Size(56, 63);
            this.bunifuImgBtnPrevious.TabIndex = 15;
            this.bunifuImgBtnPrevious.ToolTipText = "";
            this.bunifuImgBtnPrevious.WaitOnLoad = false;
            this.bunifuImgBtnPrevious.Zoom = 20;
            this.bunifuImgBtnPrevious.ZoomSpeed = 10;
            this.bunifuImgBtnPrevious.Click += new System.EventHandler(this.bunifuImgBtnPrevious_Click);
            // 
            // FormAudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(724, 541);
            this.Controls.Add(this.panelBaixo);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.panelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormAudioPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAudioPlayer";
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelBaixo.ResumeLayout(false);
            this.panelBaixo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.MenuStrip menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFicheiro;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSair;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAjuda;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMultimedia;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVideoPlayer;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemabrirFicheiro;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTocar;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAdicionar;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnSkipTen;
        private System.Windows.Forms.Button btnBackTen;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.ProgressBar progressBarTime;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelBaixo;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImgBtnNext;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImgBtnPrevious;
    }
}