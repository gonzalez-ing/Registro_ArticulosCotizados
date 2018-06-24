using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Articulos.Entidades
{
    public class Cotizaciones_Detalles
    {
        [Key]
        public int Id { get; set; }
        public int CotizacionId { get; set; }
        public int PersonaId { get; set; }
        public int ArticuloId { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }

        [ForeignKey("ArticuloId")]
        public virtual Articulos Articulos { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Personas Personas { get; set; }

        public Cotizaciones_Detalles()
        {
            this.Id = 0;
            this.CotizacionId = 0;
            this.PersonaId = 0;
            this.ArticuloId = 0;
            this.Cantidad = 0;
            this.Precio = 0;
            this.Importe = 0;

        }

        public Cotizaciones_Detalles(int id, int cotizacioId, int personaId, int articuloId, int cantidad, int precio, int importe)
        {
            Id = id;
            CotizacionId = cotizacioId;
            PersonaId = personaId;
            ArticuloId = articuloId;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }
    }
}
