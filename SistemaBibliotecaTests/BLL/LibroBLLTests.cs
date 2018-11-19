using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaBiblioteca.BLL;
using SistemaBiblioteca.DAL;
using SistemaBiblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SistemaBiblioteca.BLL.Tests
{
    [TestClass()]
    public class LibroBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Libros libro = new Libros();
            libro.LibroID =2;
            libro.NombreLibro = "historia";
            libro.ISBN = "sd342";
            libro.CategoriaID = 3;
            libro.Descripcion = "funcionar";
            libro.EditarialID = 2;
            libro.FechaImpresion = DateTime.Now;
            libro.Disponibilidad = true;
            paso = LibroBLL.Guardar(libro);
            Assert.AreEqual(paso, true);


        }

        [TestMethod()]
        public void ModificarTest()
        {

              Libros libro = new Libros();
           // int Idlibro = LibroBLL.GetList(x => true)[0].LibroID;
          //  Libros libro = LibroBLL.Buscar(Idlibro);
            libro.LibroID = 4;
            libro.NombreLibro = "naturaless";
            libro.ISBN = "sd342";
            libro.CategoriaID = 3;
            libro.Descripcion = "loverrrss";
            libro.EditarialID = 2;
            libro.FechaImpresion = DateTime.Now;
           // libro.Disponibilidad = false;
           bool paso = LibroBLL.Modificar(libro);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 4;
            bool paso;
            paso = LibroBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Libros libro = new Libros();
            int id = 1;
            libro = LibroBLL.Buscar(id);
            Assert.IsNotNull(libro);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Libros,bool>>expression)
        {
            Contexto contexto = new Contexto();
            List<Libros> listaLibros = new List<Libros>();
            listaLibros = contexto.Libro.Where(expression).ToList();
            Assert.IsNotNull(listaLibros);
        }

      /*  [TestMethod()]
        public void PorcientoGananciaTest()
        {
            Assert.Fail();
        }*/
    }
}