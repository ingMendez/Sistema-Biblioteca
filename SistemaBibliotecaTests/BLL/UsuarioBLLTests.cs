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
    public class UsuarioBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Usuario usuario = new Usuario();
            usuario.UsuarioId = 3;
            usuario.Nombres = "historia";
            usuario.NoTelefono = "sd342";
            usuario.Email = "dfdfdfdfdf";
            usuario.Contraseña = "funcionar";
            usuario.FechaCreacion = DateTime.Now;
                      
            paso = UsuarioBLL.Guardar(usuario);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Usuario usuario = new Usuario();
            usuario.UsuarioId = 1;
            usuario.Nombres = "histssdsdoria";
            usuario.NoTelefono = "sd342";
            usuario.Email = "dfdfdsdsdsdsfdfdf";
            usuario.Contraseña = "funcionar";
            usuario.FechaCreacion = DateTime.Now;

            paso = UsuarioBLL.Modificar(usuario);
            Assert.AreEqual(paso, true);
            ;
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 1;
            bool paso;
            paso = UsuarioBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Usuario usuario = new Usuario();
            int id = 2;
            usuario = UsuarioBLL.Buscar(id);
            Assert.IsNotNull(usuario);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Usuario, bool>> expression)
        {
            
            
                Contexto contexto = new Contexto();
            List<Usuario> listaLibros = new List<Usuario>();
            listaLibros = contexto.Usuario.Where(expression).ToList();
            Assert.IsNotNull(listaLibros);

        }
    }
}