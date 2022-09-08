using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace BotTelegramConnect
{
    public partial class FrmEnvioTexto : Form
    {
        public FrmEnvioTexto()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text.Trim().Equals(string.Empty)){
                MessageBox.Show("Informe uma mensagem para envio!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var telegramBot = new TelegramBotClient("TOKEN AQUI");
                await telegramBot.SendTextMessageAsync(chatId: "CHAT ID AQUI", text: txtMensagem.Text.Trim(), parseMode: ParseMode.Html);
                MessageBox.Show("A mensagem foi enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao enviar a mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Text = String.Empty;
            }
        }
    }
}
