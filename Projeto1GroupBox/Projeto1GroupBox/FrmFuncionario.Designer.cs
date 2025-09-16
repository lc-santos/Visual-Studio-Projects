namespace Projeto1GroupBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprof = new System.Windows.Forms.TextBox();
            this.lblprof = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.lblsalario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsalario);
            this.groupBox1.Controls.Add(this.lblsalario);
            this.groupBox1.Controls.Add(this.txtprof);
            this.groupBox1.Controls.Add(this.lblprof);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(151, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS DO FUNCIONÁRIO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(60, 68);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(53, 18);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Nome";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(132, 65);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 24);
            this.txtname.TabIndex = 1;
            // 
            // txtprof
            // 
            this.txtprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprof.Location = new System.Drawing.Point(132, 95);
            this.txtprof.Name = "txtprof";
            this.txtprof.Size = new System.Drawing.Size(100, 24);
            this.txtprof.TabIndex = 3;
            this.txtprof.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblprof
            // 
            this.lblprof.AutoSize = true;
            this.lblprof.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprof.Location = new System.Drawing.Point(45, 98);
            this.lblprof.Name = "lblprof";
            this.lblprof.Size = new System.Drawing.Size(81, 18);
            this.lblprof.TabIndex = 2;
            this.lblprof.Text = "Profissão";
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(132, 125);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 24);
            this.txtsalario.TabIndex = 5;
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalario.Location = new System.Drawing.Point(55, 128);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(61, 18);
            this.lblsalario.TabIndex = 4;
            this.lblsalario.Text = "Salário";
            this.lblsalario.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(452, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnsave
            // 
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(151, 351);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(130, 49);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Salvar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.Image")));
            this.btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclear.Location = new System.Drawing.Point(338, 351);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(130, 49);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Limpar";
            this.btnclear.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(523, 351);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(130, 49);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Sair";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFuncionario";
            this.Text = "FrmFuncionario";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.TextBox txtprof;
        private System.Windows.Forms.Label lblprof;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}