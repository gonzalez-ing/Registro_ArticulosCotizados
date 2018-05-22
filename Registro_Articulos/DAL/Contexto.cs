using Registro_Articulos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Articulos.DAL
{
        public class Contexto : DbContext
        {
            public Contexto() : base("ConStr")
            {

            }

            public DbSet<Articulos> Articulo { get; set; }
        }
 }
