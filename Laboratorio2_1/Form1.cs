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

namespace Laboratorio2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ecUno.TextChanged += validarEcuacion1;
            ecDos.TextChanged += validarEcuacion2;
        }
        private void validarEcuacion1(object sender, EventArgs e)
        {
            string ecuacion = ecUno.Text;
            if (EsEcuacionValida(ecuacion))
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
        private void validarEcuacion2(object sender, EventArgs e)
        {
            string ecuacion = ecDos.Text;
            if (EsEcuacionValida(ecuacion))
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

        private bool EsEcuacionValida(string ecuacion)
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
    }
}
