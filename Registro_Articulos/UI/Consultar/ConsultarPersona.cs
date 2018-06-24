using Registro_Articulos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Articulos.UI.Consultar
{
    public partial class ConsultarPersona : Form
    {
        public ConsultarPersona()
        {
            InitializeComponent();
        }

        private void BuscarFiltrobutton_Click(object sender, EventArgs e)
        {
            //Inicializando el filtro en True
            Expression<Func<Personas, bool>> filtro = x => true;

            int id;
            switch (FiltrarcomboBox.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(FiltrartextBox.Text);
                    filtro = x => x.PersonaId == id
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 1:// nombre
                    filtro = x => x.Nombre.Contains(FiltrartextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 2:// cedula
                    filtro = x => x.Cedula.Equals(FiltrartextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 3:// direccion
                    filtro = x => x.Direccion.Contains(FiltrartextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
                case 4://telefono
                    filtro = x => x.Telefono.Equals(FiltrartextBox.Text)
                    && (x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value);
                    break;
            }
        }
    }
}