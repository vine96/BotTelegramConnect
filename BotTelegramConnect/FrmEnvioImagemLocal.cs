using System;
using System.Drawing;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using System.IO;
using System.Drawing.Imaging;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemLocal : Form
    {
        public FrmEnvioImagemLocal() => InitializeComponent();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private Stream ToStream(Image imagem, ImageFormat formato)
        {
            var stream = new MemoryStream();
            imagem.Save(stream, formato);
            stream.Position = 0;
            return stream;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\Users\vinic\OneDrive\";
                ofd.Filter = "Imagens (*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCaminho.Text = ofd.FileName;
                }
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if(txtCaminho.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Atenção!\n\nVocê deve selecionar uma imagem.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new TelegramBotClient("TOKEN AQUI");

                using (var imgEnvio = Image.FromFile(txtCaminho.Text.Trim()))
                {
                    var stream = ToStream(imgEnvio, ImageFormat.Png);
                    await telegramBot.SendPhotoAsync(chatId: "CHAT ID", photo: stream, caption: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
                }

                MessageBox.Show("A imagem foi enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu algum erro ao enviar a mensagem. " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtCaminho.Clear();
                txtMensagem.Clear();
            }
        }
    }
}
