using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;
using Telegram.Bot;
using System.Net;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemWeb : Form
    {
        public FrmEnvioImagemWeb()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtUrlImage.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Informe uma url da imagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var telegramBot = new TelegramBotClient("TOKEN AQUI");
                var imagemRequest = WebRequest.Create(txtUrlImage.Text.Trim());

                using (var imagemResponse = imagemRequest.GetResponse())
                {
                    var stream = imagemResponse.GetResponseStream();
                    await telegramBot.SendPhotoAsync(chatId: "CHAT ID AQUI", photo: stream, caption: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
                }

                MessageBox.Show("A imagem foi enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao enviar a imagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Text = String.Empty;
                txtUrlImage.Text = String.Empty;
            }
        }
    }
}
