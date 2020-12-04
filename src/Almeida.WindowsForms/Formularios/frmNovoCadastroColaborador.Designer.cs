namespace Almeida.WindowsForms.Formularios
{
    partial class frmNovoCadastroColaborador
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
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.chkListAtividade = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarNovoCadastro = new System.Windows.Forms.Button();
            this.btnVoltarMenumPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(272, 75);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(294, 20);
            this.txtNomeCompleto.TabIndex = 0;
            this.txtNomeCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(272, 141);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(294, 20);
            this.txtTelefone.TabIndex = 1;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(272, 203);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(294, 20);
            this.txtDocumento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(272, 270);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(123, 20);
            this.txtDataNascimento.TabIndex = 8;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // chkListAtividade
            // 
            this.chkListAtividade.BackColor = System.Drawing.SystemColors.Control;
            this.chkListAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListAtividade.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.chkListAtividade.FormattingEnabled = true;
            this.chkListAtividade.Items.AddRange(new object[] {
            "Musculação",
            "Jiu-Jitsu",
            "Boxe",
            "Capoeira",
            "Zumba"});
            this.chkListAtividade.Location = new System.Drawing.Point(272, 318);
            this.chkListAtividade.Name = "chkListAtividade";
            this.chkListAtividade.Size = new System.Drawing.Size(208, 109);
            this.chkListAtividade.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Atividade";
            // 
            // btnSalvarNovoCadastro
            // 
            this.btnSalvarNovoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarNovoCadastro.Location = new System.Drawing.Point(159, 477);
            this.btnSalvarNovoCadastro.Name = "btnSalvarNovoCadastro";
            this.btnSalvarNovoCadastro.Size = new System.Drawing.Size(126, 72);
            this.btnSalvarNovoCadastro.TabIndex = 11;
            this.btnSalvarNovoCadastro.Text = "Salvar";
            this.btnSalvarNovoCadastro.UseVisualStyleBackColor = false;
            this.btnSalvarNovoCadastro.Click += new System.EventHandler(this.btnSalvarNovoCadastro_Click);
            // 
            // btnVoltarMenumPrincipal
            // 
            this.btnVoltarMenumPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltarMenumPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltarMenumPrincipal.Location = new System.Drawing.Point(457, 477);
            this.btnVoltarMenumPrincipal.Name = "btnVoltarMenumPrincipal";
            this.btnVoltarMenumPrincipal.Size = new System.Drawing.Size(126, 72);
            this.btnVoltarMenumPrincipal.TabIndex = 12;
            this.btnVoltarMenumPrincipal.Text = "Voltar";
            this.btnVoltarMenumPrincipal.UseVisualStyleBackColor = false;
            // 
            // frmNovoCadastroColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnVoltarMenumPrincipal);
            this.Controls.Add(this.btnSalvarNovoCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkListAtividade);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNomeCompleto);
            this.Name = "frmNovoCadastroColaborador";
            this.Text = "Novo Cadastro";
            this.Load += new System.EventHandler(this.frmNovoCadastroColaborador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.CheckedListBox chkListAtividade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvarNovoCadastro;
        private System.Windows.Forms.Button btnVoltarMenumPrincipal;
    }
}