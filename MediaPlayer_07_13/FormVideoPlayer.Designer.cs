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
            this.buttonClose = new System.Windows.Forms.Button();
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFicheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFicheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMultimedia = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAudioPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnJumpBack = new System.Windows.Forms.Button();
            this.btnJumpForward = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.vlcControl = new Vlc.DotNet.Forms.VlcControl();
            this.panel2.SuspendLayout();
            this.menuStripOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Controls.Add(this.menuStripOptions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1284, 58);
            this.panel2.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(1215, 12);
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
            this.abrirFicheiroToolStripMenuItem,
            this.ToolStripMenuItemSair});
            this.ToolStripMenuItemFicheiro.Name = "ToolStripMenuItemFicheiro";
            this.ToolStripMenuItemFicheiro.Size = new System.Drawing.Size(83, 26);
            this.ToolStripMenuItemFicheiro.Text = "Ficheiro";
            // 
            // abrirFicheiroToolStripMenuItem
            // 
            this.abrirFicheiroToolStripMenuItem.Name = "abrirFicheiroToolStripMenuItem";
            this.abrirFicheiroToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.abrirFicheiroToolStripMenuItem.Text = "Abrir ficheiro...";
            this.abrirFicheiroToolStripMenuItem.Click += new System.EventHandler(this.abrirFicheiroToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemSair
            // 
            this.ToolStripMenuItemSair.Name = "ToolStripMenuItemSair";
            this.ToolStripMenuItemSair.Size = new System.Drawing.Size(204, 26);
            this.ToolStripMenuItemSair.Text = "Sair";
            this.ToolStripMenuItemSair.Click += new System.EventHandler(this.ToolStripMenuItemSair_Click);
            // 
            // ToolStripMenuItemMultimedia
            // 
            this.ToolStripMenuItemMultimedia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAudioPlayer});
            this.ToolStripMenuItemMultimedia.Name = "ToolStripMenuItemMultimedia";
            this.ToolStripMenuItemMultimedia.Size = new System.Drawing.Size(110, 26);
            this.ToolStripMenuItemMultimedia.Text = "Multimédia";
            // 
            // ToolStripMenuItemAudioPlayer
            // 
            this.ToolStripMenuItemAudioPlayer.Name = "ToolStripMenuItemAudioPlayer";
            this.ToolStripMenuItemAudioPlayer.Size = new System.Drawing.Size(190, 26);
            this.ToolStripMenuItemAudioPlayer.Text = "Audio Player";
            this.ToolStripMenuItemAudioPlayer.Click += new System.EventHandler(this.ToolStripMenuItemAudioPlayer_Click);
            // 
            // ToolStripMenuItemAjuda
            // 
            this.ToolStripMenuItemAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAcercaDe});
            this.ToolStripMenuItemAjuda.Name = "ToolStripMenuItemAjuda";
            this.ToolStripMenuItemAjuda.Size = new System.Drawing.Size(68, 26);
            this.ToolStripMenuItemAjuda.Text = "Ajuda";
            // 
            // ToolStripMenuItemAcercaDe
            // 
            this.ToolStripMenuItemAcercaDe.Name = "ToolStripMenuItemAcercaDe";
            this.ToolStripMenuItemAcercaDe.Size = new System.Drawing.Size(181, 26);
            this.ToolStripMenuItemAcercaDe.Text = "Acerca de...";
            this.ToolStripMenuItemAcercaDe.Click += new System.EventHandler(this.ToolStripMenuItemAcercaDe_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(138, 603);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(106, 53);
            this.btnPlayPause.TabIndex = 4;
            this.btnPlayPause.Text = "Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnJumpBack
            // 
            this.btnJumpBack.Location = new System.Drawing.Point(26, 603);
            this.btnJumpBack.Name = "btnJumpBack";
            this.btnJumpBack.Size = new System.Drawing.Size(106, 53);
            this.btnJumpBack.TabIndex = 5;
            this.btnJumpBack.Text = "-10 s";
            this.btnJumpBack.UseVisualStyleBackColor = true;
            // 
            // btnJumpForward
            // 
            this.btnJumpForward.Location = new System.Drawing.Point(250, 603);
            this.btnJumpForward.Name = "btnJumpForward";
            this.btnJumpForward.Size = new System.Drawing.Size(106, 53);
            this.btnJumpForward.TabIndex = 6;
            this.btnJumpForward.Text = "+10 s";
            this.btnJumpForward.UseVisualStyleBackColor = true;
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(656, 603);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(105, 53);
            this.btnZoom.TabIndex = 7;
            this.btnZoom.Text = "Full Screen";
            this.btnZoom.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Location = new System.Drawing.Point(865, 603);
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(104, 56);
            this.volumeTrackBar.TabIndex = 9;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(656, 575);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(100, 22);
            this.textBoxFile.TabIndex = 10;
            // 
            // vlcControl
            // 
            this.vlcControl.BackColor = System.Drawing.Color.Black;
            this.vlcControl.Location = new System.Drawing.Point(26, 85);
            this.vlcControl.Name = "vlcControl";
            this.vlcControl.Size = new System.Drawing.Size(1191, 465);
            this.vlcControl.Spu = -1;
            this.vlcControl.TabIndex = 11;
            this.vlcControl.Text = "vlcControl1";
            this.vlcControl.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl.VlcLibDirectory")));
            this.vlcControl.VlcMediaplayerOptions = null;
            // 
            // FormVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 684);
            this.Controls.Add(this.vlcControl);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.volumeTrackBar);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.btnJumpForward);
            this.Controls.Add(this.btnJumpBack);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVideoPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVideoPlayer";
            this.Load += new System.EventHandler(this.FormVideoPlayer_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.MenuStrip menuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFicheiro;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSair;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAjuda;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMultimedia;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAudioPlayer;
        private System.Windows.Forms.ToolStripMenuItem abrirFicheiroToolStripMenuItem;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnJumpBack;
        private System.Windows.Forms.Button btnJumpForward;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBoxFile;
        private Vlc.DotNet.Forms.VlcControl vlcControl;
    }
}