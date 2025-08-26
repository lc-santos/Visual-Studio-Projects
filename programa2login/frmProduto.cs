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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtvalue.Clear();
            cbbfact.ResetText();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnexit_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            cbbfact.Items.Add(string.Format("{0}" , txtname.Text));
            MessageBox.Show("Item adicionado!");
        }

        private ComboBox GetCbbfact()
        {
            return cbbfact;
        }

        private void btnrm_Click(object sender, EventArgs e)
        {
            cbbfact.Items.Remove(cbbfact.SelectedItem);
            MessageBox.Show("Item removido!");

        }

        private void cbbfact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
