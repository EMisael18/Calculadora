using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
           Ordenamientos ordenamiento = new Ordenamientos();
            int[] Ordenado = new int[dgvDesordenado.RowCount-1];
            for (int i = 0; i<dgvDesordenado.RowCount-1; i++)
            {
                Ordenado[i] = Convert.ToInt32(dgvDesordenado.Rows[i].Cells[0].Value);
            }
            Ordenado = ordenamiento.Burbuja(Ordenado);

//Define tamaño de las filas del datagive
            dgvOrdenado.DataSource = Ordenado;

            //llenar el datagive con el arreglo ordenado
            for (int i = 0; i < Ordenado.Length; i++)
            {
                dgvDesordenado.Rows[i].Cells[0].Value = Ordenado[i];
            }
        }
    }
}
