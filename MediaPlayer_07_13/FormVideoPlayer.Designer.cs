namespace MediaPlayer_07_13
{
    partial class FormVideoPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideoPlayer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMaximize = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFicheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFicheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMultimedia = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAudioPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExitPIP = new Bunifu.UI.WinForms.BunifuImageButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnRestart = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPictureInPicture = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnFullScreen = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMute = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuVolumeBar = new Bunifu.UI.WinForms.BunifuHScrollBar();
            this.bunifuProgressBar = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnJumpForward = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnJumpBack = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuImageButton();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2.SuspendLayout();
            this.menuStripOptions.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnMaximize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.menuStripOptions);
            this.panel2.Controls.Add(this.btnExitPIP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1390, 50);
            this.panel2.TabIndex = 3;
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
            this.btnMinimize.Location = new System.Drawing.Point(1210, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Rotation = 0;
            this.btnMinimize.ShowActiveImage = true;
            this.btnMinimize.ShowCursorChanges = true;
            this.btnMinimize.ShowImageBorders = true;
            this.btnMinimize.ShowSizeMarkers = false;
            this.btnMinimize.Size = new System.Drawing.Size(55, 55);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.ToolTipText = "";
            this.btnMinimize.WaitOnLoad = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.ZoomSpeed = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            this.btnMaximize.Location = new System.Drawing.Point(1271, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Rotation = 0;
            this.btnMaximize.ShowActiveImage = true;
            this.btnMaximize.ShowCursorChanges = true;
            this.btnMaximize.ShowImageBorders = true;
            this.btnMaximize.ShowSizeMarkers = false;
            this.btnMaximize.Size = new System.Drawing.Size(55, 55);
            this.btnMaximize.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(1332, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(55, 55);
            this.btnClose.TabIndex = 1;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.ToolStripMenuItemFicheiro.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripMenuItemFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFicheiroToolStripMenuItem,
            this.ToolStripMenuItemSair});
            this.ToolStripMenuItemFicheiro.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemFicheiro.Name = "ToolStripMenuItemFicheiro";
            this.ToolStripMenuItemFicheiro.Size = new System.Drawing.Size(83, 26);
            this.ToolStripMenuItemFicheiro.Text = "Ficheiro";
            // 
            // abrirFicheiroToolStripMenuItem
            // 
            this.abrirFicheiroToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.abrirFicheiroToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.abrirFicheiroToolStripMenuItem.Name = "abrirFicheiroToolStripMenuItem";
            this.abrirFicheiroToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.abrirFicheiroToolStripMenuItem.Text = "Abrir ficheiro...";
            this.abrirFicheiroToolStripMenuItem.Click += new System.EventHandler(this.abrirFicheiroToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemSair
            // 
            this.ToolStripMenuItemSair.BackColor = System.Drawing.Color.Black;
            this.ToolStripMenuItemSair.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemSair.Name = "ToolStripMenuItemSair";
            this.ToolStripMenuItemSair.Size = new System.Drawing.Size(204, 26);
            this.ToolStripMenuItemSair.Text = "Sair";
            this.ToolStripMenuItemSair.Click += new System.EventHandler(this.ToolStripMenuItemSair_Click);
            // 
            // ToolStripMenuItemMultimedia
            // 
            this.ToolStripMenuItemMultimedia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAudioPlayer});
            this.ToolStripMenuItemMultimedia.ForeColor = System.Drawing.Color.White;
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
            this.btnExitPIP.Location = new System.Drawing.Point(1332, -11);
            this.btnExitPIP.Name = "btnExitPIP";
            this.btnExitPIP.Rotation = 0;
            this.btnExitPIP.ShowActiveImage = true;
            this.btnExitPIP.ShowCursorChanges = true;
            this.btnExitPIP.ShowImageBorders = true;
            this.btnExitPIP.ShowSizeMarkers = false;
            this.btnExitPIP.Size = new System.Drawing.Size(58, 58);
            this.btnExitPIP.TabIndex = 26;
            this.btnExitPIP.ToolTipText = "";
            this.btnExitPIP.Visible = false;
            this.btnExitPIP.WaitOnLoad = false;
            this.btnExitPIP.Zoom = 20;
            this.btnExitPIP.ZoomSpeed = 10;
            this.btnExitPIP.Click += new System.EventHandler(this.btnExitPIP_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnRestart);
            this.panel3.Controls.Add(this.btnPictureInPicture);
            this.panel3.Controls.Add(this.btnFullScreen);
            this.panel3.Controls.Add(this.btnMute);
            this.panel3.Controls.Add(this.bunifuVolumeBar);
            this.panel3.Controls.Add(this.bunifuProgressBar);
            this.panel3.Controls.Add(this.btnJumpForward);
            this.panel3.Controls.Add(this.btnJumpBack);
            this.panel3.Controls.Add(this.btnPlay);
            this.panel3.Controls.Add(this.labelVolume);
            this.panel3.Controls.Add(this.labelTotalTime);
            this.panel3.Controls.Add(this.labelCurrentTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 598);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1390, 100);
            this.panel3.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.ActiveImage = null;
            this.btnReset.AllowAnimations = true;
            this.btnReset.AllowBuffering = false;
            this.btnReset.AllowToggling = false;
            this.btnReset.AllowZooming = false;
            this.btnReset.AllowZoomingOnFocus = false;
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnReset.ErrorImage")));
            this.btnReset.FadeWhenInactive = false;
            this.btnReset.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnReset.Image = global::MediaPlayer_07_13.Properties.Resources.reset_32px;
            this.btnReset.ImageActive = null;
            this.btnReset.ImageLocation = null;
            this.btnReset.ImageMargin = 20;
            this.btnReset.ImageSize = new System.Drawing.Size(56, 46);
            this.btnReset.ImageZoomSize = new System.Drawing.Size(76, 66);
            this.btnReset.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnReset.InitialImage")));
            this.btnReset.Location = new System.Drawing.Point(816, 35);
            this.btnReset.Name = "btnReset";
            this.btnReset.Rotation = 0;
            this.btnReset.ShowActiveImage = true;
            this.btnReset.ShowCursorChanges = true;
            this.btnReset.ShowImageBorders = true;
            this.btnReset.ShowSizeMarkers = false;
            this.btnReset.Size = new System.Drawing.Size(76, 66);
            this.btnReset.TabIndex = 25;
            this.btnReset.ToolTipText = "";
            this.btnReset.WaitOnLoad = false;
            this.btnReset.Zoom = 20;
            this.btnReset.ZoomSpeed = 10;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.ActiveImage = null;
            this.btnRestart.AllowAnimations = true;
            this.btnRestart.AllowBuffering = false;
            this.btnRestart.AllowToggling = false;
            this.btnRestart.AllowZooming = false;
            this.btnRestart.AllowZoomingOnFocus = false;
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRestart.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.ErrorImage")));
            this.btnRestart.FadeWhenInactive = false;
            this.btnRestart.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnRestart.Image = global::MediaPlayer_07_13.Properties.Resources.repeat_32px;
            this.btnRestart.ImageActive = null;
            this.btnRestart.ImageLocation = null;
            this.btnRestart.ImageMargin = 20;
            this.btnRestart.ImageSize = new System.Drawing.Size(46, 46);
            this.btnRestart.ImageZoomSize = new System.Drawing.Size(66, 66);
            this.btnRestart.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRestart.InitialImage")));
            this.btnRestart.Location = new System.Drawing.Point(508, 35);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Rotation = 0;
            this.btnRestart.ShowActiveImage = true;
            this.btnRestart.ShowCursorChanges = true;
            this.btnRestart.ShowImageBorders = true;
            this.btnRestart.ShowSizeMarkers = false;
            this.btnRestart.Size = new System.Drawing.Size(66, 66);
            this.btnRestart.TabIndex = 24;
            this.btnRestart.ToolTipText = "";
            this.btnRestart.WaitOnLoad = false;
            this.btnRestart.Zoom = 20;
            this.btnRestart.ZoomSpeed = 10;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnPictureInPicture
            // 
            this.btnPictureInPicture.ActiveImage = null;
            this.btnPictureInPicture.AllowAnimations = true;
            this.btnPictureInPicture.AllowBuffering = false;
            this.btnPictureInPicture.AllowToggling = false;
            this.btnPictureInPicture.AllowZooming = false;
            this.btnPictureInPicture.AllowZoomingOnFocus = false;
            this.btnPictureInPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPictureInPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPictureInPicture.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPictureInPicture.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPictureInPicture.ErrorImage")));
            this.btnPictureInPicture.FadeWhenInactive = false;
            this.btnPictureInPicture.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPictureInPicture.Image = global::MediaPlayer_07_13.Properties.Resources.picture_in_picture;
            this.btnPictureInPicture.ImageActive = null;
            this.btnPictureInPicture.ImageLocation = null;
            this.btnPictureInPicture.ImageMargin = 20;
            this.btnPictureInPicture.ImageSize = new System.Drawing.Size(46, 46);
            this.btnPictureInPicture.ImageZoomSize = new System.Drawing.Size(66, 66);
            this.btnPictureInPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPictureInPicture.InitialImage")));
            this.btnPictureInPicture.Location = new System.Drawing.Point(201, 35);
            this.btnPictureInPicture.Name = "btnPictureInPicture";
            this.btnPictureInPicture.Rotation = 0;
            this.btnPictureInPicture.ShowActiveImage = true;
            this.btnPictureInPicture.ShowCursorChanges = true;
            this.btnPictureInPicture.ShowImageBorders = true;
            this.btnPictureInPicture.ShowSizeMarkers = false;
            this.btnPictureInPicture.Size = new System.Drawing.Size(66, 66);
            this.btnPictureInPicture.TabIndex = 23;
            this.btnPictureInPicture.ToolTipText = "";
            this.btnPictureInPicture.WaitOnLoad = false;
            this.btnPictureInPicture.Zoom = 20;
            this.btnPictureInPicture.ZoomSpeed = 10;
            this.btnPictureInPicture.Click += new System.EventHandler(this.btnPictureInPicture_Click);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.ActiveImage = null;
            this.btnFullScreen.AllowAnimations = true;
            this.btnFullScreen.AllowBuffering = false;
            this.btnFullScreen.AllowToggling = false;
            this.btnFullScreen.AllowZooming = false;
            this.btnFullScreen.AllowZoomingOnFocus = false;
            this.btnFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFullScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnFullScreen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFullScreen.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.ErrorImage")));
            this.btnFullScreen.FadeWhenInactive = false;
            this.btnFullScreen.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnFullScreen.Image = global::MediaPlayer_07_13.Properties.Resources.full_screen_30px;
            this.btnFullScreen.ImageActive = null;
            this.btnFullScreen.ImageLocation = null;
            this.btnFullScreen.ImageMargin = 20;
            this.btnFullScreen.ImageSize = new System.Drawing.Size(46, 46);
            this.btnFullScreen.ImageZoomSize = new System.Drawing.Size(66, 66);
            this.btnFullScreen.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.InitialImage")));
            this.btnFullScreen.Location = new System.Drawing.Point(129, 35);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Rotation = 0;
            this.btnFullScreen.ShowActiveImage = true;
            this.btnFullScreen.ShowCursorChanges = true;
            this.btnFullScreen.ShowImageBorders = true;
            this.btnFullScreen.ShowSizeMarkers = false;
            this.btnFullScreen.Size = new System.Drawing.Size(66, 66);
            this.btnFullScreen.TabIndex = 22;
            this.btnFullScreen.ToolTipText = "";
            this.btnFullScreen.WaitOnLoad = false;
            this.btnFullScreen.Zoom = 20;
            this.btnFullScreen.ZoomSpeed = 10;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // btnMute
            // 
            this.btnMute.ActiveImage = null;
            this.btnMute.AllowAnimations = true;
            this.btnMute.AllowBuffering = false;
            this.btnMute.AllowToggling = false;
            this.btnMute.AllowZooming = false;
            this.btnMute.AllowZoomingOnFocus = false;
            this.btnMute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMute.BackColor = System.Drawing.Color.Transparent;
            this.btnMute.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMute.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMute.ErrorImage")));
            this.btnMute.FadeWhenInactive = false;
            this.btnMute.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMute.ForeColor = System.Drawing.Color.Transparent;
            this.btnMute.Image = global::MediaPlayer_07_13.Properties.Resources.sound;
            this.btnMute.ImageActive = null;
            this.btnMute.ImageLocation = null;
            this.btnMute.ImageMargin = 20;
            this.btnMute.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMute.ImageZoomSize = new System.Drawing.Size(60, 60);
            this.btnMute.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMute.InitialImage")));
            this.btnMute.Location = new System.Drawing.Point(1074, 41);
            this.btnMute.Name = "btnMute";
            this.btnMute.Rotation = 0;
            this.btnMute.ShowActiveImage = true;
            this.btnMute.ShowCursorChanges = true;
            this.btnMute.ShowImageBorders = true;
            this.btnMute.ShowSizeMarkers = false;
            this.btnMute.Size = new System.Drawing.Size(60, 60);
            this.btnMute.TabIndex = 21;
            this.btnMute.ToolTipText = "";
            this.btnMute.WaitOnLoad = false;
            this.btnMute.Zoom = 20;
            this.btnMute.ZoomSpeed = 10;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
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
            this.bunifuVolumeBar.Location = new System.Drawing.Point(1141, 63);
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
            this.bunifuVolumeBar.TabIndex = 14;
            this.bunifuVolumeBar.ThumbColor = System.Drawing.Color.MediumOrchid;
            this.bunifuVolumeBar.ThumbLength = 18;
            this.bunifuVolumeBar.ThumbMargin = 1;
            this.bunifuVolumeBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHScrollBar.ThumbStyles.Inset;
            this.bunifuVolumeBar.Value = 50;
            this.bunifuVolumeBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuHScrollBar.ScrollEventArgs>(this.bunifuVolumeBar_Scroll);
            this.bunifuVolumeBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuVolumeBar_MouseDown);
            this.bunifuVolumeBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuVolumeBar_MouseUp);
            // 
            // bunifuProgressBar
            // 
            this.bunifuProgressBar.AllowCursorChanges = true;
            this.bunifuProgressBar.AllowHomeEndKeysDetection = true;
            this.bunifuProgressBar.AllowIncrementalClickMoves = true;
            this.bunifuProgressBar.AllowMouseDownEffects = false;
            this.bunifuProgressBar.AllowMouseHoverEffects = false;
            this.bunifuProgressBar.AllowScrollingAnimations = true;
            this.bunifuProgressBar.AllowScrollKeysDetection = true;
            this.bunifuProgressBar.AllowScrollOptionsMenu = true;
            this.bunifuProgressBar.AllowShrinkingOnFocusLost = false;
            this.bunifuProgressBar.BackColor = System.Drawing.Color.Black;
            this.bunifuProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBar.BackgroundImage")));
            this.bunifuProgressBar.BindingContainer = null;
            this.bunifuProgressBar.BorderRadius = 2;
            this.bunifuProgressBar.BorderThickness = 1;
            this.bunifuProgressBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuProgressBar.DrawThickBorder = false;
            this.bunifuProgressBar.DurationBeforeShrink = 2000;
            this.bunifuProgressBar.ElapsedColor = System.Drawing.Color.LightSlateGray;
            this.bunifuProgressBar.LargeChange = 10;
            this.bunifuProgressBar.Location = new System.Drawing.Point(0, 0);
            this.bunifuProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuProgressBar.Maximum = 100;
            this.bunifuProgressBar.Minimum = 0;
            this.bunifuProgressBar.MinimumSize = new System.Drawing.Size(0, 31);
            this.bunifuProgressBar.MinimumThumbLength = 18;
            this.bunifuProgressBar.Name = "bunifuProgressBar";
            this.bunifuProgressBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuProgressBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar.ScrollBarBorderColor = System.Drawing.Color.White;
            this.bunifuProgressBar.ScrollBarColor = System.Drawing.Color.White;
            this.bunifuProgressBar.ShrinkSizeLimit = 3;
            this.bunifuProgressBar.Size = new System.Drawing.Size(1390, 31);
            this.bunifuProgressBar.SliderColor = System.Drawing.Color.White;
            this.bunifuProgressBar.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.bunifuProgressBar.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.bunifuProgressBar.SmallChange = 1;
            this.bunifuProgressBar.TabIndex = 14;
            this.bunifuProgressBar.ThumbColor = System.Drawing.Color.MediumOrchid;
            this.bunifuProgressBar.ThumbFillColor = System.Drawing.Color.White;
            this.bunifuProgressBar.ThumbLength = 137;
            this.bunifuProgressBar.ThumbMargin = 1;
            this.bunifuProgressBar.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.bunifuProgressBar.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuProgressBar.Value = 0;
            this.bunifuProgressBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bunifuProgressBar_MouseUp);
            // 
            // btnJumpForward
            // 
            this.btnJumpForward.ActiveImage = null;
            this.btnJumpForward.AllowAnimations = true;
            this.btnJumpForward.AllowBuffering = false;
            this.btnJumpForward.AllowToggling = false;
            this.btnJumpForward.AllowZooming = false;
            this.btnJumpForward.AllowZoomingOnFocus = false;
            this.btnJumpForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJumpForward.BackColor = System.Drawing.Color.Transparent;
            this.btnJumpForward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnJumpForward.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnJumpForward.ErrorImage")));
            this.btnJumpForward.FadeWhenInactive = false;
            this.btnJumpForward.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnJumpForward.Image = global::MediaPlayer_07_13.Properties.Resources.forward_10;
            this.btnJumpForward.ImageActive = null;
            this.btnJumpForward.ImageLocation = null;
            this.btnJumpForward.ImageMargin = 20;
            this.btnJumpForward.ImageSize = new System.Drawing.Size(56, 46);
            this.btnJumpForward.ImageZoomSize = new System.Drawing.Size(76, 66);
            this.btnJumpForward.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnJumpForward.InitialImage")));
            this.btnJumpForward.Location = new System.Drawing.Point(734, 35);
            this.btnJumpForward.Name = "btnJumpForward";
            this.btnJumpForward.Rotation = 0;
            this.btnJumpForward.ShowActiveImage = true;
            this.btnJumpForward.ShowCursorChanges = true;
            this.btnJumpForward.ShowImageBorders = true;
            this.btnJumpForward.ShowSizeMarkers = false;
            this.btnJumpForward.Size = new System.Drawing.Size(76, 66);
            this.btnJumpForward.TabIndex = 19;
            this.btnJumpForward.ToolTipText = "";
            this.btnJumpForward.WaitOnLoad = false;
            this.btnJumpForward.Zoom = 20;
            this.btnJumpForward.ZoomSpeed = 10;
            this.btnJumpForward.Click += new System.EventHandler(this.btnJumpForward_Click);
            // 
            // btnJumpBack
            // 
            this.btnJumpBack.ActiveImage = null;
            this.btnJumpBack.AllowAnimations = true;
            this.btnJumpBack.AllowBuffering = false;
            this.btnJumpBack.AllowToggling = false;
            this.btnJumpBack.AllowZooming = false;
            this.btnJumpBack.AllowZoomingOnFocus = false;
            this.btnJumpBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnJumpBack.BackColor = System.Drawing.Color.Transparent;
            this.btnJumpBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnJumpBack.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnJumpBack.ErrorImage")));
            this.btnJumpBack.FadeWhenInactive = false;
            this.btnJumpBack.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnJumpBack.Image = global::MediaPlayer_07_13.Properties.Resources.replay_10;
            this.btnJumpBack.ImageActive = null;
            this.btnJumpBack.ImageLocation = null;
            this.btnJumpBack.ImageMargin = 20;
            this.btnJumpBack.ImageSize = new System.Drawing.Size(56, 46);
            this.btnJumpBack.ImageZoomSize = new System.Drawing.Size(76, 66);
            this.btnJumpBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnJumpBack.InitialImage")));
            this.btnJumpBack.Location = new System.Drawing.Point(580, 35);
            this.btnJumpBack.Name = "btnJumpBack";
            this.btnJumpBack.Rotation = 0;
            this.btnJumpBack.ShowActiveImage = true;
            this.btnJumpBack.ShowCursorChanges = true;
            this.btnJumpBack.ShowImageBorders = true;
            this.btnJumpBack.ShowSizeMarkers = false;
            this.btnJumpBack.Size = new System.Drawing.Size(76, 66);
            this.btnJumpBack.TabIndex = 18;
            this.btnJumpBack.ToolTipText = "";
            this.btnJumpBack.WaitOnLoad = false;
            this.btnJumpBack.Zoom = 20;
            this.btnJumpBack.ZoomSpeed = 10;
            this.btnJumpBack.Click += new System.EventHandler(this.btnJumpBack_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.ActiveImage = null;
            this.btnPlay.AllowAnimations = true;
            this.btnPlay.AllowBuffering = false;
            this.btnPlay.AllowToggling = false;
            this.btnPlay.AllowZooming = false;
            this.btnPlay.AllowZoomingOnFocus = false;
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.ErrorImage")));
            this.btnPlay.FadeWhenInactive = false;
            this.btnPlay.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPlay.Image = global::MediaPlayer_07_13.Properties.Resources.pause;
            this.btnPlay.ImageActive = null;
            this.btnPlay.ImageLocation = null;
            this.btnPlay.ImageMargin = 20;
            this.btnPlay.ImageSize = new System.Drawing.Size(46, 46);
            this.btnPlay.ImageZoomSize = new System.Drawing.Size(66, 66);
            this.btnPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.InitialImage")));
            this.btnPlay.Location = new System.Drawing.Point(662, 35);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0;
            this.btnPlay.ShowActiveImage = true;
            this.btnPlay.ShowCursorChanges = true;
            this.btnPlay.ShowImageBorders = true;
            this.btnPlay.ShowSizeMarkers = false;
            this.btnPlay.Size = new System.Drawing.Size(66, 66);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.ToolTipText = "";
            this.btnPlay.WaitOnLoad = false;
            this.btnPlay.Zoom = 20;
            this.btnPlay.ZoomSpeed = 10;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.ForeColor = System.Drawing.Color.MediumOrchid;
            this.labelVolume.Location = new System.Drawing.Point(1171, 39);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(42, 20);
            this.labelVolume.TabIndex = 17;
            this.labelVolume.Text = "50%";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTime.ForeColor = System.Drawing.Color.White;
            this.labelTotalTime.Location = new System.Drawing.Point(1305, 35);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(73, 20);
            this.labelTotalTime.TabIndex = 16;
            this.labelTotalTime.Text = "00:00:00";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.ForeColor = System.Drawing.Color.White;
            this.labelCurrentTime.Location = new System.Drawing.Point(12, 35);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(73, 20);
            this.labelCurrentTime.TabIndex = 15;
            this.labelCurrentTime.Text = "00:00:00";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 50);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1390, 548);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            this.axWindowsMediaPlayer1.MouseUpEvent += new AxWMPLib._WMPOCXEvents_MouseUpEventHandler(this.axWindowsMediaPlayer1_MouseUpEvent);
            // 
            // FormVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1390, 698);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "FormVideoPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVideoPlayer_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFicheiro;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSair;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAjuda;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMultimedia;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAudioPlayer;
        private System.Windows.Forms.ToolStripMenuItem abrirFicheiroToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelCurrentTime;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuImageButton btnPlay;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Bunifu.UI.WinForms.BunifuImageButton btnJumpForward;
        private Bunifu.UI.WinForms.BunifuImageButton btnJumpBack;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuProgressBar;
        private Bunifu.UI.WinForms.BunifuHScrollBar bunifuVolumeBar;
        private Bunifu.UI.WinForms.BunifuImageButton btnMute;
        private Bunifu.UI.WinForms.BunifuImageButton btnMinimize;
        private Bunifu.UI.WinForms.BunifuImageButton btnMaximize;
        private Bunifu.UI.WinForms.BunifuImageButton btnPictureInPicture;
        private Bunifu.UI.WinForms.BunifuImageButton btnFullScreen;
        private Bunifu.UI.WinForms.BunifuImageButton btnRestart;
        private Bunifu.UI.WinForms.BunifuImageButton btnReset;
        private Bunifu.UI.WinForms.BunifuImageButton btnExitPIP;
    }
}