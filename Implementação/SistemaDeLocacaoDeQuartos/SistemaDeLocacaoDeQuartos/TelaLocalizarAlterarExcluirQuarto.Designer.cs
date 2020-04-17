namespace SistemaDeLocacaoDeQuartos
{
    partial class TelaLocalizarAlterarExcluirQuarto
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
            this.cmbNumeroDoQuarto = new System.Windows.Forms.ComboBox();
            this.cmbBanheiros = new System.Windows.Forms.ComboBox();
            this.lblNumeroDoQuarto = new System.Windows.Forms.Label();
            this.cmbCozinhas = new System.Windows.Forms.ComboBox();
            this.cmbSalas = new System.Windows.Forms.ComboBox();
            this.cmbPrecoDaMensalidade = new System.Windows.Forms.ComboBox();
            this.lblPrecoDaMensalidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAndar = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvQuarto = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBanheiros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCozinhas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoMensalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAndar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.picLimpar = new System.Windows.Forms.PictureBox();
            this.picExcluir = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ckPesquisasEspecificas = new System.Windows.Forms.CheckBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.ckAdicionarPesquisa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcluir)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNumeroDoQuarto
            // 
            this.cmbNumeroDoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumeroDoQuarto.FormattingEnabled = true;
            this.cmbNumeroDoQuarto.Location = new System.Drawing.Point(48, 45);
            this.cmbNumeroDoQuarto.Name = "cmbNumeroDoQuarto";
            this.cmbNumeroDoQuarto.Size = new System.Drawing.Size(133, 26);
            this.cmbNumeroDoQuarto.TabIndex = 11;
            // 
            // cmbBanheiros
            // 
            this.cmbBanheiros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanheiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBanheiros.FormattingEnabled = true;
            this.cmbBanheiros.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbBanheiros.Location = new System.Drawing.Point(198, 47);
            this.cmbBanheiros.Name = "cmbBanheiros";
            this.cmbBanheiros.Size = new System.Drawing.Size(80, 24);
            this.cmbBanheiros.TabIndex = 17;
            this.cmbBanheiros.SelectedIndexChanged += new System.EventHandler(this.cmbBanheiros_SelectedIndexChanged);
            // 
            // lblNumeroDoQuarto
            // 
            this.lblNumeroDoQuarto.AutoSize = true;
            this.lblNumeroDoQuarto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDoQuarto.Location = new System.Drawing.Point(45, 24);
            this.lblNumeroDoQuarto.Name = "lblNumeroDoQuarto";
            this.lblNumeroDoQuarto.Size = new System.Drawing.Size(136, 18);
            this.lblNumeroDoQuarto.TabIndex = 10;
            this.lblNumeroDoQuarto.Text = "Número do Quarto";
            // 
            // cmbCozinhas
            // 
            this.cmbCozinhas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCozinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCozinhas.FormattingEnabled = true;
            this.cmbCozinhas.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbCozinhas.Location = new System.Drawing.Point(370, 47);
            this.cmbCozinhas.Name = "cmbCozinhas";
            this.cmbCozinhas.Size = new System.Drawing.Size(79, 24);
            this.cmbCozinhas.TabIndex = 19;
            this.cmbCozinhas.SelectedIndexChanged += new System.EventHandler(this.cmbCozinhas_SelectedIndexChanged);
            // 
            // cmbSalas
            // 
            this.cmbSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalas.FormattingEnabled = true;
            this.cmbSalas.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbSalas.Location = new System.Drawing.Point(284, 47);
            this.cmbSalas.Name = "cmbSalas";
            this.cmbSalas.Size = new System.Drawing.Size(80, 24);
            this.cmbSalas.TabIndex = 18;
            this.cmbSalas.SelectedIndexChanged += new System.EventHandler(this.cmbSalas_SelectedIndexChanged);
            // 
            // cmbPrecoDaMensalidade
            // 
            this.cmbPrecoDaMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrecoDaMensalidade.FormattingEnabled = true;
            this.cmbPrecoDaMensalidade.Items.AddRange(new object[] {
            "R$ 250,00",
            "R$ 450,00",
            "R$ 650,00",
            "R$ 850,00"});
            this.cmbPrecoDaMensalidade.Location = new System.Drawing.Point(198, 103);
            this.cmbPrecoDaMensalidade.Name = "cmbPrecoDaMensalidade";
            this.cmbPrecoDaMensalidade.Size = new System.Drawing.Size(207, 26);
            this.cmbPrecoDaMensalidade.TabIndex = 15;
            // 
            // lblPrecoDaMensalidade
            // 
            this.lblPrecoDaMensalidade.AutoSize = true;
            this.lblPrecoDaMensalidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoDaMensalidade.Location = new System.Drawing.Point(195, 82);
            this.lblPrecoDaMensalidade.Name = "lblPrecoDaMensalidade";
            this.lblPrecoDaMensalidade.Size = new System.Drawing.Size(170, 18);
            this.lblPrecoDaMensalidade.TabIndex = 13;
            this.lblPrecoDaMensalidade.Text = "Preço da Mensalidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cozinhas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Salas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Banheiros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tipo:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Simples",
            "Luxo"});
            this.cmbTipo.Location = new System.Drawing.Point(48, 103);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(133, 24);
            this.cmbTipo.TabIndex = 23;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Andar:";
            // 
            // cmbAndar
            // 
            this.cmbAndar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAndar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAndar.FormattingEnabled = true;
            this.cmbAndar.Items.AddRange(new object[] {
            "1º Andar",
            "2º Andar"});
            this.cmbAndar.Location = new System.Drawing.Point(455, 47);
            this.cmbAndar.Name = "cmbAndar";
            this.cmbAndar.Size = new System.Drawing.Size(101, 24);
            this.cmbAndar.TabIndex = 25;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(411, 115);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 36);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvQuarto
            // 
            this.dgvQuarto.AllowUserToAddRows = false;
            this.dgvQuarto.AllowUserToDeleteRows = false;
            this.dgvQuarto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuarto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNumeroQuarto,
            this.colTipo,
            this.colBanheiros,
            this.colSalas,
            this.colCozinhas,
            this.colPrecoMensalidade,
            this.colAndar,
            this.colExcluir});
            this.dgvQuarto.Location = new System.Drawing.Point(48, 164);
            this.dgvQuarto.Name = "dgvQuarto";
            this.dgvQuarto.Size = new System.Drawing.Size(508, 225);
            this.dgvQuarto.TabIndex = 29;
            this.dgvQuarto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQuarto_CellMouseDoubleClick);
            this.dgvQuarto.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvQuarto_RowHeaderMouseDoubleClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 35;
            // 
            // colNumeroQuarto
            // 
            this.colNumeroQuarto.HeaderText = "Nº do Quarto";
            this.colNumeroQuarto.Name = "colNumeroQuarto";
            this.colNumeroQuarto.ReadOnly = true;
            this.colNumeroQuarto.Width = 55;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            this.colTipo.Width = 50;
            // 
            // colBanheiros
            // 
            this.colBanheiros.HeaderText = "Quant. Banheiros";
            this.colBanheiros.Name = "colBanheiros";
            this.colBanheiros.ReadOnly = true;
            this.colBanheiros.Width = 50;
            // 
            // colSalas
            // 
            this.colSalas.HeaderText = "Quant. Salas";
            this.colSalas.Name = "colSalas";
            this.colSalas.ReadOnly = true;
            this.colSalas.Width = 50;
            // 
            // colCozinhas
            // 
            this.colCozinhas.HeaderText = "Quant. Cozinhas";
            this.colCozinhas.Name = "colCozinhas";
            this.colCozinhas.ReadOnly = true;
            this.colCozinhas.Width = 50;
            // 
            // colPrecoMensalidade
            // 
            this.colPrecoMensalidade.HeaderText = "Preço da Mensalidade";
            this.colPrecoMensalidade.Name = "colPrecoMensalidade";
            this.colPrecoMensalidade.ReadOnly = true;
            this.colPrecoMensalidade.Width = 70;
            // 
            // colAndar
            // 
            this.colAndar.HeaderText = "Andar";
            this.colAndar.Name = "colAndar";
            this.colAndar.ReadOnly = true;
            this.colAndar.Width = 45;
            // 
            // colExcluir
            // 
            this.colExcluir.HeaderText = "Excluir";
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.Width = 45;
            // 
            // picLimpar
            // 
            this.picLimpar.Image = global::SistemaDeLocacaoDeQuartos.Properties.Resources.icons8_limpar_símbolo_32;
            this.picLimpar.Location = new System.Drawing.Point(518, 77);
            this.picLimpar.Name = "picLimpar";
            this.picLimpar.Size = new System.Drawing.Size(38, 31);
            this.picLimpar.TabIndex = 30;
            this.picLimpar.TabStop = false;
            this.picLimpar.Click += new System.EventHandler(this.picLimpar_Click);
            // 
            // picExcluir
            // 
            this.picExcluir.Image = global::SistemaDeLocacaoDeQuartos.Properties.Resources.icons8_windows_metro_32;
            this.picExcluir.Location = new System.Drawing.Point(518, 112);
            this.picExcluir.Name = "picExcluir";
            this.picExcluir.Size = new System.Drawing.Size(38, 37);
            this.picExcluir.TabIndex = 31;
            this.picExcluir.TabStop = false;
            this.picExcluir.Click += new System.EventHandler(this.picExcluir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(411, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 36);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ckPesquisasEspecificas
            // 
            this.ckPesquisasEspecificas.AutoSize = true;
            this.ckPesquisasEspecificas.Location = new System.Drawing.Point(156, 132);
            this.ckPesquisasEspecificas.Name = "ckPesquisasEspecificas";
            this.ckPesquisasEspecificas.Size = new System.Drawing.Size(132, 17);
            this.ckPesquisasEspecificas.TabIndex = 33;
            this.ckPesquisasEspecificas.Text = "Pesquisas específicas";
            this.ckPesquisasEspecificas.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(133, 77);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 20);
            this.txtId.TabIndex = 34;
            this.txtId.Visible = false;
            // 
            // ckAdicionarPesquisa
            // 
            this.ckAdicionarPesquisa.AutoSize = true;
            this.ckAdicionarPesquisa.Location = new System.Drawing.Point(291, 132);
            this.ckAdicionarPesquisa.Name = "ckAdicionarPesquisa";
            this.ckAdicionarPesquisa.Size = new System.Drawing.Size(115, 17);
            this.ckAdicionarPesquisa.TabIndex = 35;
            this.ckAdicionarPesquisa.Text = "Adicionar pesquisa";
            this.ckAdicionarPesquisa.UseVisualStyleBackColor = true;
            // 
            // TelaLocalizarAlterarExcluirQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 424);
            this.Controls.Add(this.ckAdicionarPesquisa);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.ckPesquisasEspecificas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.picExcluir);
            this.Controls.Add(this.picLimpar);
            this.Controls.Add(this.dgvQuarto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAndar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNumeroDoQuarto);
            this.Controls.Add(this.cmbBanheiros);
            this.Controls.Add(this.lblNumeroDoQuarto);
            this.Controls.Add(this.cmbCozinhas);
            this.Controls.Add(this.cmbSalas);
            this.Controls.Add(this.cmbPrecoDaMensalidade);
            this.Controls.Add(this.lblPrecoDaMensalidade);
            this.Name = "TelaLocalizarAlterarExcluirQuarto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quarto: localizar, alterar, excluir";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuarto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExcluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbNumeroDoQuarto;
        private System.Windows.Forms.ComboBox cmbBanheiros;
        private System.Windows.Forms.Label lblNumeroDoQuarto;
        private System.Windows.Forms.ComboBox cmbCozinhas;
        private System.Windows.Forms.ComboBox cmbSalas;
        private System.Windows.Forms.ComboBox cmbPrecoDaMensalidade;
        private System.Windows.Forms.Label lblPrecoDaMensalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAndar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvQuarto;
        private System.Windows.Forms.PictureBox picLimpar;
        private System.Windows.Forms.PictureBox picExcluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox ckPesquisasEspecificas;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroQuarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBanheiros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCozinhas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoMensalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAndar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colExcluir;
        private System.Windows.Forms.CheckBox ckAdicionarPesquisa;
    }
}