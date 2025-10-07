using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MosaicoSolutions.ViaCep;
using Newtonsoft.Json.Bson;


namespace APPfuncionario
{
    public partial class FrmCadastro : Form
    {
        bool camposhabilitados = true;
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
            mskcpf.Clear();
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


        private void DesabilitarCampos()
        {
            txtname.Enabled = false;
            txtcep.Enabled = false;
            txtcomp.Enabled = false;
            txtbairro.Enabled = false;
            txtcity.Enabled = false;
            txtlog.Enabled = false;
            txtnumber.Enabled = false;
            cbbestado.Enabled = false;
            cbbuf.Enabled = false;
            mskcpf.Enabled = false;
            txtrg.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtname.Enabled = true;
            txtcep.Enabled = true;
            txtcomp.Enabled = true;
            txtbairro.Enabled = true;
            txtcity.Enabled = true;
            txtlog.Enabled = true;
            txtnumber.Enabled = true;
            cbbestado.Enabled = true;
            cbbuf.Enabled = true;
            mskcpf.Enabled = true;
            txtrg.Enabled = true;
        }


        private void btnnew_Click(object sender, EventArgs e)
        {
            if (camposhabilitados)
            {
                DesabilitarCampos();
                camposhabilitados = false;
            }
            else
            {
                HabilitarCampos();
                camposhabilitados = true;
            }
        }



        private void buscarCEP(string cep)
        {
            var viaCEPService = ViaCepService.Default();
            var endereco = viaCEPService.ObterEndereco(cep);

            txtlog.Text = endereco.Logradouro;
            txtcity.Text = endereco.Localidade;
            cbbestado.Text = endereco.UF;
            cbbuf.Text = endereco.UF;
            txtcomp.Text = endereco.Complemento;
            txtbairro.Text = endereco.Bairro;

        }



        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtcep_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buscarCEP(txtcep.Text);
                txtnumber.Focus();
            }
        }
    }
}
