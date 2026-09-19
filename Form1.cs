using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App_de_gatos
{
    public partial class Form1 : Form
    {
        // Lista de gatos en el formulario
        private List<Gato> listaTodosGatos = new List<Gato>();

        public Form1()
        {
            InitializeComponent();
            // Asegurar enlace de eventos por si el diseñador no lo hizo
            this.Load += Form1_Load;
            if (cmbGatos != null)
                cmbGatos.SelectedIndexChanged += cmbGatos_SelectedIndexChanged;
            // Buscar el botón por su Name en tiempo de ejecución en caso de que
            // el campo generado por el diseñador no exista o haya sido renombrado.
            var encontrados = this.Controls.Find("button1", true);
            if (encontrados.Length > 0 && encontrados[0] is Button foundButton)
                foundButton.Click += button1_Click;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            CargarGatos();

            cmbGatos.DataSource = listaTodosGatos;

            txtNombre.ReadOnly = true;
            txtEdad.ReadOnly = true;
            txtRaza.ReadOnly = true;
            txtSexo.ReadOnly = true;
            txtSalud.ReadOnly = true;
        }

        private void CargarGatos()
        {
            listaTodosGatos.Add(new Gato { Nombre = "Mishi", Edad = "2 años", Raza = "Siames", Sexo = "Macho", Salud = "Excelente" });
            listaTodosGatos.Add(new Gato { Nombre = "Pelusa", Edad = "6 meses", Raza = "Persa", Sexo = "Hembra", Salud = "Sano" });
            listaTodosGatos.Add(new Gato { Nombre = "Garfield", Edad = "3 años", Raza = "Mestizo", Sexo = "Macho", Salud = "Sano" });
        }

        private void cmbGatos_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbGatos.SelectedItem is Gato gatoSeleccionado)
            {
                txtNombre.Text = gatoSeleccionado.Nombre;
                txtEdad.Text = gatoSeleccionado.Edad;
                txtRaza.Text = gatoSeleccionado.Raza;
                txtSexo.Text = gatoSeleccionado.Sexo;
                txtSalud.Text = gatoSeleccionado.Salud;
            }
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            if (cmbGatos.SelectedItem is Gato gatoSeleccionado)
            {
                MessageBox.Show($"¡Gracias por tu interés! Has solicitado la adopción de {gatoSeleccionado.Nombre}",
                               "Solicitud enviada",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un gato de la lista.",
                                "Atención",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }

    // Clase Gato fuera de Form1 para separar el modelo de la vista
    public class Gato
    {
        public string? Nombre { get; set; }
        public string? Edad { get; set; }
        public string? Raza { get; set; }
        public string? Sexo { get; set; }
        public string? Salud { get; set; }

        public override string ToString() => Nombre ?? string.Empty;
    }
}
