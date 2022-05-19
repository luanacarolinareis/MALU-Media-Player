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
            this.btnClose = new System.Windows.Forms.Button();
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.menuStripOptions.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.menuStripOptions);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1330, 58);
            this.panel2.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(1268, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 58);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
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
            this.menuStripOptions.Size = new System.Drawing.Size(271, 30);
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
            this.ToolStripMenuItemAudioPlayer.Size = new System.Drawing.Size(224, 26);
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
            this.btnPlayPause.Location = new System.Drawing.Point(710, 35);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(106, 53);
            this.btnPlayPause.TabIndex = 4;
            this.btnPlayPause.Text = "Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnJumpBack
            // 
            this.btnJumpBack.Location = new System.Drawing.Point(579, 35);
            this.btnJumpBack.Name = "btnJumpBack";
            this.btnJumpBack.Size = new System.Drawing.Size(106, 53);
            this.btnJumpBack.TabIndex = 5;
            this.btnJumpBack.Text = "-10 s";
            this.btnJumpBack.UseVisualStyleBackColor = true;
            this.btnJumpBack.Click += new System.EventHandler(this.btnJumpBack_Click);
            // 
            // btnJumpForward
            // 
            this.btnJumpForward.Location = new System.Drawing.Point(837, 35);
            this.btnJumpForward.Name = "btnJumpForward";
            this.btnJumpForward.Size = new System.Drawing.Size(106, 53);
            this.btnJumpForward.TabIndex = 6;
            this.btnJumpForward.Text = "+10 s";
            this.btnJumpForward.UseVisualStyleBackColor = true;
            this.btnJumpForward.Click += new System.EventHandler(this.btnJumpForward_Click);
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
            this.panel3.Controls.Add(this.labelVolume);
            this.panel3.Controls.Add(this.labelTotalTime);
            this.panel3.Controls.Add(this.labelCurrentTime);
            this.panel3.Controls.Add(this.progressBarTime);
            this.panel3.Controls.Add(this.btnPlayPause);
            this.panel3.Controls.Add(this.btnJumpForward);
            this.panel3.Controls.Add(this.btnJumpBack);
            this.panel3.Controls.Add(this.volumeTrackBar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 598);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1330, 100);
            this.panel3.TabIndex = 13;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Location = new System.Drawing.Point(1024, 35);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(104, 56);
            this.volumeTrackBar.TabIndex = 9;
            this.volumeTrackBar.Value = 50;
            this.volumeTrackBar.Scroll += new System.EventHandler(this.volumeTrackBar_Scroll);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1MinSize = 120;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.splitContainer1.Panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer1.Panel2MinSize = 470;
            this.splitContainer1.Size = new System.Drawing.Size(1330, 540);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(280, 540);
            this.listBox1.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1046, 540);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // progressBarTime
            // 
            this.progressBarTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarTime.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.progressBarTime.Location = new System.Drawing.Point(0, 0);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(1330, 23);
            this.progressBarTime.TabIndex = 14;
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelCurrentTime.Location = new System.Drawing.Point(12, 35);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(73, 20);
            this.labelCurrentTime.TabIndex = 15;
            this.labelCurrentTime.Text = "00:00:00";
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalTime.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelTotalTime.Location = new System.Drawing.Point(1245, 35);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(73, 20);
            this.labelTotalTime.TabIndex = 16;
            this.labelTotalTime.Text = "00:00:00";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelVolume.Location = new System.Drawing.Point(1059, 71);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(42, 20);
            this.labelVolume.TabIndex = 17;
            this.labelVolume.Text = "50%";
            // 
            // FormVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1330, 698);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVideoPlayer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stop";
            this.TopMost = true;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnJumpBack;
        private System.Windows.Forms.Button btnJumpForward;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ProgressBar progressBarTime;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelTotalTime;
        private System.Windows.Forms.Label labelCurrentTime;
    }
}