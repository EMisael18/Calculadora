using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Calculadora.Formularios
{

    public partial class frmXLMAcces : Form
    {
        public frmXLMAcces()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            XElement xml = new XElement("root");



            for (int i = 0; i < dgvPersonas.Rows.Count; i++)
            {
                //xml.Add(new XElement("Personas", new XAttribute ("Id", dgvPersonas.Rows[i].Cells[0].Value),
                //     new XAttribute("Nombre", dgvPersonas.Rows[i].Cells[1].Value),
                //     new XAttribute("Telefono", dgvPersonas.Rows[i].Cells[2].Value)));


                xml.Add(new XElement("Personas",
                    new XElement("Id", dgvPersonas.Rows[i].Cells[0].Value),
                    new XElement("Nombre", dgvPersonas.Rows[i].Cells[1].Value),
                    new XElement("Telefono", dgvPersonas.Rows[i].Cells[2].Value)));

            }
            try
            {

                xml.Save("Archivo.xml");
                MessageBox.Show("Archivo guardado exitosamente.", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }
    }
}

