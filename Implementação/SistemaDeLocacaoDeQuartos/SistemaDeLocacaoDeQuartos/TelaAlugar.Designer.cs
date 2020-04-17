namespace SistemaDeLocacaoDeQuartos
{
    partial class TelaAlugar
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
            this.lblNumeroDoQuarto = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbNumeroDoQuarto
            // 
            this.cmbNumeroDoQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNumeroDoQuarto.FormattingEnabled = true;
            this.cmbNumeroDoQuarto.Items.AddRange(new object[] {
            "370 - A",
            "370 - B",
            "370 - C",
            "370 - D",
            "370 - E",
            "370 - F",
            "370 - G",
            "370 - H",
            "370 - I",
            "370 - J",
            "370 - K",
            "370 - L",
            "370 - M",
            "370 - N",
            "370 - O",
            "370 - P"});
            this.cmbNumeroDoQuarto.Location = new System.Drawing.Point(42, 53);
            this.cmbNumeroDoQuarto.Name = "cmbNumeroDoQuarto";
            this.cmbNumeroDoQuarto.Size = new System.Drawing.Size(167, 26);
            this.cmbNumeroDoQuarto.TabIndex = 13;
            // 
            // lblNumeroDoQuarto
            // 
            this.lblNumeroDoQuarto.AutoSize = true;
            this.lblNumeroDoQuarto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDoQuarto.Location = new System.Drawing.Point(39, 32);
            this.lblNumeroDoQuarto.Name = "lblNumeroDoQuarto";
            this.lblNumeroDoQuarto.Size = new System.Drawing.Size(140, 18);
            this.lblNumeroDoQuarto.TabIndex = 12;
            this.lblNumeroDoQuarto.Text = "Número do Quarto:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Items.AddRange(new object[] {
            "370 - A",
            "370 - B",
            "370 - C",
            "370 - D",
            "370 - E",
            "370 - F",
            "370 - G",
            "370 - H",
            "370 - I",
            "370 - J",
            "370 - K",
            "370 - L",
            "370 - M",
            "370 - N",
            "370 - O",
            "370 - P"});
            this.cmbCliente.Location = new System.Drawing.Point(42, 120);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(167, 26);
            this.cmbCliente.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cliente:";
            // 
            // btnAlugar
            // 
            this.btnAlugar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlugar.Location = new System.Drawing.Point(78, 165);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(101, 36);
            this.btnAlugar.TabIndex = 28;
            this.btnAlugar.Text = "ALUGAR";
            this.btnAlugar.UseVisualStyleBackColor = true;
            // 
            // TelaAlugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 247);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbNumeroDoQuarto);
            this.Controls.Add(this.lblNumeroDoQuarto);
            this.Name = "TelaAlugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alugar quarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNumeroDoQuarto;
        private System.Windows.Forms.Label lblNumeroDoQuarto;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlugar;
    }
}