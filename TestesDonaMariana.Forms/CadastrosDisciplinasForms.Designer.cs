namespace TestesDonaMariana.Forms
{
    partial class CadastrosDisciplinasForms
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
            this.labelNomeCadastroDisciplina = new System.Windows.Forms.Label();
            this.labelNumeroCadastroDisciplina = new System.Windows.Forms.Label();
            this.textBoxNomeDisciplina = new System.Windows.Forms.TextBox();
            this.textBoxNumeroDisciplina = new System.Windows.Forms.TextBox();
            this.buttonVoltarCadastroDisciplinas = new System.Windows.Forms.Button();
            this.buttonCadastrarNovoCadastroDisciplinas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeCadastroDisciplina
            // 
            this.labelNomeCadastroDisciplina.AutoSize = true;
            this.labelNomeCadastroDisciplina.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelNomeCadastroDisciplina.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNomeCadastroDisciplina.Location = new System.Drawing.Point(273, 172);
            this.labelNomeCadastroDisciplina.Name = "labelNomeCadastroDisciplina";
            this.labelNomeCadastroDisciplina.Size = new System.Drawing.Size(222, 32);
            this.labelNomeCadastroDisciplina.TabIndex = 25;
            this.labelNomeCadastroDisciplina.Text = "Nome da Disciplina:";
            // 
            // labelNumeroCadastroDisciplina
            // 
            this.labelNumeroCadastroDisciplina.AutoSize = true;
            this.labelNumeroCadastroDisciplina.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelNumeroCadastroDisciplina.Location = new System.Drawing.Point(273, 112);
            this.labelNumeroCadastroDisciplina.Name = "labelNumeroCadastroDisciplina";
            this.labelNumeroCadastroDisciplina.Size = new System.Drawing.Size(193, 32);
            this.labelNumeroCadastroDisciplina.TabIndex = 24;
            this.labelNumeroCadastroDisciplina.Text = "Número da série:";
            // 
            // textBoxNomeDisciplina
            // 
            this.textBoxNomeDisciplina.AutoCompleteCustomSource.AddRange(new string[] {
            "Matemática",
            "Português",
            "Biologia",
            "Educação Física",
            "Ensino Religioso",
            "Artes",
            "História",
            "Geografia"});
            this.textBoxNomeDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeDisciplina.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNomeDisciplina.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNomeDisciplina.Location = new System.Drawing.Point(533, 170);
            this.textBoxNomeDisciplina.Name = "textBoxNomeDisciplina";
            this.textBoxNomeDisciplina.Size = new System.Drawing.Size(268, 34);
            this.textBoxNomeDisciplina.TabIndex = 23;
            // 
            // textBoxNumeroDisciplina
            // 
            this.textBoxNumeroDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumeroDisciplina.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumeroDisciplina.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumeroDisciplina.Location = new System.Drawing.Point(533, 113);
            this.textBoxNumeroDisciplina.Name = "textBoxNumeroDisciplina";
            this.textBoxNumeroDisciplina.Size = new System.Drawing.Size(182, 34);
            this.textBoxNumeroDisciplina.TabIndex = 22;
            // 
            // buttonVoltarCadastroDisciplinas
            // 
            this.buttonVoltarCadastroDisciplinas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVoltarCadastroDisciplinas.Location = new System.Drawing.Point(541, 396);
            this.buttonVoltarCadastroDisciplinas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVoltarCadastroDisciplinas.Name = "buttonVoltarCadastroDisciplinas";
            this.buttonVoltarCadastroDisciplinas.Size = new System.Drawing.Size(150, 113);
            this.buttonVoltarCadastroDisciplinas.TabIndex = 21;
            this.buttonVoltarCadastroDisciplinas.Text = "Voltar";
            this.buttonVoltarCadastroDisciplinas.UseVisualStyleBackColor = true;
            this.buttonVoltarCadastroDisciplinas.Click += new System.EventHandler(this.buttonVoltarCadastroDisciplinas_Click);
            // 
            // buttonCadastrarNovoCadastroDisciplinas
            // 
            this.buttonCadastrarNovoCadastroDisciplinas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrarNovoCadastroDisciplinas.Location = new System.Drawing.Point(333, 396);
            this.buttonCadastrarNovoCadastroDisciplinas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCadastrarNovoCadastroDisciplinas.Name = "buttonCadastrarNovoCadastroDisciplinas";
            this.buttonCadastrarNovoCadastroDisciplinas.Size = new System.Drawing.Size(150, 113);
            this.buttonCadastrarNovoCadastroDisciplinas.TabIndex = 17;
            this.buttonCadastrarNovoCadastroDisciplinas.Text = "Cadastrar Novo";
            this.buttonCadastrarNovoCadastroDisciplinas.UseVisualStyleBackColor = true;
            this.buttonCadastrarNovoCadastroDisciplinas.Click += new System.EventHandler(this.buttonCadastrarNovoCadastroDisciplinas_Click);
            // 
            // CadastrosDisciplinasForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 637);
            this.Controls.Add(this.labelNomeCadastroDisciplina);
            this.Controls.Add(this.labelNumeroCadastroDisciplina);
            this.Controls.Add(this.textBoxNomeDisciplina);
            this.Controls.Add(this.textBoxNumeroDisciplina);
            this.Controls.Add(this.buttonVoltarCadastroDisciplinas);
            this.Controls.Add(this.buttonCadastrarNovoCadastroDisciplinas);
            this.Name = "CadastrosDisciplinasForms";
            this.Text = "Cadastro de Disciplinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomeCadastroDisciplina;
        private System.Windows.Forms.Label labelNumeroCadastroDisciplina;
        private System.Windows.Forms.TextBox textBoxNomeDisciplina;
        private System.Windows.Forms.TextBox textBoxNumeroDisciplina;
        private System.Windows.Forms.Button buttonVoltarCadastroDisciplinas;
        private System.Windows.Forms.Button buttonCadastrarNovoCadastroDisciplinas;
    }
}