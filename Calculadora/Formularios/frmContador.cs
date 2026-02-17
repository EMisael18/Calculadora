using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class frmContador : Form
    {
        int contador = 0; // Variable para almacenar el valor del contador
        public frmContador()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tcbVelocidad.Enabled = true; // Deshabilita el TrackBar mientras el contador está en marcha
            tmrContador.Interval = tcbVelocidad.Value * 200; // Establece el intervalo a 1 segundo (1000 ms)
            tmrContador.Enabled = true; // Inicia el contador
            tmrContador.Start(); // Inicia el temporizador

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = false; // Detiene el contador
            tcbVelocidad.Enabled = false; // Habilita el TrackBar para que se pueda ajustar la velocidad nuevamente
        }

        private void tcbVelocidad_Scroll(object sender, EventArgs e)
        {
            tmrContador.Interval = tcbVelocidad.Value * 200; // Actualiza el intervalo del temporizador según el valor del TrackBar
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            contador++; // Incrementa el contador
            lblCuenta.Text = contador.ToString(); // Actualiza el texto del Label con el valor del contador
        }
    }
}
