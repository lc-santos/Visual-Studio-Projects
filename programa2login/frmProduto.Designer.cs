namespace App1
{
    partial class frmProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbbfact = new System.Windows.Forms.ComboBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblvalue = new System.Windows.Forms.Label();
            this.lblfact = new System.Windows.Forms.Label();
            this.lblprod = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnrm = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtvalue);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.cbbfact);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.lblvalue);
            this.panel1.Controls.Add(this.lblfact);
            this.panel1.Location = new System.Drawing.Point(265, 222);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 356);
            this.panel1.TabIndex = 0;
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(232, 144);
            this.txtvalue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(192, 22);
            this.txtvalue.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(232, 78);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(192, 22);
            this.txtname.TabIndex = 1;
            // 
            // cbbfact
            // 
            this.cbbfact.FormattingEnabled = true;
            this.cbbfact.Items.AddRange(new object[] {
            "Tabajara",
            "Kagohara",
            "Madruga",
            "Los Hermanos",
            "Volin Rabarh"});
            this.cbbfact.Location = new System.Drawing.Point(232, 217);
            this.cbbfact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbfact.Name = "cbbfact";
            this.cbbfact.Size = new System.Drawing.Size(192, 24);
            this.cbbfact.TabIndex = 3;
            this.cbbfact.SelectedIndexChanged += new System.EventHandler(this.cbbfact_SelectedIndexChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(27, 78);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(197, 29);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Add. Fabricante";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalue.Location = new System.Drawing.Point(52, 144);
            this.lblvalue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(74, 29);
            this.lblvalue.TabIndex = 3;
            this.lblvalue.Text = "Valor";
            this.lblvalue.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblfact
            // 
            this.lblfact.AutoSize = true;
            this.lblfact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfact.Location = new System.Drawing.Point(52, 217);
            this.lblfact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfact.Name = "lblfact";
            this.lblfact.Size = new System.Drawing.Size(137, 29);
            this.lblfact.TabIndex = 4;
            this.lblfact.Text = "Fabricante";
            this.lblfact.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprod.Location = new System.Drawing.Point(263, 169);
            this.lblprod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(237, 29);
            this.lblprod.TabIndex = 1;
            this.lblprod.Text = "Dados do Produtos";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(227, 641);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(196, 68);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(839, 641);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(196, 68);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Sair";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            this.btnexit.MouseHover += new System.EventHandler(this.btnexit_MouseHover);
            // 
            // btnrm
            // 
            this.btnrm.Location = new System.Drawing.Point(635, 641);
            this.btnrm.Margin = new System.Windows.Forms.Padding(4);
            this.btnrm.Name = "btnrm";
            this.btnrm.Size = new System.Drawing.Size(196, 68);
            this.btnrm.TabIndex = 6;
            this.btnrm.Text = "Remover";
            this.btnrm.UseVisualStyleBackColor = true;
            this.btnrm.Click += new System.EventHandler(this.btnrm_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(431, 641);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(196, 68);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Adicionar";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1312, 937);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnrm);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.lblprod);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblvalue;
        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.ComboBox cbbfact;
        private System.Windows.Forms.Label lblfact;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnrm;
        private System.Windows.Forms.Button btnadd;
    }
}