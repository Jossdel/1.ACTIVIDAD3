using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_2
{
    public partial class Form1 : Form
    {
        private int tiempoRestante; // en segundos

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int minutos, segundos;

            if (!int.TryParse(txtMinutos.Text, out minutos)) minutos = 0;
            if (!int.TryParse(txtSegundos.Text, out segundos)) segundos = 0;

            tiempoRestante = (minutos * 60) + segundos;

            if (tiempoRestante <= 0)
            {
                MessageBox.Show("Por favor, ingresa un tiempo válido.");
                return;
            }

            lblTiempo.Text = FormatearTiempo(tiempoRestante);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;

            lblTiempo.Text = FormatearTiempo(tiempoRestante);

            if (tiempoRestante <= 0)
            {
                timer1.Stop();
                MessageBox.Show("¡Tiempo agotado!");
            }
        }

        private string FormatearTiempo(int totalSegundos)
        {
            int minutos = totalSegundos / 60;
            int segundos = totalSegundos % 60;
            return $"{minutos:D2}:{segundos:D2}";
        }



 
    }
}
