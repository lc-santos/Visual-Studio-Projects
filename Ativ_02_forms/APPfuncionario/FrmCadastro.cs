using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPfuncionario
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void lblestate_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            FrmLogin abrir = new FrmLogin();
            abrir.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtcpf.Clear();
            txtrg.Clear();
            txtcep.Clear();
            txtlog.Clear();
            txtnumber.Clear();
            txtcity.Clear();
            txtcomp.Clear();
            txtbairro.Clear();
            cbbestado.ResetText();
            cbbuf.ResetText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
