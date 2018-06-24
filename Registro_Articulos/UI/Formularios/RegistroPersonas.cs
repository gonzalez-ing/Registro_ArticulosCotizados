using Registro_Articulos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_Articulos.UI.Formularios
{
    public partial class RegistroPersonas : Form
    {
        public RegistroPersonas()
        {
            InitializeComponent();
        }

        private void RegistroPersonas_Load(object sender, EventArgs e)
        {

        }

        private Personas LlenaClase()
        {
            Personas persona = new Personas();

            persona.PersonaId = Convert.ToInt32(IdnumericUpDown.Value);
            persona.Fecha = FechadateTimePicker.Value;
            persona.Nombre = NombretextBox.Text;
            persona.Cedula = CedulamaskedTextBox.Text;
            persona.Direccion = DirecciontextBox.Text;
            persona.Telefono = TelefonomaskedTextBox.Text;

            return persona;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Personas persona = BLL.PersonasBLL.Buscar(id);

            if (persona != null)
            {
                FechadateTimePicker.Value = persona.Fecha;
                NombretextBox.Text = persona.Nombre;
                CedulamaskedTextBox.Text = persona.Cedula;
                DirecciontextBox.Text = persona.Direccion;
                TelefonomaskedTextBox.Text = persona.Telefono;
            }
            else
                MessageBox.Show("No Se Encontro", "Hay Problema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Personas persona;
            bool Paso = false;


            persona = LlenaClase();

            if (IdnumericUpDown.Value == 0)
                Paso = BLL.PersonasBLL.Guardar(persona);
            else
                Paso = BLL.PersonasBLL.Modificar(persona);

            if (Paso)
                MessageBox.Show("Guardado!!", "Excelente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se guardo!!", "Hay Problema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            //todo: validar que exista
            if (BLL.PersonasBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se elimino!!", "Hay Problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Validar()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text))
            {
                MyerrorProvider.SetError(TelefonomaskedTextBox,
                    "No puedes dejar el telefono vacio");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MyerrorProvider.SetError(NombretextBox,
                     "No puedes dejar el nombre vacio");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {

                MyerrorProvider.SetError(DirecciontextBox,
                    "No puedes dejar la direccion vacia");
                HayErrores = true;
            }
            if (String.IsNullOrWhiteSpace(CedulamaskedTextBox.Text))
            {

                MyerrorProvider.SetError(CedulamaskedTextBox,
                    "No puedes dejar la cedula vacia");
                HayErrores = true;
            }

            return HayErrores;
        }
    }
}
