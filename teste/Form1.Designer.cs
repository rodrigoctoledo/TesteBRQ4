namespace teste
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
            this.buttonConverter = new System.Windows.Forms.Button();
            this.textBoxNumeros = new System.Windows.Forms.TextBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConverter
            // 
            this.buttonConverter.Location = new System.Drawing.Point(154, 89);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(75, 23);
            this.buttonConverter.TabIndex = 0;
            this.buttonConverter.Text = "Calc";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // textBoxNumeros
            // 
            this.textBoxNumeros.Location = new System.Drawing.Point(33, 89);
            this.textBoxNumeros.Name = "textBoxNumeros";
            this.textBoxNumeros.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumeros.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(22, 242);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(455, 22);
            this.textBoxResultado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.textBoxNumeros);
            this.Controls.Add(this.buttonConverter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.TextBox textBoxNumeros;
        private System.Windows.Forms.TextBox textBoxResultado;
    }
}

