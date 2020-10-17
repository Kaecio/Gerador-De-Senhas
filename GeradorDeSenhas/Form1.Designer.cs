namespace GeradorDeSenhas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lista_senhas = new System.Windows.Forms.ListBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.count_chars = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMaiuscula = new System.Windows.Forms.CheckBox();
            this.checkAlgarismo = new System.Windows.Forms.CheckBox();
            this.checkSimbolos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.count_chars)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista_senhas
            // 
            this.Lista_senhas.FormattingEnabled = true;
            this.Lista_senhas.Location = new System.Drawing.Point(12, 50);
            this.Lista_senhas.Name = "Lista_senhas";
            this.Lista_senhas.Size = new System.Drawing.Size(207, 251);
            this.Lista_senhas.TabIndex = 0;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(243, 239);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(145, 62);
            this.btnGerar.TabIndex = 1;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            // 
            // count_chars
            // 
            this.count_chars.Location = new System.Drawing.Point(268, 74);
            this.count_chars.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.count_chars.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.count_chars.Name = "count_chars";
            this.count_chars.Size = new System.Drawing.Size(80, 20);
            this.count_chars.TabIndex = 2;
            this.count_chars.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nº chars: ";
            // 
            // checkMaiuscula
            // 
            this.checkMaiuscula.AutoSize = true;
            this.checkMaiuscula.Location = new System.Drawing.Point(243, 112);
            this.checkMaiuscula.Name = "checkMaiuscula";
            this.checkMaiuscula.Size = new System.Drawing.Size(126, 17);
            this.checkMaiuscula.TabIndex = 4;
            this.checkMaiuscula.Text = "Gerar com Maiuscula";
            this.checkMaiuscula.UseVisualStyleBackColor = true;
            // 
            // checkAlgarismo
            // 
            this.checkAlgarismo.AutoSize = true;
            this.checkAlgarismo.Location = new System.Drawing.Point(243, 135);
            this.checkAlgarismo.Name = "checkAlgarismo";
            this.checkAlgarismo.Size = new System.Drawing.Size(135, 17);
            this.checkAlgarismo.TabIndex = 5;
            this.checkAlgarismo.Text = "Gerar com Algarítismos";
            this.checkAlgarismo.UseVisualStyleBackColor = true;
            // 
            // checkSimbolos
            // 
            this.checkSimbolos.AutoSize = true;
            this.checkSimbolos.Location = new System.Drawing.Point(243, 158);
            this.checkSimbolos.Name = "checkSimbolos";
            this.checkSimbolos.Size = new System.Drawing.Size(122, 17);
            this.checkSimbolos.TabIndex = 6;
            this.checkSimbolos.Text = "Gerar com Símbolos";
            this.checkSimbolos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 339);
            this.Controls.Add(this.checkSimbolos);
            this.Controls.Add(this.checkAlgarismo);
            this.Controls.Add(this.checkMaiuscula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.count_chars);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.Lista_senhas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.count_chars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Lista_senhas;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.NumericUpDown count_chars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkMaiuscula;
        private System.Windows.Forms.CheckBox checkAlgarismo;
        private System.Windows.Forms.CheckBox checkSimbolos;
    }
}

