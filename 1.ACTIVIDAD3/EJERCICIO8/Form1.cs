using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        private void btnContar_Click(object sender, EventArgs e)
        {
            string oracion = txtOracion.Text.Trim();

            if (string.IsNullOrWhiteSpace(oracion))
            {
                lblResultado.Text = "Cantidad de palabras: 0";
                return;
            }

            // Dividir usando espacios y contar palabras
            string[] palabras = oracion.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int cantidad = palabras.Length;

            lblResultado.Text = "Cantidad de palabras: " + cantidad;
        }

        private void txtOracion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
