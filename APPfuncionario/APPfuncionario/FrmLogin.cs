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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string usuario;
            int senha;

            usuario= txtusuario.Text;
            senha= Convert.ToInt32(txtsenha.Text);

            if(usuario == "admin" &  senha == 1234) { 
                FrmFuncionario abrir = new FrmFuncionario();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Usuario ou senha incorretos");
            }
        }
    }
}
