using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void txtVariableA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int A = 0, B = 0, resultado = 0;
                A = Convert.ToInt32(txtVariableA.Text);
                B = int.Parse(txtVariableB.Text);
                resultado = A + B;

                MessageBox.Show("El resultado es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conversion de datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
            
        }
        private void Reset()
        {
            txtVariableA.Text = "";
            txtVariableB.Clear();
            txtVariableA.Focus();
        }
    }
}
