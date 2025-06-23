using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Validar que el texto tenga contenido
            if (int.TryParse(mtxtNumero.Text, out int numero))
            {
                if (numero < 2)
                {
                    MessageBox.Show("El número no es primo.", "Resultado");
                    return;
                }

                bool esPrimo = true;
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                    MessageBox.Show("¡Es un número primo!", "Resultado");
                else
                    MessageBox.Show("No es un número primo.", "Resultado");
            }
            else
            {
                MessageBox.Show("Por favor ingresa un número válido.", "Error");
            }
        }
    }
}
