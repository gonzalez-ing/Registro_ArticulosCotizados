using Microsoft.VisualStudio.TestTools.UnitTesting;
using Registro_Articulos.BLL;
using Registro_Articulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Articulos.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulos  = new Articulos();
            articulos.ArticuloId = 0;
            articulos.Cantidad = 0;
            articulos.Descripcion = "Mesa";
            articulos.Precio = 0;
            articulos.CantidadCotizada = 0;
            paso = ArticulosBLL.Guardar(articulos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Articulos articulos = new Articulos();
            articulos.ArticuloId = 1;
            articulos.Cantidad = 1;
            articulos.Descripcion = "Mesa";
            articulos.Precio = 1;
            articulos.CantidadCotizada = 1;
            paso = ArticulosBLL.Modificar(articulos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest1()
        {
            Assert.Fail();
        }
    }
}