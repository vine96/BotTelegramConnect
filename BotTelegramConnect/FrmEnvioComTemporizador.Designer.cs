namespace BotTelegramConnect
{
    partial class FrmEnvioComTemporizador
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMensagens = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prbStatusEnvio = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagens:";
            // 
            // lbMensagens
            // 
            this.lbMensagens.FormattingEnabled = true;
            this.lbMensagens.Location = new System.Drawing.Point(29, 37);
            this.lbMensagens.Name = "lbMensagens";
            this.lbMensagens.Size = new System.Drawing.Size(730, 212);
            this.lbMensagens.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(548, 265);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(211, 33);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(314, 265);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(211, 33);
            this.btnCarregar.TabIndex = 3;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status de envio:";
            // 
            // prbStatusEnvio
            // 
            this.prbStatusEnvio.Location = new System.Drawing.Point(29, 314);
            this.prbStatusEnvio.Name = "prbStatusEnvio";
            this.prbStatusEnvio.Size = new System.Drawing.Size(730, 23);
            this.prbStatusEnvio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(733, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aguardando envio...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEnvioComTemporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prbStatusEnvio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lbMensagens);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioComTemporizador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de mensagem com temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMensagens;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCarregar;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar prbStatusEnvio;
        private System.Windows.Forms.Label label3;
    }
}