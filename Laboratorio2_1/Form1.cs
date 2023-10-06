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
                // Cuando la ecuación es válida.
                labelAdvertencia1.Visible = false; // Ocultar el símbolo de advertencia
            }
            else
            {
                // Cuando la ecuación no es válida.
                labelAdvertencia1.Visible = true; // Mostrar el símbolo de advertencia
            }
        }
        //Valida que la segunda ecuación tenga un formato correcto.
        private void validarEcuacion2(object sender, EventArgs e)
        {
            string ecuacion2 = ecDos.Text;
            if (ecuacionValida(ecuacion2))
            {
                // Cuando la ecuación es válida se oculta el símbolo de advertencia.
                labelAdvertencia2.Visible = false;

            }
            else
            {
                // Cuando la ecuación no es válida se muestra el símbolo de advertencia.
                labelAdvertencia2.Visible = true;  

            }
        }

        //Funcion que extrae los valores de m y b, de las ecuaciones.
        private bool obtenerCoeficientes(string ecuacion, out double m, out double b)
        {
            m = 0;
            b = 0;

            try
            {
                // Reemplaza los espacios en blanco y convierte todo a minúsculas para simplificar la verificación
                ecuacion = ecuacion.Replace(" ", "").ToLower();

                // Verifica si la ecuación comienza con "y=" y contiene "x" (ignora mayúsculas/minúsculas)
                if (ecuacion.StartsWith("y=") && ecuacion.Contains("x"))
                {
                    // Elimina "y=" y obtén la parte después del igual
                    string parteDerecha = ecuacion.Substring(2);

                    // Divide la parte derecha en términos usando '+' o '-'
                    string[] terminos = parteDerecha.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string termino in terminos)
                    {
                        // Revisa si el término contiene "x" y extrae el coeficiente (m)
                        if (termino.Contains("x"))
                        {
                            string coeficienteStr = termino.Replace("x", "");

                            // Convierte el coeficienteStr a double
                            double coeficiente = Convert.ToDouble(coeficienteStr);
                            m = coeficiente;
                        }
                        else
                        {
                            // El término no contiene "x", por lo que es el término constante (b)
                            b += Convert.ToDouble(termino);
                        }
                    }

                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }


        //Graficación cartesiana.
        private void pictureBoxGrafico_Paint(object sender, PaintEventArgs e)
        {
            // Obtener el contexto de dibujo del PictureBox.
            Graphics g = e.Graphics;

            // Definir los límites del plano cartesiano.
            int minX = -20;
            int maxX = 20;
            int minY = -20;
            int maxY = 20;

            // Obtener el tamaño del PictureBox.
            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;

            // Calcular la escala para convertir coordenadas del plano a coordenadas de píxeles.
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
                    double xValor = (x - (width / 2)) / scaleX;
                    double yValor = -(m1 * xValor + b1); // Negamos y para invertir la dirección del eje Y

                    int xPixel = x;
                    int yPixel = (int)(height / 2 - yValor * scaleY);
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
                    double xValor = (x - (width / 2)) / scaleX;
                    double yValor = (m2 * xValor + b2); // Negamos y para invertir la dirección del eje Y

                    int xPixel = x;
                    int yPixel = (int)(height / 2 - yValor * scaleY);
                    puntosRecta2[x] = new Point(xPixel, yPixel);
                }

                g.DrawLines(Pens.Red, puntosRecta2);
            }
        }

        //Validación del formato de las ecuaciones.
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Asocia el evento Paint del PictureBox para dibujar las rectas en el plano cartesiano
            pictureBox1.Paint += pictureBoxGrafico_Paint;
        }

        
        private void ecUno_TextChanged(object sender, EventArgs e)
        {
            //Validamos condiciones de los valores ingresados
           
            validarEcuacion1(sender, e);
           

        }

        private void ecDos_TextChanged(object sender, EventArgs e)
        {
            //Validamos condiciones de los valores ingresados
            validarEcuacion2(sender, e);
            
            
        }
        //Al presionar el botón se cálcula la intersección, paralelismo o perpendicularidad de las rectas.
        public void button1_Click(object sender, EventArgs e)
        {
            string ecuacion1 = ecUno.Text;
            string ecuacion2 = ecDos.Text;

            double m1;
            double b1;
            double m2;
            double b2;

            // Se extraen los coeficientes del string y se calcula la intersección si es que la tienen o su paralelismo o perpendicularidad.
            if (obtenerCoeficientes(ecuacion1, out m1, out b1) && obtenerCoeficientes(ecuacion2, out m2, out b2))
            {
                double xInterseccion = (b2 - b1) / (m1 - m2);
                double yInterseccion = m1 * xInterseccion + b1;

                labelResultado.Text = $"Intersección en ({xInterseccion} , {yInterseccion})";

                bool m1Negativo = m1 < 0;
                bool m2Negativo = m2 < 0;
                bool b1Negativo = b1 < 0;
                bool b2Negativo = b2 < 0;

                // Verifica si las ecuaciones son coincidentes
                if (Math.Abs(m1 - m2) < double.Epsilon && Math.Abs(b1 - b2) < double.Epsilon)
                {
                    labelResultado.Text = "Las rectas son coincidentes";
                }
                else if (Math.Abs(m1 - m2) < double.Epsilon)
                {
                    if (m1Negativo && m2Negativo)
                    {
                        labelResultado.Text = $"Las rectas son paralelas en ({xInterseccion} , {yInterseccion}) con coeficientes negativos.";
                    }
                    else
                    {
                        labelResultado.Text = "Las rectas son paralelas";
                    }
                }
                else if (Math.Abs(m1 * m2 + 1) < double.Epsilon)
                {
                    if (m1Negativo && m2Negativo)
                    {
                        labelResultado.Text = $"Las rectas son perpendiculares en ({xInterseccion} , {yInterseccion}) con coeficientes negativos.";
                    }
                    else
                    {
                        labelResultado.Text = "Las rectas son perpendiculares";
                    }
                }
                else
                {
                    labelResultado.Text = "Las rectas no son paralelas ni perpendiculares";
                }

                // Invalidar el PictureBox para forzar la actualización de la gráfica.
                pictureBox1.Invalidate();
            }
            else
            {
                labelResultado.Text = "Las ecuaciones no están en el formato correcto.";
            }
        }
           private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

