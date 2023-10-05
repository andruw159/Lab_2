namespace Laboratorio2_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ecUno = new System.Windows.Forms.TextBox();
            this.ecDos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAdvertencia1 = new System.Windows.Forms.Label();
            this.labelAdvertencia2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ecUno
            // 
            this.ecUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ecUno.Location = new System.Drawing.Point(86, 103);
            this.ecUno.Multiline = true;
            this.ecUno.Name = "ecUno";
            this.ecUno.Size = new System.Drawing.Size(318, 37);
            this.ecUno.TabIndex = 0;
            this.ecUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ecUno.TextChanged += new System.EventHandler(this.ecUno_TextChanged);
            // 
            // ecDos
            // 
            this.ecDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ecDos.Location = new System.Drawing.Point(86, 228);
            this.ecDos.Multiline = true;
            this.ecDos.Name = "ecDos";
            this.ecDos.Size = new System.Drawing.Size(318, 37);
            this.ecDos.TabIndex = 1;
            this.ecDos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ecDos.TextChanged += new System.EventHandler(this.ecDos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(83, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ecuación 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(83, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ecuación 2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(172, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Resolver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelAdvertencia1
            // 
            this.labelAdvertencia1.AutoSize = true;
            this.labelAdvertencia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelAdvertencia1.ForeColor = System.Drawing.Color.IndianRed;
            this.labelAdvertencia1.Location = new System.Drawing.Point(415, 104);
            this.labelAdvertencia1.Name = "labelAdvertencia1";
            this.labelAdvertencia1.Size = new System.Drawing.Size(23, 36);
            this.labelAdvertencia1.TabIndex = 5;
            this.labelAdvertencia1.Text = "!";
            // 
            // labelAdvertencia2
            // 
            this.labelAdvertencia2.AutoSize = true;
            this.labelAdvertencia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelAdvertencia2.ForeColor = System.Drawing.Color.IndianRed;
            this.labelAdvertencia2.Location = new System.Drawing.Point(415, 229);
            this.labelAdvertencia2.Name = "labelAdvertencia2";
            this.labelAdvertencia2.Size = new System.Drawing.Size(23, 36);
            this.labelAdvertencia2.TabIndex = 6;
            this.labelAdvertencia2.Text = "!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAdvertencia2);
            this.Controls.Add(this.labelAdvertencia1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ecDos);
            this.Controls.Add(this.ecUno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ecUno;
        private System.Windows.Forms.TextBox ecDos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAdvertencia1;
        private System.Windows.Forms.Label labelAdvertencia2;
    }
}

