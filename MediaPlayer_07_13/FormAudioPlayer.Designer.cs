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
            this.ToolStripMenuItemabrirFicheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTocar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMultimedia = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVideoPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelLateral = new System.Windows.Forms.Panel();
            this.bunifuImgBtnPlaylist = new Bunifu.UI.WinForms.BunifuImageButton();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.panelBaixo = new System.Windows.Forms.Panel();
            this.bunifuImgBtnLoop = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImgBtnVolume = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuProgressBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.bunifuImgBtnSkipTen = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImgBtnBackTen = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImgBtnPP = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuVolumeBar = new Bunifu.UI.WinForms.BunifuHScrollBar();
            this.bunifuImgBtnPrevious = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImgBtnNext = new Bunifu.UI.WinForms.BunifuImageButton();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBoxAudioGif = new System.Windows.Forms.PictureBox();
            this.panelTopo.SuspendLayout();
            this.menuStripOptions.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.panelBaixo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudioGif)).BeginInit();
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
            this.panelTopo.Size = new System.Drawing.Size(636, 52);
            this.panelTopo.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Black;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.MediumOrchid;
            this.buttonClose.Location = new System.Drawing.Point(588, 12);
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
            this.menuStripOptions.Size = new System.Drawing.Size(269, 30);
            this.menuStripOptions.TabIndex = 0;
            this.menuStripOptions.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFicheiro
            // 
            this.ToolStripMenuItemFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemabrirFicheiro,
            this.ToolStripMenuItemSair});
            this.ToolStripMenuItemFicheiro.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemFicheiro.Name = "ToolStripMenuItemFicheiro";
            this.ToolStripMenuItemFicheiro.Size = new System.Drawing.Size(83, 26);
            this.ToolStripMenuItemFicheiro.Text = "Ficheiro";
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
            this.ToolStripMenuItemAdicionar.Click += new System.EventHandler(this.ToolStripMenuItemAdicionar_Click);
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
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.ForeColor = System.Drawing.Color.MediumOrchid;
            this.labelVolume.Location = new System.Drawing.Point(499, 35);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(45, 20);
            this.labelVolume.TabIndex = 11;
            this.labelVolume.Text = "50%";
            this.labelVolume.Visible = false;
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTime.ForeColor = System.Drawing.Color.MediumOrchid;
            this.labelTotalTime.Location = new System.Drawing.Point(514, 10);
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
            this.labelCurrentTime.Location = new System.Drawing.Point(6, 10);
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
            this.panelLateral.Controls.Add(this.bunifuImgBtnPlaylist);
            this.panelLateral.Controls.Add(this.listBoxPlaylist);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 52);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(55, 454);
            this.panelLateral.TabIndex = 14;
            // 
            // bunifuImgBtnPlaylist
            // 
            this.bunifuImgBtnPlaylist.ActiveImage = null;
            this.bunifuImgBtnPlaylist.AllowAnimations = true;
            this.bunifuImgBtnPlaylist.AllowBuffering = false;
            this.bunifuImgBtnPlaylist.AllowToggling = false;
            this.bunifuImgBtnPlaylist.AllowZooming = true;
            this.bunifuImgBtnPlaylist.AllowZoomingOnFocus = false;
            this.bunifuImgBtnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImgBtnPlaylist.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImgBtnPlaylist.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPlaylist.ErrorImage")));
            this.bunifuImgBtnPlaylist.FadeWhenInactive = false;
            this.bunifuImgBtnPlaylist.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImgBtnPlaylist.Image = global::MediaPlayer_07_13.Properties.Resources.Menu_26px_audio;
            this.bunifuImgBtnPlaylist.ImageActive = null;
            this.bunifuImgBtnPlaylist.ImageLocation = null;
            this.bunifuImgBtnPlaylist.ImageMargin = 20;
            this.bunifuImgBtnPlaylist.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImgBtnPlaylist.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnPlaylist.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPlaylist.InitialImage")));
            this.bunifuImgBtnPlaylist.Location = new System.Drawing.Point(3, 3);
            this.bunifuImgBtnPlaylist.Name = "bunifuImgBtnPlaylist";
            this.bunifuImgBtnPlaylist.Rotation = 0;
            this.bunifuImgBtnPlaylist.ShowActiveImage = true;
            this.bunifuImgBtnPlaylist.ShowCursorChanges = true;
            this.bunifuImgBtnPlaylist.ShowImageBorders = true;
            this.bunifuImgBtnPlaylist.ShowSizeMarkers = false;
            this.bunifuImgBtnPlaylist.Size = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnPlaylist.TabIndex = 16;
            this.bunifuImgBtnPlaylist.ToolTipText = "";
            this.bunifuImgBtnPlaylist.WaitOnLoad = false;
            this.bunifuImgBtnPlaylist.Zoom = 20;
            this.bunifuImgBtnPlaylist.ZoomSpeed = 10;
            this.bunifuImgBtnPlaylist.Click += new System.EventHandler(this.bunifuImgBtnPlaylist_Click);
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.BackColor = System.Drawing.Color.MediumOrchid;
            this.listBoxPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.ItemHeight = 16;
            this.listBoxPlaylist.Location = new System.Drawing.Point(6, 59);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(217, 32);
            this.listBoxPlaylist.TabIndex = 16;
            this.listBoxPlaylist.Visible = false;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);
            // 
            // panelBaixo
            // 
            this.panelBaixo.BackColor = System.Drawing.Color.Black;
            this.panelBaixo.Controls.Add(this.bunifuImgBtnLoop);
            this.panelBaixo.Controls.Add(this.bunifuImgBtnVolume);
            this.panelBaixo.Controls.Add(this.bunifuProgressBar);
            this.panelBaixo.Controls.Add(this.bunifuImgBtnSkipTen);
            this.panelBaixo.Controls.Add(this.bunifuImgBtnBackTen);
            this.panelBaixo.Controls.Add(this.bunifuImgBtnPP);
            this.panelBaixo.Controls.Add(this.bunifuVolumeBar);
            this.panelBaixo.Controls.Add(this.bunifuImgBtnPrevious);
            this.panelBaixo.Controls.Add(this.bunifuImgBtnNext);
            this.panelBaixo.Controls.Add(this.labelVolume);
            this.panelBaixo.Controls.Add(this.labelTotalTime);
            this.panelBaixo.Controls.Add(this.labelCurrentTime);
            this.panelBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBaixo.Location = new System.Drawing.Point(55, 400);
            this.panelBaixo.Name = "panelBaixo";
            this.panelBaixo.Size = new System.Drawing.Size(581, 106);
            this.panelBaixo.TabIndex = 15;
            // 
            // bunifuImgBtnLoop
            // 
            this.bunifuImgBtnLoop.ActiveImage = null;
            this.bunifuImgBtnLoop.AllowAnimations = true;
            this.bunifuImgBtnLoop.AllowBuffering = false;
            this.bunifuImgBtnLoop.AllowToggling = false;
            this.bunifuImgBtnLoop.AllowZooming = false;
            this.bunifuImgBtnLoop.AllowZoomingOnFocus = false;
            this.bunifuImgBtnLoop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImgBtnLoop.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImgBtnLoop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImgBtnLoop.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnLoop.ErrorImage")));
            this.bunifuImgBtnLoop.FadeWhenInactive = false;
            this.bunifuImgBtnLoop.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImgBtnLoop.Image = global::MediaPlayer_07_13.Properties.Resources.repeat_32px_audio;
            this.bunifuImgBtnLoop.ImageActive = null;
            this.bunifuImgBtnLoop.ImageLocation = null;
            this.bunifuImgBtnLoop.ImageMargin = 10;
            this.bunifuImgBtnLoop.ImageSize = new System.Drawing.Size(40, 40);
            this.bunifuImgBtnLoop.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnLoop.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnLoop.InitialImage")));
            this.bunifuImgBtnLoop.Location = new System.Drawing.Point(11, 35);
            this.bunifuImgBtnLoop.Name = "bunifuImgBtnLoop";
            this.bunifuImgBtnLoop.Rotation = 0;
            this.bunifuImgBtnLoop.ShowActiveImage = true;
            this.bunifuImgBtnLoop.ShowCursorChanges = true;
            this.bunifuImgBtnLoop.ShowImageBorders = true;
            this.bunifuImgBtnLoop.ShowSizeMarkers = false;
            this.bunifuImgBtnLoop.Size = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnLoop.TabIndex = 16;
            this.bunifuImgBtnLoop.ToolTipText = "";
            this.bunifuImgBtnLoop.WaitOnLoad = false;
            this.bunifuImgBtnLoop.Zoom = 10;
            this.bunifuImgBtnLoop.ZoomSpeed = 10;
            this.bunifuImgBtnLoop.Click += new System.EventHandler(this.bunifuImgBtnLoop_Click);
            // 
            // bunifuImgBtnVolume
            // 
            this.bunifuImgBtnVolume.ActiveImage = null;
            this.bunifuImgBtnVolume.AllowAnimations = true;
            this.bunifuImgBtnVolume.AllowBuffering = false;
            this.bunifuImgBtnVolume.AllowToggling = false;
            this.bunifuImgBtnVolume.AllowZooming = true;
            this.bunifuImgBtnVolume.AllowZoomingOnFocus = false;
            this.bunifuImgBtnVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImgBtnVolume.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImgBtnVolume.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImgBtnVolume.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnVolume.ErrorImage")));
            this.bunifuImgBtnVolume.FadeWhenInactive = false;
            this.bunifuImgBtnVolume.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImgBtnVolume.Image = global::MediaPlayer_07_13.Properties.Resources.sound_audio;
            this.bunifuImgBtnVolume.ImageActive = null;
            this.bunifuImgBtnVolume.ImageLocation = null;
            this.bunifuImgBtnVolume.ImageMargin = 10;
            this.bunifuImgBtnVolume.ImageSize = new System.Drawing.Size(30, 30);
            this.bunifuImgBtnVolume.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.bunifuImgBtnVolume.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnVolume.InitialImage")));
            this.bunifuImgBtnVolume.Location = new System.Drawing.Point(421, 45);
            this.bunifuImgBtnVolume.Name = "bunifuImgBtnVolume";
            this.bunifuImgBtnVolume.Rotation = 0;
            this.bunifuImgBtnVolume.ShowActiveImage = true;
            this.bunifuImgBtnVolume.ShowCursorChanges = true;
            this.bunifuImgBtnVolume.ShowImageBorders = true;
            this.bunifuImgBtnVolume.ShowSizeMarkers = false;
            this.bunifuImgBtnVolume.Size = new System.Drawing.Size(40, 40);
            this.bunifuImgBtnVolume.TabIndex = 22;
            this.bunifuImgBtnVolume.ToolTipText = "";
            this.bunifuImgBtnVolume.WaitOnLoad = false;
            this.bunifuImgBtnVolume.Zoom = 10;
            this.bunifuImgBtnVolume.ZoomSpeed = 10;
            this.bunifuImgBtnVolume.Click += new System.EventHandler(this.bunifuImgBtnVolume_Click);
            // 
            // bunifuProgressBar
            // 
            this.bunifuProgressBar.AllowCursorChanges = true;
            this.bunifuProgressBar.AllowHomeEndKeysDetection = false;
            this.bunifuProgressBar.AllowIncrementalClickMoves = true;
            this.bunifuProgressBar.AllowMouseDownEffects = false;
            this.bunifuProgressBar.AllowMouseHoverEffects = false;
            this.bunifuProgressBar.AllowScrollingAnimations = true;
            this.bunifuProgressBar.AllowScrollKeysDetection = true;
            this.bunifuProgressBar.AllowScrollOptionsMenu = true;
            this.bunifuProgressBar.AllowShrinkingOnFocusLost = false;
            this.bunifuProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.bunifuProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBar.BackgroundImage")));
            this.bunifuProgressBar.BindingContainer = null;
            this.bunifuProgressBar.BorderRadius = 2;
            this.bunifuProgressBar.BorderThickness = 1;
            this.bunifuProgressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuProgressBar.DrawThickBorder = false;
            this.bunifuProgressBar.DurationBeforeShrink = 2000;
            this.bunifuProgressBar.ElapsedColor = System.Drawing.Color.MediumOrchid;
            this.bunifuProgressBar.LargeChange = 10;
            this.bunifuProgressBar.Location = new System.Drawing.Point(68, 5);
            this.bunifuProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuProgressBar.Maximum = 100;
            this.bunifuProgressBar.Minimum = 0;
            this.bunifuProgressBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuProgressBar.MinimumThumbLength = 18;
            this.bunifuProgressBar.Name = "bunifuProgressBar";
            this.bunifuProgressBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuProgressBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuProgressBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuProgressBar.ShrinkSizeLimit = 3;
            this.bunifuProgressBar.Size = new System.Drawing.Size(439, 31);
            this.bunifuProgressBar.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuProgressBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuProgressBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuProgressBar.SmallChange = 1;
            this.bunifuProgressBar.TabIndex = 21;
            this.bunifuProgressBar.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBar.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.bunifuProgressBar.ThumbLength = 43;
            this.bunifuProgressBar.ThumbMargin = 1;
            this.bunifuProgressBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuProgressBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuProgressBar.Value = 0;
            // 
            // bunifuImgBtnSkipTen
            // 
            this.bunifuImgBtnSkipTen.ActiveImage = null;
            this.bunifuImgBtnSkipTen.AllowAnimations = true;
            this.bunifuImgBtnSkipTen.AllowBuffering = false;
            this.bunifuImgBtnSkipTen.AllowToggling = false;
            this.bunifuImgBtnSkipTen.AllowZooming = false;
            this.bunifuImgBtnSkipTen.AllowZoomingOnFocus = false;
            this.bunifuImgBtnSkipTen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImgBtnSkipTen.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImgBtnSkipTen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImgBtnSkipTen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnSkipTen.ErrorImage")));
            this.bunifuImgBtnSkipTen.FadeWhenInactive = false;
            this.bunifuImgBtnSkipTen.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImgBtnSkipTen.Image = global::MediaPlayer_07_13.Properties.Resources.forward_10_audio;
            this.bunifuImgBtnSkipTen.ImageActive = null;
            this.bunifuImgBtnSkipTen.ImageLocation = null;
            this.bunifuImgBtnSkipTen.ImageMargin = 10;
            this.bunifuImgBtnSkipTen.ImageSize = new System.Drawing.Size(40, 40);
            this.bunifuImgBtnSkipTen.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnSkipTen.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnSkipTen.InitialImage")));
            this.bunifuImgBtnSkipTen.Location = new System.Drawing.Point(273, 35);
            this.bunifuImgBtnSkipTen.Name = "bunifuImgBtnSkipTen";
            this.bunifuImgBtnSkipTen.Rotation = 0;
            this.bunifuImgBtnSkipTen.ShowActiveImage = true;
            this.bunifuImgBtnSkipTen.ShowCursorChanges = true;
            this.bunifuImgBtnSkipTen.ShowImageBorders = true;
            this.bunifuImgBtnSkipTen.ShowSizeMarkers = false;
            this.bunifuImgBtnSkipTen.Size = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnSkipTen.TabIndex = 20;
            this.bunifuImgBtnSkipTen.ToolTipText = "";
            this.bunifuImgBtnSkipTen.WaitOnLoad = false;
            this.bunifuImgBtnSkipTen.Zoom = 10;
            this.bunifuImgBtnSkipTen.ZoomSpeed = 10;
            this.bunifuImgBtnSkipTen.Click += new System.EventHandler(this.bunifuImgBtnSkipTen_Click);
            // 
            // bunifuImgBtnBackTen
            // 
            this.bunifuImgBtnBackTen.ActiveImage = null;
            this.bunifuImgBtnBackTen.AllowAnimations = true;
            this.bunifuImgBtnBackTen.AllowBuffering = false;
            this.bunifuImgBtnBackTen.AllowToggling = false;
            this.bunifuImgBtnBackTen.AllowZooming = false;
            this.bunifuImgBtnBackTen.AllowZoomingOnFocus = false;
            this.bunifuImgBtnBackTen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImgBtnBackTen.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImgBtnBackTen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImgBtnBackTen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnBackTen.ErrorImage")));
            this.bunifuImgBtnBackTen.FadeWhenInactive = false;
            this.bunifuImgBtnBackTen.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImgBtnBackTen.Image = global::MediaPlayer_07_13.Properties.Resources.replay_10_audio;
            this.bunifuImgBtnBackTen.ImageActive = null;
            this.bunifuImgBtnBackTen.ImageLocation = null;
            this.bunifuImgBtnBackTen.ImageMargin = 10;
            this.bunifuImgBtnBackTen.ImageSize = new System.Drawing.Size(40, 40);
            this.bunifuImgBtnBackTen.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnBackTen.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnBackTen.InitialImage")));
            this.bunifuImgBtnBackTen.Location = new System.Drawing.Point(161, 35);
            this.bunifuImgBtnBackTen.Name = "bunifuImgBtnBackTen";
            this.bunifuImgBtnBackTen.Rotation = 0;
            this.bunifuImgBtnBackTen.ShowActiveImage = true;
            this.bunifuImgBtnBackTen.ShowCursorChanges = true;
            this.bunifuImgBtnBackTen.ShowImageBorders = true;
            this.bunifuImgBtnBackTen.ShowSizeMarkers = false;
            this.bunifuImgBtnBackTen.Size = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnBackTen.TabIndex = 19;
            this.bunifuImgBtnBackTen.ToolTipText = "";
            this.bunifuImgBtnBackTen.WaitOnLoad = false;
            this.bunifuImgBtnBackTen.Zoom = 10;
            this.bunifuImgBtnBackTen.ZoomSpeed = 10;
            this.bunifuImgBtnBackTen.Click += new System.EventHandler(this.bunifuImgBtnBackTen_Click);
            // 
            // bunifuImgBtnPP
            // 
            this.bunifuImgBtnPP.ActiveImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPP.ActiveImage")));
            this.bunifuImgBtnPP.AllowAnimations = true;
            this.bunifuImgBtnPP.AllowBuffering = false;
            this.bunifuImgBtnPP.AllowToggling = false;
            this.bunifuImgBtnPP.AllowZooming = false;
            this.bunifuImgBtnPP.AllowZoomingOnFocus = false;
            this.bunifuImgBtnPP.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImgBtnPP.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImgBtnPP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImgBtnPP.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPP.ErrorImage")));
            this.bunifuImgBtnPP.FadeWhenInactive = false;
            this.bunifuImgBtnPP.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImgBtnPP.Image = global::MediaPlayer_07_13.Properties.Resources.pause_audio;
            this.bunifuImgBtnPP.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPP.ImageActive")));
            this.bunifuImgBtnPP.ImageLocation = null;
            this.bunifuImgBtnPP.ImageMargin = 10;
            this.bunifuImgBtnPP.ImageSize = new System.Drawing.Size(40, 40);
            this.bunifuImgBtnPP.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnPP.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPP.InitialImage")));
            this.bunifuImgBtnPP.Location = new System.Drawing.Point(217, 35);
            this.bunifuImgBtnPP.Name = "bunifuImgBtnPP";
            this.bunifuImgBtnPP.Rotation = 0;
            this.bunifuImgBtnPP.ShowActiveImage = false;
            this.bunifuImgBtnPP.ShowCursorChanges = true;
            this.bunifuImgBtnPP.ShowImageBorders = true;
            this.bunifuImgBtnPP.ShowSizeMarkers = false;
            this.bunifuImgBtnPP.Size = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnPP.TabIndex = 18;
            this.bunifuImgBtnPP.ToolTipText = "";
            this.bunifuImgBtnPP.WaitOnLoad = false;
            this.bunifuImgBtnPP.Zoom = 10;
            this.bunifuImgBtnPP.ZoomSpeed = 10;
            this.bunifuImgBtnPP.Click += new System.EventHandler(this.bunifuImgBtnPP_Click);
            // 
            // bunifuVolumeBar
            // 
            this.bunifuVolumeBar.AllowCursorChanges = true;
            this.bunifuVolumeBar.AllowHomeEndKeysDetection = false;
            this.bunifuVolumeBar.AllowIncrementalClickMoves = true;
            this.bunifuVolumeBar.AllowMouseDownEffects = true;
            this.bunifuVolumeBar.AllowMouseHoverEffects = true;
            this.bunifuVolumeBar.AllowScrollingAnimations = true;
            this.bunifuVolumeBar.AllowScrollKeysDetection = true;
            this.bunifuVolumeBar.AllowScrollOptionsMenu = true;
            this.bunifuVolumeBar.AllowShrinkingOnFocusLost = false;
            this.bunifuVolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuVolumeBar.BackgoundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuVolumeBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVolumeBar.BackgroundImage")));
            this.bunifuVolumeBar.BindingContainer = null;
            this.bunifuVolumeBar.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuVolumeBar.BorderRadius = 12;
            this.bunifuVolumeBar.BorderThickness = 2;
            this.bunifuVolumeBar.DurationBeforeShrink = 2000;
            this.bunifuVolumeBar.LargeChange = 10;
            this.bunifuVolumeBar.Location = new System.Drawing.Point(468, 59);
            this.bunifuVolumeBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuVolumeBar.Maximum = 100;
            this.bunifuVolumeBar.Minimum = 0;
            this.bunifuVolumeBar.MinimumThumbLength = 18;
            this.bunifuVolumeBar.Name = "bunifuVolumeBar";
            this.bunifuVolumeBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVolumeBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVolumeBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVolumeBar.ScrollBarBorderColor = System.Drawing.Color.Transparent;
            this.bunifuVolumeBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuVolumeBar.ShrinkSizeLimit = 3;
            this.bunifuVolumeBar.Size = new System.Drawing.Size(100, 18);
            this.bunifuVolumeBar.SmallChange = 1;
            this.bunifuVolumeBar.TabIndex = 17;
            this.bunifuVolumeBar.ThumbColor = System.Drawing.Color.MediumOrchid;
            this.bunifuVolumeBar.ThumbLength = 18;
            this.bunifuVolumeBar.ThumbMargin = 1;
            this.bunifuVolumeBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHScrollBar.ThumbStyles.Inset;
            this.bunifuVolumeBar.Value = 50;
            this.bunifuVolumeBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs>(this.bunifuVolumeBar_Scroll);
            this.bunifuVolumeBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuVolumeBar_MouseDown);
            this.bunifuVolumeBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuVolumeBar_MouseUp);
            // 
            // bunifuImgBtnPrevious
            // 
            this.bunifuImgBtnPrevious.ActiveImage = null;
            this.bunifuImgBtnPrevious.AllowAnimations = true;
            this.bunifuImgBtnPrevious.AllowBuffering = false;
            this.bunifuImgBtnPrevious.AllowToggling = false;
            this.bunifuImgBtnPrevious.AllowZooming = false;
            this.bunifuImgBtnPrevious.AllowZoomingOnFocus = false;
            this.bunifuImgBtnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImgBtnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImgBtnPrevious.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImgBtnPrevious.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPrevious.ErrorImage")));
            this.bunifuImgBtnPrevious.FadeWhenInactive = false;
            this.bunifuImgBtnPrevious.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImgBtnPrevious.Image = global::MediaPlayer_07_13.Properties.Resources.next_audio;
            this.bunifuImgBtnPrevious.ImageActive = null;
            this.bunifuImgBtnPrevious.ImageLocation = null;
            this.bunifuImgBtnPrevious.ImageMargin = 10;
            this.bunifuImgBtnPrevious.ImageSize = new System.Drawing.Size(40, 40);
            this.bunifuImgBtnPrevious.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnPrevious.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnPrevious.InitialImage")));
            this.bunifuImgBtnPrevious.Location = new System.Drawing.Point(105, 35);
            this.bunifuImgBtnPrevious.Name = "bunifuImgBtnPrevious";
            this.bunifuImgBtnPrevious.Rotation = 180;
            this.bunifuImgBtnPrevious.ShowActiveImage = true;
            this.bunifuImgBtnPrevious.ShowCursorChanges = true;
            this.bunifuImgBtnPrevious.ShowImageBorders = true;
            this.bunifuImgBtnPrevious.ShowSizeMarkers = false;
            this.bunifuImgBtnPrevious.Size = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnPrevious.TabIndex = 15;
            this.bunifuImgBtnPrevious.ToolTipText = "";
            this.bunifuImgBtnPrevious.WaitOnLoad = false;
            this.bunifuImgBtnPrevious.Zoom = 10;
            this.bunifuImgBtnPrevious.ZoomSpeed = 10;
            this.bunifuImgBtnPrevious.Click += new System.EventHandler(this.bunifuImgBtnPrevious_Click);
            // 
            // bunifuImgBtnNext
            // 
            this.bunifuImgBtnNext.ActiveImage = null;
            this.bunifuImgBtnNext.AllowAnimations = true;
            this.bunifuImgBtnNext.AllowBuffering = false;
            this.bunifuImgBtnNext.AllowToggling = false;
            this.bunifuImgBtnNext.AllowZooming = false;
            this.bunifuImgBtnNext.AllowZoomingOnFocus = false;
            this.bunifuImgBtnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuImgBtnNext.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImgBtnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImgBtnNext.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnNext.ErrorImage")));
            this.bunifuImgBtnNext.FadeWhenInactive = false;
            this.bunifuImgBtnNext.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImgBtnNext.Image = global::MediaPlayer_07_13.Properties.Resources.next_audio;
            this.bunifuImgBtnNext.ImageActive = null;
            this.bunifuImgBtnNext.ImageLocation = null;
            this.bunifuImgBtnNext.ImageMargin = 10;
            this.bunifuImgBtnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.bunifuImgBtnNext.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImgBtnNext.InitialImage")));
            this.bunifuImgBtnNext.Location = new System.Drawing.Point(329, 35);
            this.bunifuImgBtnNext.Name = "bunifuImgBtnNext";
            this.bunifuImgBtnNext.Rotation = 0;
            this.bunifuImgBtnNext.ShowActiveImage = true;
            this.bunifuImgBtnNext.ShowCursorChanges = true;
            this.bunifuImgBtnNext.ShowImageBorders = true;
            this.bunifuImgBtnNext.ShowSizeMarkers = false;
            this.bunifuImgBtnNext.Size = new System.Drawing.Size(50, 50);
            this.bunifuImgBtnNext.TabIndex = 14;
            this.bunifuImgBtnNext.ToolTipText = "";
            this.bunifuImgBtnNext.WaitOnLoad = false;
            this.bunifuImgBtnNext.Zoom = 10;
            this.bunifuImgBtnNext.ZoomSpeed = 10;
            this.bunifuImgBtnNext.Click += new System.EventHandler(this.bunifuImgBtnNext_Click);
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(55, 52);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(61, 53);
            this.axWindowsMediaPlayer.TabIndex = 10;
            this.axWindowsMediaPlayer.Visible = false;
            this.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_PlayStateChange);
            // 
            // pictureBoxAudioGif
            // 
            this.pictureBoxAudioGif.Enabled = false;
            this.pictureBoxAudioGif.Image = global::MediaPlayer_07_13.Properties.Resources.AudioGif;
            this.pictureBoxAudioGif.Location = new System.Drawing.Point(55, 55);
            this.pictureBoxAudioGif.Name = "pictureBoxAudioGif";
            this.pictureBoxAudioGif.Size = new System.Drawing.Size(581, 352);
            this.pictureBoxAudioGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAudioGif.TabIndex = 16;
            this.pictureBoxAudioGif.TabStop = false;
            this.pictureBoxAudioGif.Visible = false;
            // 
            // FormAudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(636, 506);
            this.Controls.Add(this.pictureBoxAudioGif);
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
            this.panelLateral.ResumeLayout(false);
            this.panelBaixo.ResumeLayout(false);
            this.panelBaixo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudioGif)).EndInit();
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
        private Bunifu.UI.WinForms.BunifuHScrollBar bunifuVolumeBar;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImgBtnPP;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImgBtnSkipTen;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImgBtnBackTen;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuProgressBar;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImgBtnPlaylist;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImgBtnVolume;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImgBtnLoop;
        private System.Windows.Forms.PictureBox pictureBoxAudioGif;
    }
}