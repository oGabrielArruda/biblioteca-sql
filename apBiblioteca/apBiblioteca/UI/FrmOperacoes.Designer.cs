namespace apBiblioteca.UI
{
    partial class FrmOperacoes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.mtxtDataDev = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataEmp = new System.Windows.Forms.MaskedTextBox();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnProcurarDev = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataDevPrev = new System.Windows.Forms.TextBox();
            this.txtDataEmpDev = new System.Windows.Forms.TextBox();
            this.txtIdLeitorDev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdLivroDev = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkDev = new System.Windows.Forms.CheckBox();
            this.chkDevolvido = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkDev);
            this.tabPage1.Controls.Add(this.txtIdEmp);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btnExibir);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.btnProcurar);
            this.tabPage1.Controls.Add(this.mtxtDataDev);
            this.tabPage1.Controls.Add(this.mtxtDataEmp);
            this.tabPage1.Controls.Add(this.txtIdLeitor);
            this.tabPage1.Controls.Add(this.txtIdLivro);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(599, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Empréstimos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(354, 354);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 17;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(249, 354);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(146, 354);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(40, 354);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(330, 90);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 13;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // mtxtDataDev
            // 
            this.mtxtDataDev.Location = new System.Drawing.Point(189, 255);
            this.mtxtDataDev.Mask = "00/00/0000";
            this.mtxtDataDev.Name = "mtxtDataDev";
            this.mtxtDataDev.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataDev.TabIndex = 12;
            this.mtxtDataDev.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtDataEmp
            // 
            this.mtxtDataEmp.Location = new System.Drawing.Point(189, 214);
            this.mtxtDataEmp.Mask = "00/00/0000";
            this.mtxtDataEmp.Name = "mtxtDataEmp";
            this.mtxtDataEmp.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataEmp.TabIndex = 11;
            this.mtxtDataEmp.ValidatingType = typeof(System.DateTime);
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(189, 172);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(100, 20);
            this.txtIdLeitor.TabIndex = 8;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(189, 131);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(100, 20);
            this.txtIdLivro.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Devolução";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Empréstimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Leitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Livro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Empréstimo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkDevolvido);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnProcurarDev);
            this.tabPage2.Controls.Add(this.btnDevolver);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtDataDevPrev);
            this.tabPage2.Controls.Add(this.txtDataEmpDev);
            this.tabPage2.Controls.Add(this.txtIdLeitorDev);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtIdLivroDev);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(599, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devoluções";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(222, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Id Emprestimo";
            // 
            // btnProcurarDev
            // 
            this.btnProcurarDev.Location = new System.Drawing.Point(354, 105);
            this.btnProcurarDev.Name = "btnProcurarDev";
            this.btnProcurarDev.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarDev.TabIndex = 10;
            this.btnProcurarDev.Text = "Procurar";
            this.btnProcurarDev.UseVisualStyleBackColor = true;
            this.btnProcurarDev.Click += new System.EventHandler(this.btnProcurarDev_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(232, 371);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 9;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Data Devolução Prevista";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Data Empréstimo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Id Leitor";
            // 
            // txtDataDevPrev
            // 
            this.txtDataDevPrev.Location = new System.Drawing.Point(222, 283);
            this.txtDataDevPrev.Name = "txtDataDevPrev";
            this.txtDataDevPrev.ReadOnly = true;
            this.txtDataDevPrev.Size = new System.Drawing.Size(100, 20);
            this.txtDataDevPrev.TabIndex = 5;
            // 
            // txtDataEmpDev
            // 
            this.txtDataEmpDev.Location = new System.Drawing.Point(222, 240);
            this.txtDataEmpDev.Name = "txtDataEmpDev";
            this.txtDataEmpDev.ReadOnly = true;
            this.txtDataEmpDev.Size = new System.Drawing.Size(100, 20);
            this.txtDataEmpDev.TabIndex = 4;
            // 
            // txtIdLeitorDev
            // 
            this.txtIdLeitorDev.Location = new System.Drawing.Point(222, 196);
            this.txtIdLeitorDev.Name = "txtIdLeitorDev";
            this.txtIdLeitorDev.ReadOnly = true;
            this.txtIdLeitorDev.Size = new System.Drawing.Size(100, 20);
            this.txtIdLeitorDev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Livro";
            // 
            // txtIdLivroDev
            // 
            this.txtIdLivroDev.Location = new System.Drawing.Point(222, 157);
            this.txtIdLivroDev.Name = "txtIdLivroDev";
            this.txtIdLivroDev.ReadOnly = true;
            this.txtIdLivroDev.Size = new System.Drawing.Size(100, 20);
            this.txtIdLivroDev.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Registrar Devoluções";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvDados);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(599, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lista";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(16, 15);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(577, 379);
            this.dgvDados.TabIndex = 0;
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.Location = new System.Drawing.Point(189, 93);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmp.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Id Emprestimo";
            // 
            // chkDev
            // 
            this.chkDev.AutoSize = true;
            this.chkDev.Enabled = false;
            this.chkDev.Location = new System.Drawing.Point(189, 303);
            this.chkDev.Name = "chkDev";
            this.chkDev.Size = new System.Drawing.Size(74, 17);
            this.chkDev.TabIndex = 21;
            this.chkDev.Text = "Devolvido";
            this.chkDev.UseVisualStyleBackColor = true;
            // 
            // chkDevolvido
            // 
            this.chkDevolvido.AutoSize = true;
            this.chkDevolvido.Enabled = false;
            this.chkDevolvido.Location = new System.Drawing.Point(222, 320);
            this.chkDevolvido.Name = "chkDevolvido";
            this.chkDevolvido.Size = new System.Drawing.Size(74, 17);
            this.chkDevolvido.TabIndex = 22;
            this.chkDevolvido.Text = "Devolvido";
            this.chkDevolvido.UseVisualStyleBackColor = true;
            // 
            // FrmOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmOperacoes";
            this.Text = "FrmOperacoes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.MaskedTextBox mtxtDataDev;
        private System.Windows.Forms.MaskedTextBox mtxtDataEmp;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtIdLivroDev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcurarDev;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDataDevPrev;
        private System.Windows.Forms.TextBox txtDataEmpDev;
        private System.Windows.Forms.TextBox txtIdLeitorDev;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkDev;
        private System.Windows.Forms.CheckBox chkDevolvido;
    }
}