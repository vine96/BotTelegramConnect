using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotTelegramConnect
{
    public partial class FrmEnvioComTemporizador : Form
    {
        private List<string> lstMensagens;

        public FrmEnvioComTemporizador()
        {
            InitializeComponent();
            lstMensagens = new List<string>();
            btnEnviar.Enabled = false;
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
    }
}
