using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadora.Formularios
{

    public partial class frmEditor : Form
    {
        bool saved = false;
        String pathe = "";
        int contador = 0;
        string texto = "";
        public frmEditor()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            contador = palabras.Length;
            int contadorLetras = texto.Length;
            int contadorPalabras = palabras.Length;
            tssEstatuss.Text = $"Palabras: {palabras.Length} Caracteres: {texto.Length}";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofdEditor.FileName))
                {
                    using (StreamReader sr = new StreamReader(ofdEditor.FileName))
                    {
                        rtbEditor.Text = File.ReadAllText(ofdEditor.FileName);
                    }
                }

            }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfdEditor.FileName))
                {
                    sw.Write(rtbEditor.Text);
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                Guardar();
                saved = true;
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(pathe))
                {
                    sw.Write(rtbEditor.Text);
                }
            }
        }
        private void Guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                pathe = sfdEditor.FileName;
                using (StreamWriter sw = new StreamWriter(sfdEditor.FileName))
                {
                    sw.Write(rtbEditor.Text);
                    //saved = true;
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tssEstatus_TextChanged(object sender, EventArgs e)
        {


        }


        private void tssEstatuss_Click(object sender, EventArgs e)
        {
          
        }

        private void tssEstatuss_TextChanged(object sender, EventArgs e)
        {
            string texto = tssEstatuss.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            contador = palabras.Length;
            int contadorLetras = texto.Length;
            int contadorPalabras = palabras.Length;
            tssEstatuss.Text = $"Palabras: {palabras.Length} Caracteres: {texto.Length}";
        }

        private void ftdEditor_Apply(object sender, EventArgs e)
        {
            
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ftdEditor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.Font = ftdEditor.Font;
               
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cldEditor.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.ForeColor = cldEditor.Color;
            }
        }
    }
}
