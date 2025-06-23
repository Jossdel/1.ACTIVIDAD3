using System;
using System.Windows.Forms;

namespace EJERCICIO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Llenar los ComboBox con unidades
            cmbEntrada.Items.Add("Metros");
            cmbEntrada.Items.Add("Centímetros");
            cmbEntrada.Items.Add("Pulgadas");

            cmbSalida.Items.Add("Metros");
            cmbSalida.Items.Add("Centímetros");
            cmbSalida.Items.Add("Pulgadas");

            // Seleccionar por defecto
            cmbEntrada.SelectedIndex = 0;
            cmbSalida.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            // Validar que haya selección
            if (cmbEntrada.SelectedItem == null || cmbSalida.SelectedItem == null)
            {
                lblResultado.Text = "Selecciona ambas unidades.";
                return;
            }

            // Validar que el valor ingresado sea un número
            double valor;
            if (double.TryParse(txtValor.Text, out valor))
            {
                string unidadEntrada = cmbEntrada.SelectedItem.ToString();
                string unidadSalida = cmbSalida.SelectedItem.ToString();

                // Convertir a metros
                double valorEnMetros = valor;
                if (unidadEntrada == "Centímetros") valorEnMetros = valor / 100;
                else if (unidadEntrada == "Pulgadas") valorEnMetros = valor * 0.0254;

                // Convertir desde metros a la unidad de salida
                double resultado = valorEnMetros;
                if (unidadSalida == "Centímetros") resultado = valorEnMetros * 100;
                else if (unidadSalida == "Pulgadas") resultado = valorEnMetros / 0.0254;

                lblResultado.Text = $"Resultado: {resultado:F2} {unidadSalida}";
            }
            else
            {
                lblResultado.Text = "Ingrese un número válido.";
            }
        }
    }
}