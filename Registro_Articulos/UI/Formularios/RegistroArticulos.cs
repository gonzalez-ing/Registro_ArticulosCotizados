using Registro_Articulos.BLL;
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
    public partial class RegistroArticulos : Form
    {
        public RegistroArticulos()
        {
            InitializeComponent();
        }

        private Articulos LlenarClase()
        {
            int id = (ArticulosIdnumericUpDown.Value == 0) ? 0 : (int)ArticulosIdnumericUpDown.Value;
            return new Articulos(id, FechadateTimePicker.Value, DescripciontextBox.Text, PrecionumericUpDown.Value, 
                (int)CantidadnumericUpDown.Value, (string.IsNullOrWhiteSpace(CantidadCotizadatextBox.Text)) 
                ? 0 : int.Parse(CantidadCotizadatextBox.Text)
                );
        }

        private void Limpiar()
        {
            ArticulosIdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            PrecionumericUpDown.Value = 0;
            CantidadnumericUpDown.Value = 0;
            CantidadCotizadatextBox.Text = string.Empty;
            errorProvider.Clear();
        }

        private bool GetValidacion()
        {
            if (!string.IsNullOrWhiteSpace(DescripciontextBox.Text) &&
                PrecionumericUpDown.Value != 0)
                return true;
            else
                return false;
        }

        private void ActivarError()
        {
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
                errorProvider.SetError(DescripciontextBox, "Debe Escribir Una Descripcion");
            if (PrecionumericUpDown.Value == 0)
                errorProvider.SetError(PrecionumericUpDown, "El Precio Debe Ser Mayor Que Cero");
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Articulos articulo = ArticulosBLL.Buscar((int)ArticulosIdnumericUpDown.Value);

            if (GetValidacion())
            {
                if (articulo == null)
                {
                    if (ArticulosBLL.Guardar(LlenarClase()))
                        MessageBox.Show("Guardado Con Exito");
                    else
                        MessageBox.Show("El Articulo No Se Guardo");
                }
                else
                {
                    if (ArticulosBLL.Modificar(LlenarClase()))
                        MessageBox.Show("Modificado Con Exito");
                    else
                        MessageBox.Show("El Articulo No Se Modifico");
                }
            }
            else
                ActivarError();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            ArticulosBLL.Eliminar((int)ArticulosIdnumericUpDown.Value);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Articulos articulo = ArticulosBLL.Buscar((int)ArticulosIdnumericUpDown.Value);

            if (articulo != null)
            {
                ArticulosIdnumericUpDown.Value = articulo.ArticuloId;
                FechadateTimePicker.Value = (DateTime)articulo.Fecha;
                DescripciontextBox.Text = articulo.Descripcion;
                PrecionumericUpDown.Value = (Decimal)articulo.Precio;
                CantidadnumericUpDown.Value = articulo.Cantidad;
                CantidadCotizadatextBox.Text = articulo.CantidadCotizada.ToString();
            }
            else
            {
                MessageBox.Show("Este Articulo no existe");
            }
        }

        private void RegistroArticulos_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void DescripciontextBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(DescripciontextBox, "");
        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PrecionumericUpDown.Value != 0)
                errorProvider.SetError(PrecionumericUpDown, "");
        }
    }
}
