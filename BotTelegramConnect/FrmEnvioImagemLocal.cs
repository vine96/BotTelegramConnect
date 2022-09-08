using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotTelegramConnect
{
    public partial class FrmEnvioImagemLocal : Form
    {
        public FrmEnvioImagemLocal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
    }
}
