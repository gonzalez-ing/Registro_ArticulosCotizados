using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Articulos.Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int CantidadCotizada { get; set; }

        public Articulos(int articuloId, DateTime fecha, string descripcion, Decimal precio, int cantidad, int cantidadCotizada)
        {
            ArticuloId = articuloId;
            fecha = Fecha;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad = cantidad;
            CantidadCotizada = cantidadCotizada;
        }

        public Articulos()
        {
            this.ArticuloId = 0;
            Fecha = DateTime.Now;
            this.Descripcion = string.Empty;
            this.Precio = 0;
            Cantidad = 0;
            CantidadCotizada = 0;
        }
    }
}

