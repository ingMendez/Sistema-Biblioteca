using SistemaBiblioteca.DAL;
using SistemaBiblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SistemaBiblioteca.BLL
{
        public class UsuarioBLL
        {
            public static bool Guardar(Usuario usuario)
            {
                bool paso = false;

                Contexto contexto = new Contexto();
                try
                {
                    if (contexto.Usuario.Add(usuario) != null)
                    {
                        contexto.SaveChanges();
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


            public static bool Modificar(Usuario usuario)
            {
                bool paso = false;

                Contexto contexto = new Contexto();
                try
                {
                    contexto.Entry(usuario).State = EntityState.Modified;
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


            public static bool Eliminar(int id)
            {
                bool paso = false;

                Contexto contexto = new Contexto();
                try
                {
                    Usuario usuario = contexto.Usuario.Find(id);

                    contexto.Usuario.Remove(usuario);

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


            public static Usuario Buscar(int id)
            {
                Contexto contexto = new Contexto();
                Usuario usuario = new Usuario();
                try
                {
                    usuario = contexto.Usuario.Find(id);
                    contexto.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return usuario;
            }


            public static List<Usuario> GetList(Expression<Func<Usuario, bool>> expression)
            {
                List<Usuario> usuarios = new List<Usuario>();
                Contexto contexto = new Contexto();

                try
                {
                    usuarios = contexto.Usuario.Where(expression).ToList();
                    contexto.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }

                return usuarios;
            }
       
    }
}
