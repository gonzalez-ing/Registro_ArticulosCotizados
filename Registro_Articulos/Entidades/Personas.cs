using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Articulos.Entidades
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Personas()
        {

        }

        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
