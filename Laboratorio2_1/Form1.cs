using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laboratorio2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }
        //Valida que la primera ecuación tenga un formato correcto.
        private void validarEcuacion1(object sender, EventArgs e)
        {
            string ecuacion1 = ecUno.Text;
            if (ecuacionValida(ecuacion1))
            {
                // La ecuación es válida
                labelAdvertencia1.Visible = false; // Ocultar el símbolo de advertencia
            }
            else
            {
                // La ecuación no es válida
                labelAdvertencia1.Visible = true; // Mostrar el símbolo de advertencia
            }
        }
        //Valida que la segunda ecuación tenga un formato correcto.
        private void validarEcuacion2(object sender, EventArgs e)
        {
            string ecuacion2 = ecDos.Text;
            if (ecuacionValida(ecuacion2))
            {
                // La ecuación es válida
                labelAdvertencia2.Visible = false; // Ocultar el símbolo de advertencia

            }
            else
            {
                // La ecuación no es válida
                labelAdvertencia2.Visible = true; // Mostrar el símbolo de advertencia

            }
        }
        //---------------------------------------------------------------------------------------------------------

        //Funcion que extrae los valores de m y b, de las ecuaciones.
        private bool obtenerCoeficientes(string ecuacion, out double m, out double b)
        {
            m = 0;
            b = 0;

            try
            {
                // Divide la ecuación en partes separadas por '='
                string[] partes = ecuacion.Split('=');

                if (partes.Length == 2 && partes[0].Trim().Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    string[] partesDerechas = partes[1].Split('+', '-');
                    double coeficienteM = 0.0;
                    double coeficienteB = 0.0;

                    foreach (string termino in partesDerechas)
                    {
                        string terminoLimpio = termino.Trim();
                        if (terminoLimpio.Contains("x"))
                        {
                            // El término contiene "x", por lo que es el coeficiente (m)
                            if (terminoLimpio.Equals("x", StringComparison.OrdinalIgnoreCase))
                            {
                                coeficienteM = 1.0;
                            }
                            else
                            {
                                string coeficienteStr = terminoLimpio.Replace("x", "").Trim();
                                coeficienteM = Convert.ToDouble(coeficienteStr);
                            }
                        }
                        else
                        {
                            // El término no contiene "x", por lo que es el término constante (b)
                            coeficienteB = Convert.ToDouble(terminoLimpio);
                        }
                    }

                    m = coeficienteM;
                    b = coeficienteB;
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        //Gráfica
        private void pictureBoxGrafico_Paint(object sender, PaintEventArgs e)
        {
            // Obtener el contexto de dibujo del PictureBox
            Graphics g = e.Graphics;

            // Definir los límites del plano cartesiano
            int minX = -10;
            int maxX = 10;
            int minY = -10;
            int maxY = 10;

            // Obtener el tamaño del PictureBox
            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;

            // Calcular la escala para convertir coordenadas del plano a coordenadas de píxeles
            float scaleX = (float)width / (maxX - minX);
            float scaleY = (float)height / (minY - maxY);

            // Dibujar ejes X e Y
            g.DrawLine(Pens.Black, 0, height / 2, width, height / 2); // Eje X
            g.DrawLine(Pens.Black, width / 2, 0, width / 2, height); // Eje Y

            // Dibujar recta 1: y = m1x + b1
            double m1;
            double b1;
            if (obtenerCoeficientes(ecUno.Text, out m1, out b1))
            {
                Point[] puntosRecta1 = new Point[width];

                for (int x = 0; x < width; x++)
                {
                    double xValor = (x / scaleX) + minX;
                    double yValor = m1 * xValor + b1;

                    int xPixel = x;
                    int yPixel = (int)((height / 2) - (yValor * scaleY));
                    puntosRecta1[x] = new Point(xPixel, yPixel);
                }

                g.DrawLines(Pens.Blue, puntosRecta1);
            }

            // Dibujar recta 2: y = m2x + b2
            double m2;
            double b2;
            if (obtenerCoeficientes(ecDos.Text, out m2, out b2))
            {
                Point[] puntosRecta2 = new Point[width];

                for (int x = 0; x < width; x++)
                {
                    double xValor = (x / scaleX) + minX;
                    double yValor = m2 * xValor + b2;

                    int xPixel = x;
                    int yPixel = (int)((height / 2) - (yValor * scaleY));
                    puntosRecta2[x] = new Point(xPixel, yPixel);
                }

                g.DrawLines(Pens.Red, puntosRecta2);
            }
        }

        private bool ecuacionValida(string ecuacion)
        {
            // Patrón de expresión regular para verificar la ecuación "y=mx+b"
            string patron = @"^y\s*=\s*(-?(\d+(\.\d+)?)x\s*[+\-]?\s*\d+(\.\d+)?)?$";

            // Usamos RegexOptions.IgnoreCase para que sea insensible a mayúsculas/minúsculas
            Regex regex = new Regex(patron, RegexOptions.IgnoreCase);

            // Si la ecuación es "y=x" (sin importar las mayúsculas/minúsculas), la consideramos válida y la reemplazamos con "y=1x+0"
            if (ecuacion.Equals("y=x", StringComparison.OrdinalIgnoreCase))
            {
                ecuacion = "y=1x+0";
            }

            // Comparamos la entrada con el patrón
            return regex.IsMatch(ecuacion) && !ecuacion.Equals("y=", StringComparison.OrdinalIgnoreCase);
        }

        private void ecUno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita que se agregue una nueva línea en el TextBox
                ecDos.Focus(); // Mueve el foco al siguiente TextBox (textBox2 en este caso)
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Asocia el evento Paint del PictureBox para dibujar las rectas en el plano cartesiano
            pictureBox1.Paint += pictureBoxGrafico_Paint;
        }

        
        private void ecUno_TextChanged(object sender, EventArgs e)
        {
            //validamos condiciones de los valores ingresados
           
            validarEcuacion1(sender, e);
           

        }

        private void ecDos_TextChanged(object sender, EventArgs e)
        {
            
            validarEcuacion2(sender, e);
            
            
        }
        //Al presionar el boton se cálcula la intersección, paralelismo o perpendicularidad de las rectas.
        public void button1_Click(object sender, EventArgs e)
        {
            {
                string ecuacion1 = ecUno.Text;
                string ecuacion2 = ecDos.Text;

                double m1;
                double b1;
                double m2;
                double b2;

                if (obtenerCoeficientes(ecuacion1, out m1, out b1) && obtenerCoeficientes(ecuacion2, out m2, out b2))
                {
                    double xInterseccion = (b2 - b1) / (m1 - m2);
                    double yInterseccion = (m1 * xInterseccion) + b1;

                    labelResultado.Text = $"Intersección en ({xInterseccion}, {yInterseccion})";

                    if (m1 == m2)
                    {
                        labelResultado.Text = "Las rectas son paralelas";
                    }
                    else if (m1 * m2 == -1)
                    {
                        labelResultado.Text = "Las rectas son perpendiculares";
                    }
                }
                else
                {
                    labelResultado.Text = "Las ecuaciones no están en el formato correcto.";
                }

                
            }
        }

        
    }
    }
    

