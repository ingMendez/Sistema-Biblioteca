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
   public  class LibroBLL
    {
        public static bool Guardar(Libros libro)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Libro.Add(libro) != null)
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


        public static bool Modificar(Libros libro)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(libro).State = EntityState.Modified;
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
                Libros libro = contexto.Libro.Find(id);

                contexto.Libro.Remove(libro);

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


        public static Libros Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Libros libros = new Libros();
            try
            {
                libros = contexto.Libro.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return libros;
        }


        public static List<Libros> GetList(Expression<Func<Libros, bool>> expression)
        {
            List<Libros> libro = new List<Libros>();
            Contexto contexto = new Contexto();

            try
            {
                libro = contexto.Libro.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return libro;
        }

        public static DateTime PorcientoGanancia(DateTime vencimiento)
        {
            DateTime final;

            final = vencimiento ;


            return final;
        }

    }
}
