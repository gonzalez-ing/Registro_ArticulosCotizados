using Registro_Articulos.DAL;
using Registro_Articulos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Articulos.BLL
{
    public class ArticulosBLL
    {
        public static bool Guardar(Articulos articulos)
        {
            bool paso = false;
            //Creamos una instancia del contexto para poder conectar con la BD
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Articulo.Add(articulos) != null)
                {
                    contexto.SaveChanges(); //Guardar los cambios
                    paso = true;
                }

                contexto.Dispose();//siempre hay que cerrar la conexion
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        /// <summary>
        /// Permite Modificar una entidad en la base de datos 
        /// <returns>Retorna True si Modifico o Falso si falló </returns>
        public static bool Modificar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        /// <summary>
        /// Permite Eliminar una entidad en la base de datos
        /// <returns>Retorna True si Eliminó o Falso si falló </returns>
        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Articulos articulos = contexto.Articulo.Find(id);

                contexto.Articulo.Remove(articulos);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        /// <summary>
        /// Permite Buscar una entidad en la base de datos
        /// </summary>
        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulos = new Articulos();
            try
            {
                articulos = contexto.Articulo.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return articulos;
        }

        /// <summary>
        /// Permite extraer una lista de Personas de la base de datos
        /// </summary> 
        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> Articulos = new List<Articulos>();
            Contexto contexto = new Contexto();
            try
            {
                Articulos = contexto.Articulo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return Articulos;
        }
    }
}
