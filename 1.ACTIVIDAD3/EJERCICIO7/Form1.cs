using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listBoxPrimos.Items.Clear(); // Limpiar lista anterior

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtInicio.Text) || string.IsNullOrWhiteSpace(txtFin.Text))
            {
                MessageBox.Show("Por favor, ingresa ambos números.");
                return;
            }

            // Convertir los textos a números
            int inicio, fin;
            if (!int.TryParse(txtInicio.Text, out inicio) || !int.TryParse(txtFin.Text, out fin))
            {
                MessageBox.Show("Por favor, escribe solo números válidos.");
                return;
            }

            if (inicio > fin)
            {
                MessageBox.Show("El número de inicio debe ser menor o igual al número final.");
                return;
            }

            // Buscar números primos en el rango
            for (int num = inicio; num <= fin; num++)
            {
                if (EsPrimo(num))
                {
                    listBoxPrimos.Items.Add(num);
                }
            }
        }

        // Función para verificar si un número es primo
        private bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

    }
}
