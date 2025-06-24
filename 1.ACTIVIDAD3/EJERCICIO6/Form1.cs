using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Validamos si hay número escrito
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Por favor, introduce un número.");
                return;
            }

            int numero = int.Parse(maskedTextBox1.Text);
            int suma = 0;

            // Sumar los divisores propios
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma += i;
                }
            }

            // Verificamos si es perfecto
            if (suma == numero)
            {
                MessageBox.Show(numero + " es un número perfecto.");
            }
            else
            {
                MessageBox.Show(numero + " no es un número perfecto.");
            }
        }

    }
}
