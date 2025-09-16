using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1GroupBox
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pgbsplash_Click(object sender, EventArgs e)
        {

        }

        private void tmtsplash_Tick(object sender, EventArgs e)
        {
            if (pgbsplash.Value < 100)
            {
                pgbsplash.Value = pgbsplash.Value + 1;
                lblpgb.Text = pgbsplash.Value.ToString() + " % ";
            }
            else
            {
                tmtsplash.Enabled = false;
                FrmLogin abrir = new FrmLogin();
                abrir.Show();
                this.Hide();
            }
        }
    }
}
