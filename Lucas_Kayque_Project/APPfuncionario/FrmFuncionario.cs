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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(string.Format("{0}", txtfuncionario.Text));
            MessageBox.Show("Item adicionado com sucesso");

        }

        private void buttonrmv_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            MessageBox.Show("Item"); 
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            txtfuncionario.Clear();
        }
    }
}
