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
            this.labelResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ecUno
            // 
            this.ecUno.BackColor = System.Drawing.Color.AliceBlue;
            this.ecUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ecUno.Location = new System.Drawing.Point(88, 168);
            this.ecUno.Multiline = true;
            this.ecUno.Name = "ecUno";
            this.ecUno.Size = new System.Drawing.Size(318, 37);
            this.ecUno.TabIndex = 0;
            this.ecUno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ecUno.TextChanged += new System.EventHandler(this.ecUno_TextChanged);
            // 
            // ecDos
            // 
            this.ecDos.BackColor = System.Drawing.Color.AliceBlue;
            this.ecDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ecDos.Location = new System.Drawing.Point(88, 313);
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
            this.label1.Location = new System.Drawing.Point(183, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ecuación 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(183, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ecuación 2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(174, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Resolver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAdvertencia1
            // 
            this.labelAdvertencia1.AutoSize = true;
            this.labelAdvertencia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelAdvertencia1.ForeColor = System.Drawing.Color.IndianRed;
            this.labelAdvertencia1.Location = new System.Drawing.Point(417, 169);
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
            this.labelAdvertencia2.Location = new System.Drawing.Point(417, 313);
            this.labelAdvertencia2.Name = "labelAdvertencia2";
            this.labelAdvertencia2.Size = new System.Drawing.Size(23, 36);
            this.labelAdvertencia2.TabIndex = 6;
            this.labelAdvertencia2.Text = "!";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResultado.Location = new System.Drawing.Point(565, 130);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 20);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(569, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 319);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(82, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(775, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingrese dos ecuaciones para calcular su intersección, perpendicularidad o paralal" +
    "elismo.\r\n                               Las ecuaciones debe ingresarlas de la fo" +
    "rma y=mx+b.\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 93);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(982, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelAdvertencia2);
            this.Controls.Add(this.labelAdvertencia1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ecDos);
            this.Controls.Add(this.ecUno);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

