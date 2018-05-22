﻿using Registro_Articulos.BLL;
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
    public partial class ConsultarArticulos : Form
    {
        public ConsultarArticulos()
        {
            InitializeComponent();
        }

        private void BuscarFiltrobutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Articulos, bool>> filter = x => 1 == 1;
            switch (FiltrarcomboBox.SelectedIndex)
            {
                case 0://ArticuloId
                    int id = int.Parse(FiltrartextBox.Text);
                    filter = x => x.ArticuloId == id;
                    break;

                case 1://Descripcion
                    filter = x => x.Descripcion.Contains(FiltrartextBox.Text);
                    break;

                case 2://Precio
                    Decimal precio = Decimal.Parse(FiltrartextBox.Text);
                    filter = x => x.Precio >= precio;
                    break;
            }

            ConsultadataGridView.DataSource = ArticulosBLL.GetList(filter);
        }

        private void ConsultarArticulos_Load(object sender, EventArgs e)
        {

        }
    }
}
