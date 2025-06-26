using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIOUNIDAD4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Alumno
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public double Promedio { get; set; }
        }
        // Arreglo y contador
        Alumno[] alumnos = new Alumno[100];
        int cantidad = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPromedio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cantidad >= 100)
            {
                MessageBox.Show("Se alcanzó el máximo de alumnos.");
                return;
            }

            Alumno nuevo = new Alumno();
            nuevo.Codigo = txtCodigo.Text;
            nuevo.Nombre = txtNombre.Text;

            if (double.TryParse(txtPromedio.Text, out double promedio))
            {
                nuevo.Promedio = promedio;
                alumnos[cantidad] = nuevo;
                cantidad++;

                MostrarAlumnos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Promedio inválido.");
            }
        }
        private void MostrarAlumnos()
        {
            listBoxAlumnos.Items.Clear();
            for (int i = 0; i < cantidad; i++)
            {
                listBoxAlumnos.Items.Add($"Código: {alumnos[i].Codigo}, Nombre: {alumnos[i].Nombre}, Promedio: {alumnos[i].Promedio}");
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPromedio.Clear();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            for (int i = 0; i < cantidad; i++)
            {
                if (alumnos[i].Codigo == codigo)
                {
                    for (int j = i; j < cantidad - 1; j++)
                    {
                        alumnos[j] = alumnos[j + 1];
                    }
                    alumnos[cantidad - 1] = null;
                    cantidad--;

                    MostrarAlumnos();
                    LimpiarCampos();
                    MessageBox.Show("Alumno eliminado.");
                    return;
                }
            }

            MessageBox.Show("Alumno no encontrado.");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Array.Sort(alumnos, 0, cantidad, Comparer<Alumno>.Create((a, b) => a.Promedio.CompareTo(b.Promedio)));
            MostrarAlumnos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtBuscarCodigo.Text;

            for (int i = 0; i < cantidad; i++)
            {
                if (alumnos[i].Codigo == codigo)
                {
                    MessageBox.Show($"Nombre: {alumnos[i].Nombre}\nPromedio: {alumnos[i].Promedio}");
                    return;
                }
            }

            MessageBox.Show("Alumno no encontrado.");
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
