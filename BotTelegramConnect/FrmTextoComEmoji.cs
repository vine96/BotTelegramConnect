﻿using System;
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
    public partial class FrmTextoComEmoji : Form
    {
        public FrmTextoComEmoji()
        {
            InitializeComponent();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensagem.Text.Trim().Equals(string.Empty)){
                MessageBox.Show("Atenção!\n\nVocê precisa digitar uma mensagem.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                var telegramBot = new TelegramBotClient("TOKEN");
                var strMensagem = txtMensagem.Text.Trim();

                if (strMensagem.Contains(":white_check_mark:"))
                {
                    strMensagem = strMensagem.Replace(":white_check_mark:", char.ConvertFromUtf32(0x2705));
                }
                if (strMensagem.Contains(":grin:"))
                {
                    strMensagem = strMensagem.Replace(":grin:", char.ConvertFromUtf32(0x1F601));
                }
                if (strMensagem.Contains(":cupid:"))
                {
                    strMensagem = strMensagem.Replace(":cupid:", char.ConvertFromUtf32(0x1F498));
                }

                await telegramBot.SendTextMessageAsync(chatId: "CHAT ID", text: strMensagem, parseMode: ParseMode.Html);
                MessageBox.Show("Sua mensagem foi enviada com sucesso!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu algum erro ao enviar a mensagem! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtMensagem.Clear();
            }
        }
    }
}
