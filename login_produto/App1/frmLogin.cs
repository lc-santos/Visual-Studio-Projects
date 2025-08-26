using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            
            string user = txtuser.Text;
            int pass = Convert.ToInt32(txtpass.Text);


            if (user == "admin" & pass == 1234)
            {
                this.Hide();
                MessageBox.Show("Logado com Sucesso");
                frmProduto abrir = new frmProduto();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
        }
    }
}
