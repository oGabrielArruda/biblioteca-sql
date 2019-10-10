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
            this.txtIdEmprestimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.IdEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDevReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage1.Controls.Add(this.btnExibir);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.btnProcurar);
            this.tabPage1.Controls.Add(this.mtxtDataDev);
            this.tabPage1.Controls.Add(this.mtxtDataEmp);
            this.tabPage1.Controls.Add(this.txtIdLeitor);
            this.tabPage1.Controls.Add(this.txtIdLivro);
            this.tabPage1.Controls.Add(this.txtIdEmprestimo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
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
            this.btnExibir.Location = new System.Drawing.Point(330, 324);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 17;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(237, 324);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(139, 324);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(42, 324);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(330, 88);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 13;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // mtxtDataDev
            // 
            this.mtxtDataDev.Location = new System.Drawing.Point(186, 262);
            this.mtxtDataDev.Mask = "00/00/0000";
            this.mtxtDataDev.Name = "mtxtDataDev";
            this.mtxtDataDev.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataDev.TabIndex = 12;
            this.mtxtDataDev.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtDataEmp
            // 
            this.mtxtDataEmp.Location = new System.Drawing.Point(186, 216);
            this.mtxtDataEmp.Mask = "00/00/0000";
            this.mtxtDataEmp.Name = "mtxtDataEmp";
            this.mtxtDataEmp.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataEmp.TabIndex = 11;
            this.mtxtDataEmp.ValidatingType = typeof(System.DateTime);
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(186, 175);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(100, 20);
            this.txtIdLeitor.TabIndex = 8;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Location = new System.Drawing.Point(186, 128);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(100, 20);
            this.txtIdLivro.TabIndex = 7;
            // 
            // txtIdEmprestimo
            // 
            this.txtIdEmprestimo.Location = new System.Drawing.Point(186, 90);
            this.txtIdEmprestimo.Name = "txtIdEmprestimo";
            this.txtIdEmprestimo.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmprestimo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data de Devolução";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de Empréstimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id Leitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Empréstimo";
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
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(599, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devoluções";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 30);
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
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmprestimo,
            this.idLivro,
            this.idLeitor,
            this.dataEmp,
            this.dataDev,
            this.dataDevReal});
            this.dgvDados.Location = new System.Drawing.Point(16, 15);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(577, 379);
            this.dgvDados.TabIndex = 0;
            // 
            // IdEmprestimo
            // 
            this.IdEmprestimo.HeaderText = "idEmprestimo";
            this.IdEmprestimo.Name = "IdEmprestimo";
            this.IdEmprestimo.Width = 50;
            // 
            // idLivro
            // 
            this.idLivro.HeaderText = "idLivro";
            this.idLivro.Name = "idLivro";
            this.idLivro.Width = 50;
            // 
            // idLeitor
            // 
            this.idLeitor.HeaderText = "idLeitor";
            this.idLeitor.Name = "idLeitor";
            // 
            // dataEmp
            // 
            this.dataEmp.HeaderText = "dataEmp";
            this.dataEmp.Name = "dataEmp";
            // 
            // dataDev
            // 
            this.dataDev.HeaderText = "Devolução Prevista para:";
            this.dataDev.Name = "dataDev";
            // 
            // dataDevReal
            // 
            this.dataDevReal.HeaderText = "Data da devolução";
            this.dataDevReal.Name = "dataDevReal";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.TextBox txtIdEmprestimo;
        private System.Windows.Forms.MaskedTextBox mtxtDataDev;
        private System.Windows.Forms.MaskedTextBox mtxtDataEmp;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDevReal;
    }
}