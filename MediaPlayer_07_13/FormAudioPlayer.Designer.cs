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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.menuStripOptions = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFicheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMultimedia = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemVideoPlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFicheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tocaerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarAListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnSkipTen = new System.Windows.Forms.Button();
            this.btnBackTen = new System.Windows.Forms.Button();
            this.btnFilePlaceholder = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.menuStripOptions.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(954, 58);
            this.panel2.TabIndex = 3;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(885, 12);
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
            this.abrirFicheiroToolStripMenuItem});
            this.ToolStripMenuItemFicheiro.Name = "ToolStripMenuItemFicheiro";
            this.ToolStripMenuItemFicheiro.Size = new System.Drawing.Size(83, 26);
            this.ToolStripMenuItemFicheiro.Text = "Ficheiro";
            // 
            // ToolStripMenuItemSair
            // 
            this.ToolStripMenuItemSair.Name = "ToolStripMenuItemSair";
            this.ToolStripMenuItemSair.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemSair.Text = "Sair";
            this.ToolStripMenuItemSair.Click += new System.EventHandler(this.ToolStripMenuItemSair_Click);
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
            // abrirFicheiroToolStripMenuItem
            // 
            this.abrirFicheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tocaerToolStripMenuItem,
            this.adicionarAListaToolStripMenuItem});
            this.abrirFicheiroToolStripMenuItem.Name = "abrirFicheiroToolStripMenuItem";
            this.abrirFicheiroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirFicheiroToolStripMenuItem.Text = "Abrir Ficheiro";
            // 
            // tocaerToolStripMenuItem
            // 
            this.tocaerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tocaerToolStripMenuItem.Name = "tocaerToolStripMenuItem";
            this.tocaerToolStripMenuItem.Size = new System.Drawing.Size(280, 32);
            this.tocaerToolStripMenuItem.Text = "Tocar Imediatamente";
            // 
            // adicionarAListaToolStripMenuItem
            // 
            this.adicionarAListaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarAListaToolStripMenuItem.Name = "adicionarAListaToolStripMenuItem";
            this.adicionarAListaToolStripMenuItem.Size = new System.Drawing.Size(280, 32);
            this.adicionarAListaToolStripMenuItem.Text = "Adicionar a lista";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.Location = new System.Drawing.Point(422, 558);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(110, 110);
            this.btnPlayPause.TabIndex = 4;
            this.btnPlayPause.Text = "Play\r\nPause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnSkipTen
            // 
            this.btnSkipTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkipTen.Location = new System.Drawing.Point(538, 577);
            this.btnSkipTen.Name = "btnSkipTen";
            this.btnSkipTen.Size = new System.Drawing.Size(78, 78);
            this.btnSkipTen.TabIndex = 5;
            this.btnSkipTen.Text = "+ 10s";
            this.btnSkipTen.UseVisualStyleBackColor = true;
            // 
            // btnBackTen
            // 
            this.btnBackTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackTen.Location = new System.Drawing.Point(338, 577);
            this.btnBackTen.Name = "btnBackTen";
            this.btnBackTen.Size = new System.Drawing.Size(78, 78);
            this.btnBackTen.TabIndex = 6;
            this.btnBackTen.Text = "- 10s";
            this.btnBackTen.UseVisualStyleBackColor = true;
            // 
            // btnFilePlaceholder
            // 
            this.btnFilePlaceholder.Location = new System.Drawing.Point(33, 105);
            this.btnFilePlaceholder.Name = "btnFilePlaceholder";
            this.btnFilePlaceholder.Size = new System.Drawing.Size(126, 108);
            this.btnFilePlaceholder.TabIndex = 7;
            this.btnFilePlaceholder.Text = "choose file\r\nplaceholder";
            this.btnFilePlaceholder.UseVisualStyleBackColor = true;
            this.btnFilePlaceholder.Click += new System.EventHandler(this.btnFilePlaceholder_Click);
            // 
            // FormAudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(954, 684);
            this.Controls.Add(this.btnFilePlaceholder);
            this.Controls.Add(this.btnBackTen);
            this.Controls.Add(this.btnSkipTen);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAudioPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAudioPlayer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStripOptions.ResumeLayout(false);
            this.menuStripOptions.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemVideoPlayer;
        private System.Windows.Forms.ToolStripMenuItem abrirFicheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tocaerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarAListaToolStripMenuItem;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnSkipTen;
        private System.Windows.Forms.Button btnBackTen;
        private System.Windows.Forms.Button btnFilePlaceholder;
    }
}