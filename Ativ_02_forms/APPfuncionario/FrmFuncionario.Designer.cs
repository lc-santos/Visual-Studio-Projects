namespace APPfuncionario
{
    partial class FrmFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblfuncionario = new System.Windows.Forms.Label();
            this.txtfuncionario = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.buttonrmv = new System.Windows.Forms.Button();
            this.buttonclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(77, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(365, 264);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblfuncionario
            // 
            this.lblfuncionario.AutoSize = true;
            this.lblfuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuncionario.Location = new System.Drawing.Point(497, 87);
            this.lblfuncionario.Name = "lblfuncionario";
            this.lblfuncionario.Size = new System.Drawing.Size(92, 20);
            this.lblfuncionario.TabIndex = 1;
            this.lblfuncionario.Text = "Funcionário";
            // 
            // txtfuncionario
            // 
            this.txtfuncionario.Location = new System.Drawing.Point(501, 120);
            this.txtfuncionario.Name = "txtfuncionario";
            this.txtfuncionario.Size = new System.Drawing.Size(129, 20);
            this.txtfuncionario.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(77, 419);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(155, 43);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // buttonrmv
            // 
            this.buttonrmv.Location = new System.Drawing.Point(287, 419);
            this.buttonrmv.Name = "buttonrmv";
            this.buttonrmv.Size = new System.Drawing.Size(155, 43);
            this.buttonrmv.TabIndex = 3;
            this.buttonrmv.Text = "Remover";
            this.buttonrmv.UseVisualStyleBackColor = true;
            this.buttonrmv.Click += new System.EventHandler(this.buttonrmv_Click);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(501, 419);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(155, 43);
            this.buttonclear.TabIndex = 4;
            this.buttonclear.Text = "Limpar";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 558);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.buttonrmv);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtfuncionario);
            this.Controls.Add(this.lblfuncionario);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblfuncionario;
        private System.Windows.Forms.TextBox txtfuncionario;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button buttonrmv;
        private System.Windows.Forms.Button buttonclear;
    }
}