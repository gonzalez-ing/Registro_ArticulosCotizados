﻿using Registro_Articulos.Entidades;
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
    public partial class RegistroCotizaciones : Form
    {
        public RegistroCotizaciones()
        {
            InitializeComponent();
        }

        private Cotizaciones LlenaClase()
        {
            Cotizaciones cotizacion = new Cotizaciones();

            cotizacion.CotizacionId = Convert.ToInt32(IdnumericUpDown.Value);
            cotizacion.Fecha = fechaDateTimePicker.Value;
            cotizacion.Comentario = ObservacionestextBox.Text;

            //Agregar cada linea del Grid al detalle
            foreach (DataGridViewRow item in DetalledataGridView.Rows)
            {
                cotizacion.AgregarDetalle(
                    ToInt(item.Cells["id"].Value),
                    ToInt(item.Cells["CotizacionId"].Value),
                    ToInt(item.Cells["PersonaId"].Value),
                    ToInt(item.Cells["ArticuloId"].Value),
                    ToInt(item.Cells["Cantidad"].Value),
                    ToInt(item.Cells["Precio"].Value),
                    ToInt(item.Cells["Importe"].Value)
                  );
            }
            return cotizacion;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            fechaDateTimePicker.Value = DateTime.Now;
            ObservacionestextBox.Clear();
            CantidadtextBox.Clear();
            PreciotextBox.Clear();
            ImportetextBox.Clear();
            TotalnumericUpDown.Value = 0;

            DetalledataGridView.DataSource = null;
            MyerrorProvider.Clear();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Cotizaciones Cotizacion = BLL.CotizacionesBLL.Buscar(id);

            if (Cotizacion != null)
            {
                LlenarCampos(Cotizacion);
            }
            else
                MessageBox.Show("No se encontro!", "Hay Problemas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Cotizaciones cotizacion;
            bool Paso = false;

            if (HayErrores())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cotizacion = LlenaClase();

            if (IdnumericUpDown.Value == 0)
                Paso = BLL.CotizacionesBLL.Guardar(cotizacion);
            else
                Paso = BLL.CotizacionesBLL.Modificar(cotizacion);

            if (Paso)
            {
                NuevoButton.PerformClick();
                MessageBox.Show("Guardado!!", "Excelente",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se guardo!!", "Hay Problema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.CotizacionesBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se elimino!!", "Hay Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            List<Cotizaciones_Detalles> detalle = new List<Cotizaciones_Detalles>();

            if (DetalledataGridView.DataSource != null)
            {
                detalle = (List<Cotizaciones_Detalles>)DetalledataGridView.DataSource;
            }

            detalle.Add(
                new Cotizaciones_Detalles(
                    id: 0,
                    cotizacioId: (int)IdnumericUpDown.Value,
                    personaId: (int)PersonacomboBox.SelectedValue,
                    articuloId: (int)ArticulocomboBox.SelectedValue,
                    cantidad: (int)Convert.ToInt32(CantidadtextBox.Text),
                    precio: (int)Convert.ToInt32(PreciotextBox.Text),
                    importe: (int)Convert.ToInt32(ImportetextBox.Text)));

                    DetalledataGridView.DataSource = null;
                    DetalledataGridView.DataSource = detalle;
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(ObservacionestextBox.Text))
            {
                MyerrorProvider.SetError(ObservacionestextBox,
                    "No puedes dejar el Comentario vacio");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(CantidadtextBox.Text))
            {
                MyerrorProvider.SetError(ObservacionestextBox,
                    "Tienes que introducir una cantidad");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(PreciotextBox.Text))
            {
                MyerrorProvider.SetError(PreciotextBox,
                    "Tienes que introducir un precio");
                HayErrores = true;
            }

            if (String.IsNullOrWhiteSpace(ImportetextBox.Text))
            {
                MyerrorProvider.SetError(ImportetextBox,
                    "Tienes que introducir un importe");
                HayErrores = true;
            }

            return HayErrores;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;

            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private void LlenarCampos(Cotizaciones cotizacion)
        {
            IdnumericUpDown.Value = cotizacion.CotizacionId;
            fechaDateTimePicker.Value = cotizacion.Fecha;
            ObservacionestextBox.Text = cotizacion.Comentario;

            DetalledataGridView.DataSource = cotizacion.Detalle;

            DetalledataGridView.Columns["Id"].Visible = false;
            DetalledataGridView.Columns["CotizacionId"].Visible = false;
        }

    }
}
