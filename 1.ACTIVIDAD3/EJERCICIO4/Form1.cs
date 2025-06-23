using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text.ToLower().Replace(" ", ""); // todo en minúscula y sin espacios

            string palabraInvertida = new string(palabra.Reverse().ToArray());

            if (palabra == palabraInvertida)
            {
                MessageBox.Show("¡Es una palabra palíndroma!", "Resultado");
            }
            else
            {
                MessageBox.Show("No es una palabra palíndroma.", "Resultado");
            }
        }
    }
}
