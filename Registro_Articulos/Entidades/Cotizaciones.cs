using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Articulos.Entidades
{
    public class Cotizaciones
    {

        [Key]
        public int CotizacionId { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentario { get; set; }
        public int Monto { get; set; }

        public virtual ICollection<Cotizaciones_Detalles> Detalle { get; set; }

        public Cotizaciones()
        {
            this.Detalle = new List<Cotizaciones_Detalles>();
        }

        public void AgregarDetalle(int id, int CotizacionId, int PersonaId, int ArticuloId, int Cantidad, int Precio, int Importe)
        {
            this.Detalle.Add(new Cotizaciones_Detalles(id, CotizacionId, PersonaId, ArticuloId, Cantidad, Precio, Importe));
        }
    }
}
