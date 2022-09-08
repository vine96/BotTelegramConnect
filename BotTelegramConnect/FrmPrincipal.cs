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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls){
                if (control is MdiClient){
                    control.BackgroundImage = Properties.Resources.background_image;
                    break;
                }
            }
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
