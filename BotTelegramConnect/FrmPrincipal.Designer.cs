namespace BotTelegramConnect
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemDaWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemComEmojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemComTemporizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem,
            this.envioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // envioToolStripMenuItem
            // 
            this.envioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envioDeMensagemSimplesToolStripMenuItem,
            this.eToolStripMenuItem,
            this.envioDeMensagemComEmojiToolStripMenuItem,
            this.envioDeMensagemComTemporizadorToolStripMenuItem});
            this.envioToolStripMenuItem.Name = "envioToolStripMenuItem";
            this.envioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.envioToolStripMenuItem.Text = "Envio";
            // 
            // envioDeMensagemSimplesToolStripMenuItem
            // 
            this.envioDeMensagemSimplesToolStripMenuItem.Name = "envioDeMensagemSimplesToolStripMenuItem";
            this.envioDeMensagemSimplesToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.envioDeMensagemSimplesToolStripMenuItem.Text = "Envio de mensagem simples";
            this.envioDeMensagemSimplesToolStripMenuItem.Click += new System.EventHandler(this.envioDeMensagemSimplesToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemDaWebToolStripMenuItem,
            this.imagemLocalToolStripMenuItem});
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.eToolStripMenuItem.Text = "Envio de mensagem com imagem";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // imagemDaWebToolStripMenuItem
            // 
            this.imagemDaWebToolStripMenuItem.Name = "imagemDaWebToolStripMenuItem";
            this.imagemDaWebToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagemDaWebToolStripMenuItem.Text = "Imagem da web";
            this.imagemDaWebToolStripMenuItem.Click += new System.EventHandler(this.imagemDaWebToolStripMenuItem_Click);
            // 
            // imagemLocalToolStripMenuItem
            // 
            this.imagemLocalToolStripMenuItem.Name = "imagemLocalToolStripMenuItem";
            this.imagemLocalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagemLocalToolStripMenuItem.Text = "Imagem local";
            this.imagemLocalToolStripMenuItem.Click += new System.EventHandler(this.imagemLocalToolStripMenuItem_Click);
            // 
            // envioDeMensagemComEmojiToolStripMenuItem
            // 
            this.envioDeMensagemComEmojiToolStripMenuItem.Name = "envioDeMensagemComEmojiToolStripMenuItem";
            this.envioDeMensagemComEmojiToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.envioDeMensagemComEmojiToolStripMenuItem.Text = "Envio de mensagem com emoji";
            // 
            // envioDeMensagemComTemporizadorToolStripMenuItem
            // 
            this.envioDeMensagemComTemporizadorToolStripMenuItem.Name = "envioDeMensagemComTemporizadorToolStripMenuItem";
            this.envioDeMensagemComTemporizadorToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.envioDeMensagemComTemporizadorToolStripMenuItem.Text = "Envio de mensagem com temporizador";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Formulário principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemDaWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemComEmojiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemComTemporizadorToolStripMenuItem;
    }
}

