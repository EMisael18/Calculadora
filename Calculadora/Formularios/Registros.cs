using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class Registros : Form
    {
        List<Persona> listaPersonas = new List<Persona>();
        public Registros()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            listaPersonas.Add(new Persona() { Nombre = txtNombre.Text, Apellido = txtApellido.Text, Fecha = dtpFecha.Value });
            MessageBox.Show("Persona registrada con exito", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listaPersonas;
            }
        }
    }
}
