using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.VisualBasic;
using System.Media;
using System.Windows.Forms;
using CSCore.SoundOut;

namespace Calculadora.Formularios
{
    public partial class Temporisadores : Form
    {
        string alarma1 = "";
        public Temporisadores()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            if(lblHora.Text == alarma1)
            {
               
                SoundPlayer player = new SoundPlayer(@"C:\Users\Eduardo Misael\Downloads\dragon-studio-rooster-crowing-364473.wav");   
                MessageBox.Show("¡Alarma 1 activada!");
                player.Play();  

            }

        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1=Interaction.InputBox("Ingrese la hora para la alarma 1 (formato: hh:mm:ss tt)", "Configurar Alarma 1", "00:00:00 x.x");
        }
    }
}
