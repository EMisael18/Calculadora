using Calculadora.Formularios;

namespace Calculadora
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculadoraSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora calculadoraSimple = new frmCalculadora();
            calculadoraSimple.Show();
        }

        private void ordenamientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja burbuja = new frmBurbuja();
            burbuja.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros registros = new Registros();
            registros.Show();
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temporisadores temporisadores = new Temporisadores();
            temporisadores.Show();
        }

        private void archivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEditor archivos = new frmEditor();
            archivos.Show();
        }

        private void contadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContador contador = new frmContador();
            contador.Show();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXLMAcces xmlAcceso = new frmXLMAcces();
            xmlAcceso.Show();
        }
    }
}
