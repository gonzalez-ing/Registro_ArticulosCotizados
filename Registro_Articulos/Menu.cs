using Registro_Articulos.UI.Consultar;
using Registro_Articulos.UI.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Articulos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void articuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new RegistroArticulos().Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarArticulos().Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroPersonas().Show();
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RegistroCotizaciones().Show();
        }

        private void personaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           new ConsultarPersona().Show();
        }
    }
}
