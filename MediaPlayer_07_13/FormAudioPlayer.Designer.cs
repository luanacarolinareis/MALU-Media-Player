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
            this.panelBaixo = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelTopo.SuspendLayout();
            this.menuStripOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.panelBaixo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.menuStripOptions.Size = new System.Drawing.Size(269, 30);
            this.menuStripOptions.TabIndex = 0;
            this.menuStripOptions.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFicheiro
            // 
            this.ToolStripMenuItemFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSair,
            this.ToolStripMenuItemabrirFicheiro});
            this.ToolStripMenuItemFicheiro.Name = "ToolStripMenuItemFicheiro";
            this.ToolStripMenuItemFicheiro.Size = new System.Drawing.Size(83, 26);
            this.ToolStripMenuItemFicheiro.Text = "Ficheiro";
            // 
            // ToolStripMenuItemSair
            // 
            this.ToolStripMenuItemSair.Name = "ToolStripMenuItemSair";
            this.ToolStripMenuItemSair.Size = new System.Drawing.Size(195, 26);
            this.ToolStripMenuItemSair.Text = "Sair";
            this.ToolStripMenuItemSair.Click += new System.EventHandler(this.ToolStripMenuItemSair_Click);
            // 
            // ToolStripMenuItemabrirFicheiro
            // 
            this.ToolStripMenuItemabrirFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTocar,
            this.ToolStripMenuItemAdicionar});
            this.ToolStripMenuItemabrirFicheiro.Name = "ToolStripMenuItemabrirFicheiro";
            this.ToolStripMenuItemabrirFicheiro.Size = new System.Drawing.Size(195, 26);
            this.ToolStripMenuItemabrirFicheiro.Text = "Abrir Ficheiro";
            // 
            // ToolStripMenuItemTocar
            // 
            this.ToolStripMenuItemTocar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemTocar.Name = "ToolStripMenuItemTocar";
            this.ToolStripMenuItemTocar.Size = new System.Drawing.Size(280, 32);
            this.ToolStripMenuItemTocar.Text = "Tocar Imediatamente";
            this.ToolStripMenuItemTocar.Click += new System.EventHandler(this.ToolStripMenuItemTocar_Click);
            // 
            // ToolStripMenuItemAdicionar
            // 
            this.ToolStripMenuItemAdicionar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemAdicionar.Name = "ToolStripMenuItemAdicionar";
            this.ToolStripMenuItemAdicionar.Size = new System.Drawing.Size(280, 32);
            this.ToolStripMenuItemAdicionar.Text = "Adicionar a lista";
            // 
            // ToolStripMenuItemMultimedia
            // 
            this.ToolStripMenuItemMultimedia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemVideoPlayer});
            this.ToolStripMenuItemMultimedia.Name = "ToolStripMenuItemMultimedia";
            this.ToolStripMenuItemMultimedia.Size = new System.Drawing.Size(110, 26);
            this.ToolStripMenuItemMultimedia.Text = "Multimédia";
            // 
            // ToolStripMenuItemVideoPlayer
            // 
            this.ToolStripMenuItemVideoPlayer.Name = "ToolStripMenuItemVideoPlayer";
            this.ToolStripMenuItemVideoPlayer.Size = new System.Drawing.Size(189, 26);
            this.ToolStripMenuItemVideoPlayer.Text = "Video Player";
            this.ToolStripMenuItemVideoPlayer.Click += new System.EventHandler(this.ToolStripMenuItemVideoPlayer_Click);
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
            this.btnPlayPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.Location = new System.Drawing.Point(279, 17);
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
            this.btnSkipTen.Location = new System.Drawing.Point(335, 27);
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
            this.btnBackTen.Location = new System.Drawing.Point(233, 27);
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
            this.trackBarVolume.Location = new System.Drawing.Point(505, 23);
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
            this.progressBarTime.Location = new System.Drawing.Point(49, 73);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(505, 18);
            this.progressBarTime.TabIndex = 9;
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelVolume.Location = new System.Drawing.Point(538, 4);
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
            this.labelTotalTime.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelTotalTime.Location = new System.Drawing.Point(556, 73);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(45, 20);
            this.labelTotalTime.TabIndex = 12;
            this.labelTotalTime.Text = "0:00";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelCurrentTime.Location = new System.Drawing.Point(3, 71);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(45, 20);
            this.labelCurrentTime.TabIndex = 13;
            this.labelCurrentTime.Text = "0:00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 52);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(116, 489);
            this.panelLateral.TabIndex = 14;
            // 
            // panelBaixo
            // 
            this.panelBaixo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelBaixo.Controls.Add(this.progressBarTime);
            this.panelBaixo.Controls.Add(this.btnBackTen);
            this.panelBaixo.Controls.Add(this.labelVolume);
            this.panelBaixo.Controls.Add(this.labelTotalTime);
            this.panelBaixo.Controls.Add(this.labelCurrentTime);
            this.panelBaixo.Controls.Add(this.trackBarVolume);
            this.panelBaixo.Controls.Add(this.btnSkipTen);
            this.panelBaixo.Controls.Add(this.btnPlayPause);
            this.panelBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBaixo.Location = new System.Drawing.Point(116, 441);
            this.panelBaixo.Name = "panelBaixo";
            this.panelBaixo.Size = new System.Drawing.Size(608, 100);
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
            this.Name = "FormAudioPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAudioPlayer";
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
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
    }
}