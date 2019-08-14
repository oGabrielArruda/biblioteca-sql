namespace apBiblioteca.UI
{
    partial class FrmLeitor
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
            this.btnAlterarLeitor = new System.Windows.Forms.Button();
            this.btnNovoLeitor = new System.Windows.Forms.Button();
            this.btnProcurarLeitor = new System.Windows.Forms.Button();
            this.txtEnderecoLeitor = new System.Windows.Forms.TextBox();
            this.txtEmailLeitor = new System.Windows.Forms.TextBox();
            this.txtTelLeitor = new System.Windows.Forms.TextBox();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtIdLeitor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvLeitor = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnExibir);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnAlterarLeitor);
            this.tabPage1.Controls.Add(this.btnNovoLeitor);
            this.tabPage1.Controls.Add(this.btnProcurarLeitor);
            this.tabPage1.Controls.Add(this.txtEnderecoLeitor);
            this.tabPage1.Controls.Add(this.txtEmailLeitor);
            this.tabPage1.Controls.Add(this.txtTelLeitor);
            this.tabPage1.Controls.Add(this.txtNomeLeitor);
            this.tabPage1.Controls.Add(this.txtIdLeitor);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(317, 309);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 15;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(221, 309);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterarLeitor
            // 
            this.btnAlterarLeitor.Location = new System.Drawing.Point(126, 309);
            this.btnAlterarLeitor.Name = "btnAlterarLeitor";
            this.btnAlterarLeitor.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarLeitor.TabIndex = 13;
            this.btnAlterarLeitor.Text = "Alterar";
            this.btnAlterarLeitor.UseVisualStyleBackColor = true;
            this.btnAlterarLeitor.Click += new System.EventHandler(this.btnAlterarLeitor_Click);
            // 
            // btnNovoLeitor
            // 
            this.btnNovoLeitor.Location = new System.Drawing.Point(26, 309);
            this.btnNovoLeitor.Name = "btnNovoLeitor";
            this.btnNovoLeitor.Size = new System.Drawing.Size(75, 23);
            this.btnNovoLeitor.TabIndex = 12;
            this.btnNovoLeitor.Text = "Novo";
            this.btnNovoLeitor.UseVisualStyleBackColor = true;
            this.btnNovoLeitor.Click += new System.EventHandler(this.btnNovoLeitor_Click);
            // 
            // btnProcurarLeitor
            // 
            this.btnProcurarLeitor.Location = new System.Drawing.Point(317, 26);
            this.btnProcurarLeitor.Name = "btnProcurarLeitor";
            this.btnProcurarLeitor.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarLeitor.TabIndex = 11;
            this.btnProcurarLeitor.Text = "Procurar";
            this.btnProcurarLeitor.UseVisualStyleBackColor = true;
            this.btnProcurarLeitor.Click += new System.EventHandler(this.btnProcurarLeitor_Click);
            // 
            // txtEnderecoLeitor
            // 
            this.txtEnderecoLeitor.Location = new System.Drawing.Point(161, 243);
            this.txtEnderecoLeitor.Name = "txtEnderecoLeitor";
            this.txtEnderecoLeitor.Size = new System.Drawing.Size(100, 20);
            this.txtEnderecoLeitor.TabIndex = 10;
            // 
            // txtEmailLeitor
            // 
            this.txtEmailLeitor.Location = new System.Drawing.Point(161, 196);
            this.txtEmailLeitor.Name = "txtEmailLeitor";
            this.txtEmailLeitor.Size = new System.Drawing.Size(100, 20);
            this.txtEmailLeitor.TabIndex = 9;
            // 
            // txtTelLeitor
            // 
            this.txtTelLeitor.Location = new System.Drawing.Point(161, 141);
            this.txtTelLeitor.Name = "txtTelLeitor";
            this.txtTelLeitor.Size = new System.Drawing.Size(100, 20);
            this.txtTelLeitor.TabIndex = 8;
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.Location = new System.Drawing.Point(161, 86);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(100, 20);
            this.txtNomeLeitor.TabIndex = 7;
            // 
            // txtIdLeitor
            // 
            this.txtIdLeitor.Location = new System.Drawing.Point(161, 31);
            this.txtIdLeitor.Name = "txtIdLeitor";
            this.txtIdLeitor.Size = new System.Drawing.Size(100, 20);
            this.txtIdLeitor.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvLeitor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvLeitor
            // 
            this.dgvLeitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitor.Location = new System.Drawing.Point(24, 21);
            this.dgvLeitor.Name = "dgvLeitor";
            this.dgvLeitor.Size = new System.Drawing.Size(405, 328);
            this.dgvLeitor.TabIndex = 0;
            // 
            // FrmLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmLeitor";
            this.Text = "Manutenção de Leitores";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnderecoLeitor;
        private System.Windows.Forms.TextBox txtEmailLeitor;
        private System.Windows.Forms.TextBox txtTelLeitor;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.TextBox txtIdLeitor;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterarLeitor;
        private System.Windows.Forms.Button btnNovoLeitor;
        private System.Windows.Forms.Button btnProcurarLeitor;
        private System.Windows.Forms.DataGridView dgvLeitor;
    }
}