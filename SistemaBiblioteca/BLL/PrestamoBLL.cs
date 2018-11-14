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
   public class PrestamoBLL
    {
        public static bool Guardar(Prestamo prestamo)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Prestamo.Add(prestamo) != null)
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


        public static bool Modificar(Prestamo _prestamo)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(_prestamo).State = EntityState.Modified;
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
                Prestamo _prestamo = contexto.Prestamo.Find(id);

                contexto.Prestamo.Remove(_prestamo);

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


        public static Prestamo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Prestamo _prestamo = new Prestamo();
            try
            {
                _prestamo = contexto.Prestamo.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return _prestamo;
        }


        public static List<Prestamo> GetList(Expression<Func<Prestamo, bool>> expression)
        {
            List<Prestamo> _prestamo = new List<Prestamo>();
            Contexto contexto = new Contexto();

            try
            {
                _prestamo = contexto.Prestamo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return _prestamo;
        }

       /* public static DateTime PorcientoGanancia(DateTime vencimiento)
        {
            DateTime final;

            final = vencimiento;


            return final;
        }*/

    }
}
