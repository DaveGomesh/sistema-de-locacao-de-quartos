namespace SistemaDeLocacaoDeQuartos
{
    partial class TelaCadastrarQuarto
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
            this.lblNumeroDoQuarto = new System.Windows.Forms.Label();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbLuxo = new System.Windows.Forms.RadioButton();
            this.rbSimples = new System.Windows.Forms.RadioButton();
            this.gbQuantidades = new System.Windows.Forms.GroupBox();
            this.cmbCozinhas = new System.Windows.Forms.ComboBox();
            this.cmbSalas = new System.Windows.Forms.ComboBox();
            this.cmbBanheiros = new System.Windows.Forms.ComboBox();
            this.lblCozinha = new System.Windows.Forms.Label();
            this.lblSalas = new System.Windows.Forms.Label();
            this.lblBanheiros = new System.Windows.Forms.Label();
            this.lblPrecoDaMensalidade = new System.Windows.Forms.Label();
            this.cmbPrecoDaMensalidade = new System.Windows.Forms.ComboBox();
            this.gbAndar = new System.Windows.Forms.GroupBox();
            this.rbSegundoAndar = new System.Windows.Forms.RadioButton();
            this.rbPrimeiroAndar = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtNumeroQuarto = new System.Windows.Forms.TextBox();
            this.gbTipo.SuspendLayout();
            this.gbQuantidades.SuspendLayout();
            this.gbAndar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroDoQuarto
            // 
            this.lblNumeroDoQuarto.AutoSize = true;
            this.lblNumeroDoQuarto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDoQuarto.Location = new System.Drawing.Point(19, 19);
            this.lblNumeroDoQuarto.Name = "lblNumeroDoQuarto";
            this.lblNumeroDoQuarto.Size = new System.Drawing.Size(136, 18);
            this.lblNumeroDoQuarto.TabIndex = 0;
            this.lblNumeroDoQuarto.Text = "Número do Quarto";
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbLuxo);
            this.gbTipo.Controls.Add(this.rbSimples);
            this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipo.Location = new System.Drawing.Point(22, 75);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(263, 51);
            this.gbTipo.TabIndex = 2;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo:";
            // 
            // rbLuxo
            // 
            this.rbLuxo.AutoSize = true;
            this.rbLuxo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLuxo.Location = new System.Drawing.Point(153, 19);
            this.rbLuxo.Name = "rbLuxo";
            this.rbLuxo.Size = new System.Drawing.Size(54, 20);
            this.rbLuxo.TabIndex = 1;
            this.rbLuxo.Text = "Luxo";
            this.rbLuxo.UseVisualStyleBackColor = true;
            // 
            // rbSimples
            // 
            this.rbSimples.AutoSize = true;
            this.rbSimples.Checked = true;
            this.rbSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSimples.Location = new System.Drawing.Point(14, 19);
            this.rbSimples.Name = "rbSimples";
            this.rbSimples.Size = new System.Drawing.Size(75, 20);
            this.rbSimples.TabIndex = 0;
            this.rbSimples.TabStop = true;
            this.rbSimples.Text = "Simples";
            this.rbSimples.UseVisualStyleBackColor = true;
            this.rbSimples.CheckedChanged += new System.EventHandler(this.rbSimples_CheckedChanged);
            // 
            // gbQuantidades
            // 
            this.gbQuantidades.Controls.Add(this.cmbCozinhas);
            this.gbQuantidades.Controls.Add(this.cmbSalas);
            this.gbQuantidades.Controls.Add(this.cmbBanheiros);
            this.gbQuantidades.Controls.Add(this.lblCozinha);
            this.gbQuantidades.Controls.Add(this.lblSalas);
            this.gbQuantidades.Controls.Add(this.lblBanheiros);
            this.gbQuantidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuantidades.Location = new System.Drawing.Point(22, 132);
            this.gbQuantidades.Name = "gbQuantidades";
            this.gbQuantidades.Size = new System.Drawing.Size(263, 90);
            this.gbQuantidades.TabIndex = 3;
            this.gbQuantidades.TabStop = false;
            this.gbQuantidades.Text = "Quantidade de:";
            // 
            // cmbCozinhas
            // 
            this.cmbCozinhas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCozinhas.Enabled = false;
            this.cmbCozinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCozinhas.FormattingEnabled = true;
            this.cmbCozinhas.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbCozinhas.Location = new System.Drawing.Point(173, 46);
            this.cmbCozinhas.Name = "cmbCozinhas";
            this.cmbCozinhas.Size = new System.Drawing.Size(54, 24);
            this.cmbCozinhas.TabIndex = 9;
            this.cmbCozinhas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCozinhas_KeyPress);
            // 
            // cmbSalas
            // 
            this.cmbSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalas.Enabled = false;
            this.cmbSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalas.FormattingEnabled = true;
            this.cmbSalas.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbSalas.Location = new System.Drawing.Point(102, 46);
            this.cmbSalas.Name = "cmbSalas";
            this.cmbSalas.Size = new System.Drawing.Size(54, 24);
            this.cmbSalas.TabIndex = 8;
            this.cmbSalas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSalas_KeyPress);
            // 
            // cmbBanheiros
            // 
            this.cmbBanheiros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanheiros.Enabled = false;
            this.cmbBanheiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBanheiros.FormattingEnabled = true;
            this.cmbBanheiros.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbBanheiros.Location = new System.Drawing.Point(21, 46);
            this.cmbBanheiros.Name = "cmbBanheiros";
            this.cmbBanheiros.Size = new System.Drawing.Size(54, 24);
            this.cmbBanheiros.TabIndex = 7;
            this.cmbBanheiros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBanheiros_KeyPress);
            // 
            // lblCozinha
            // 
            this.lblCozinha.AutoSize = true;
            this.lblCozinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCozinha.Location = new System.Drawing.Point(170, 27);
            this.lblCozinha.Name = "lblCozinha";
            this.lblCozinha.Size = new System.Drawing.Size(59, 16);
            this.lblCozinha.TabIndex = 6;
            this.lblCozinha.Text = "Cozinha:";
            // 
            // lblSalas
            // 
            this.lblSalas.AutoSize = true;
            this.lblSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalas.Location = new System.Drawing.Point(100, 27);
            this.lblSalas.Name = "lblSalas";
            this.lblSalas.Size = new System.Drawing.Size(46, 16);
            this.lblSalas.TabIndex = 5;
            this.lblSalas.Text = "Salas:";
            // 
            // lblBanheiros
            // 
            this.lblBanheiros.AutoSize = true;
            this.lblBanheiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanheiros.Location = new System.Drawing.Point(18, 27);
            this.lblBanheiros.Name = "lblBanheiros";
            this.lblBanheiros.Size = new System.Drawing.Size(72, 16);
            this.lblBanheiros.TabIndex = 4;
            this.lblBanheiros.Text = "Banheiros:";
            // 
            // lblPrecoDaMensalidade
            // 
            this.lblPrecoDaMensalidade.AutoSize = true;
            this.lblPrecoDaMensalidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoDaMensalidade.Location = new System.Drawing.Point(19, 225);
            this.lblPrecoDaMensalidade.Name = "lblPrecoDaMensalidade";
            this.lblPrecoDaMensalidade.Size = new System.Drawing.Size(170, 18);
            this.lblPrecoDaMensalidade.TabIndex = 4;
            this.lblPrecoDaMensalidade.Text = "Preço da Mensalidade:";
            // 
            // cmbPrecoDaMensalidade
            // 
            this.cmbPrecoDaMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrecoDaMensalidade.FormattingEnabled = true;
            this.cmbPrecoDaMensalidade.Items.AddRange(new object[] {
            "250",
            "450",
            "650",
            "850"});
            this.cmbPrecoDaMensalidade.Location = new System.Drawing.Point(22, 246);
            this.cmbPrecoDaMensalidade.MaxLength = 6;
            this.cmbPrecoDaMensalidade.Name = "cmbPrecoDaMensalidade";
            this.cmbPrecoDaMensalidade.Size = new System.Drawing.Size(263, 26);
            this.cmbPrecoDaMensalidade.TabIndex = 5;
            this.cmbPrecoDaMensalidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPrecoDaMensalidade_KeyPress);
            // 
            // gbAndar
            // 
            this.gbAndar.Controls.Add(this.rbSegundoAndar);
            this.gbAndar.Controls.Add(this.rbPrimeiroAndar);
            this.gbAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAndar.Location = new System.Drawing.Point(22, 278);
            this.gbAndar.Name = "gbAndar";
            this.gbAndar.Size = new System.Drawing.Size(263, 51);
            this.gbAndar.TabIndex = 6;
            this.gbAndar.TabStop = false;
            this.gbAndar.Text = "Andar:";
            // 
            // rbSegundoAndar
            // 
            this.rbSegundoAndar.AutoSize = true;
            this.rbSegundoAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSegundoAndar.Location = new System.Drawing.Point(153, 19);
            this.rbSegundoAndar.Name = "rbSegundoAndar";
            this.rbSegundoAndar.Size = new System.Drawing.Size(77, 20);
            this.rbSegundoAndar.TabIndex = 1;
            this.rbSegundoAndar.Text = "2º Andar";
            this.rbSegundoAndar.UseVisualStyleBackColor = true;
            // 
            // rbPrimeiroAndar
            // 
            this.rbPrimeiroAndar.AutoSize = true;
            this.rbPrimeiroAndar.Checked = true;
            this.rbPrimeiroAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrimeiroAndar.Location = new System.Drawing.Point(14, 19);
            this.rbPrimeiroAndar.Name = "rbPrimeiroAndar";
            this.rbPrimeiroAndar.Size = new System.Drawing.Size(77, 20);
            this.rbPrimeiroAndar.TabIndex = 0;
            this.rbPrimeiroAndar.TabStop = true;
            this.rbPrimeiroAndar.Text = "1º Andar";
            this.rbPrimeiroAndar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(36, 352);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(101, 36);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(175, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 36);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtNumeroQuarto.Location = new System.Drawing.Point(22, 41);
            this.txtNumeroQuarto.MaxLength = 5;
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new System.Drawing.Size(263, 24);
            this.txtNumeroQuarto.TabIndex = 9;
            this.txtNumeroQuarto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroQuarto_KeyPress);
            // 
            // TelaCadastrarQuarto
            // 
            this.AcceptButton = this.btnCadastrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 412);
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gbAndar);
            this.Controls.Add(this.cmbPrecoDaMensalidade);
            this.Controls.Add(this.lblPrecoDaMensalidade);
            this.Controls.Add(this.gbQuantidades);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.lblNumeroDoQuarto);
            this.Name = "TelaCadastrarQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastar Quarto";
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.gbQuantidades.ResumeLayout(false);
            this.gbQuantidades.PerformLayout();
            this.gbAndar.ResumeLayout(false);
            this.gbAndar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroDoQuarto;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbLuxo;
        private System.Windows.Forms.RadioButton rbSimples;
        private System.Windows.Forms.GroupBox gbQuantidades;
        private System.Windows.Forms.Label lblCozinha;
        private System.Windows.Forms.Label lblSalas;
        private System.Windows.Forms.Label lblBanheiros;
        private System.Windows.Forms.ComboBox cmbCozinhas;
        private System.Windows.Forms.ComboBox cmbSalas;
        private System.Windows.Forms.ComboBox cmbBanheiros;
        private System.Windows.Forms.Label lblPrecoDaMensalidade;
        private System.Windows.Forms.ComboBox cmbPrecoDaMensalidade;
        private System.Windows.Forms.GroupBox gbAndar;
        private System.Windows.Forms.RadioButton rbSegundoAndar;
        private System.Windows.Forms.RadioButton rbPrimeiroAndar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtNumeroQuarto;
    }
}