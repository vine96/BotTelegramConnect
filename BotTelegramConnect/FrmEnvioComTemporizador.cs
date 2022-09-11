using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;
using Telegram.Bot;

namespace BotTelegramConnect
{
    public partial class FrmEnvioComTemporizador : Form
    {
        private List<string> lstMensagens;
        private int posicaoEnvio;

        public FrmEnvioComTemporizador()
        {
            InitializeComponent();
            lstMensagens = new List<string>();
            btnEnviar.Enabled = false;
        }

        private void PrepararEnvio()
        {
            posicaoEnvio = 0;
            InicializarProgressBar();
            InicializarTimerControle();
        }

        private void InicializarProgressBar()
        {
            prbStatusEnvio.Value = 0;
            prbStatusEnvio.Maximum = lstMensagens.Count;
        }

        private void InicializarTimerControle()
        {
            var min = Convert.ToInt16(txtTempo.Text.Trim());
            timerControle.Interval = (60 * 1000) * min;
            timerControle.Enabled = true;

            this.timerControle.Tick += new EventHandler(TimerControle_TickAsync);
            this.BackColor = Color.Red;
        }

        private void PararTimerControle()
        {
            timerControle.Enabled = false;
            timerControle.Tick -= new EventHandler(TimerControle_TickAsync);
            this.BackColor = SystemColors.Control;
            btnEnviar.Enabled = true;
        }

        private void AtualizarProgressoEnvio()
        {
            prbStatusEnvio.Value++;
            lblStatusEnvio.Text = string.Format("Enviando {0} de {1}...", posicaoEnvio, lstMensagens.Count);
        }


        private async void TimerControle_TickAsync(object sender, EventArgs e)
        {
            try
            {
                var telegramBot = new TelegramBotClient("TOKEN");
                var mensagemAtual = lstMensagens[posicaoEnvio];

                mensagemAtual = EmojiConfig.Config(mensagemAtual);

                await telegramBot.SendTextMessageAsync(chatId: "CHAT ID", text: mensagemAtual, parseMode: ParseMode.Html);

                posicaoEnvio++;
                AtualizarProgressoEnvio();

                if(posicaoEnvio == lstMensagens.Count)
                {
                    PararTimerControle();
                }
            }
            catch (Exception ex)
            {
                PararTimerControle();
                MessageBox.Show("Ocorreu algum erro ao enviar as mensagens!" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                btnCarregar.Enabled = false;
                var arquivoMensagens = "Mensagens.txt";

                lstMensagens.Clear();
                lbMensagens.Items.Clear();

                using (StreamReader sr = new StreamReader(arquivoMensagens))
                {
                    var strLinha = string.Empty;
                    while ((strLinha = sr.ReadLine()) != null)
                    {
                        if (!strLinha.Trim().Equals(string.Empty))
                        {
                            lstMensagens.Add(strLinha.Trim());
                            lbMensagens.Items.Add(strLinha.Trim());
                        }
                    }
                }

                if(lstMensagens.Count > 0)
                {
                    btnEnviar.Enabled=true;
                }
            }
            catch (Exception ex)
            {
                btnCarregar.Enabled = true;
                btnEnviar.Enabled = false;
                lstMensagens.Clear();
                lbMensagens.Items.Clear();
                MessageBox.Show("Ocorreu algum erro ao carregar as mensagens! " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtTempo.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Você precisa informar um número para o tempo!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnEnviar.Enabled = false;

            //Verificar se encontrou uma linha no arquivo de texto
            if(lstMensagens.Count > 0)
            {
                PrepararEnvio();
            }
            else
            {
                btnEnviar.Enabled = true;
                MessageBox.Show("Não possui nenhuma mensagem escrita no documento!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
