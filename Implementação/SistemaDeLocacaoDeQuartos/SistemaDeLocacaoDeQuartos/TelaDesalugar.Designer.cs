namespace SistemaDeLocacaoDeQuartos
{
    partial class TelaDesalugar
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
            this.btnDesalugar = new System.Windows.Forms.Button();
            this.cmbNumeroDoQuarto = new System.Windows.Forms.ComboBox();
            this.lblNumeroDoQuarto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDesalugar
            // 
            this.btnDesalugar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesalugar.Location = new System.Drawing.Point(62, 118);
            this.btnDesalugar.Name = "btnDesalugar";
            this.btnDesalugar.Size = new System.Drawing.Size(122, 42);
            this.btnDesalugar.TabIndex = 31;
            this.btnDesalugar.Text = "DESALUGAR";
            this.btnDesalugar.UseVisualStyleBackColor = true;
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
            this.cmbNumeroDoQuarto.Location = new System.Drawing.Point(47, 66);
            this.cmbNumeroDoQuarto.Name = "cmbNumeroDoQuarto";
            this.cmbNumeroDoQuarto.Size = new System.Drawing.Size(167, 26);
            this.cmbNumeroDoQuarto.TabIndex = 30;
            // 
            // lblNumeroDoQuarto
            // 
            this.lblNumeroDoQuarto.AutoSize = true;
            this.lblNumeroDoQuarto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDoQuarto.Location = new System.Drawing.Point(44, 45);
            this.lblNumeroDoQuarto.Name = "lblNumeroDoQuarto";
            this.lblNumeroDoQuarto.Size = new System.Drawing.Size(140, 18);
            this.lblNumeroDoQuarto.TabIndex = 29;
            this.lblNumeroDoQuarto.Text = "Número do Quarto:";
            // 
            // TelaDesalugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 214);
            this.Controls.Add(this.btnDesalugar);
            this.Controls.Add(this.cmbNumeroDoQuarto);
            this.Controls.Add(this.lblNumeroDoQuarto);
            this.Name = "TelaDesalugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desalugar quarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDesalugar;
        private System.Windows.Forms.ComboBox cmbNumeroDoQuarto;
        private System.Windows.Forms.Label lblNumeroDoQuarto;
    }
}