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
                        foreach (var item in prestamo.Detalle)
                        {
                            contexto.Libro.Find(item.LibroID).Disponibilidad =false;
                        }
                    contexto.SaveChanges();
                    paso = true;
                }
             }
            catch (Exception)
            {
                throw;
            }
            finally {

                contexto.Dispose();
            }
            return paso;
        }


        public static bool Modificar(Prestamo _prestamo)
        {

            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Prestamo.Add(_prestamo) != null)
                {
                    foreach (var item in _prestamo.Detalle)
                    {
                        contexto.Libro.Find(item.LibroID).Disponibilidad = false;
                    }
                    //  contexto.Entry(_prestamo).State = EntityState.Modified;
                    paso = (contexto.SaveChanges() > 0);
                    /*{
                        paso = true;
                    } */
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                contexto.Dispose();
            }
            return paso;/*bool paso = false;

            Contexto contexto = new Contexto();
            try
            {

                var anterior = contexto.Prestamo.Find(_prestamo.LibroID);
                foreach (var item in anterior.Detalle)
                {
                    if (!_prestamo.Detalle.Exists(d => d.ID == item.LibroID))
                    {
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }
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
            return paso;*/
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                //Prestamo _prestamo = contexto.Prestamo.Find(id);
                Prestamo prestamo = contexto.Prestamo.Find(id);

                foreach (var item in prestamo.Detalle)
                {
                    var eliminar = contexto.Prestamo.Find(id);

                    contexto.Libro.Find(item.LibroID).Disponibilidad = true;
                   // contexto.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;

                }
                //   contexto.Entry(eliminar).State = System.Data.Entity.EntityState.Deleted;
                contexto.Prestamo.Remove(prestamo);
                paso = (contexto.SaveChanges() > 0);
              
               
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
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
                // el Count() es para hacer al lazyloading cargar los detalles
                if (_prestamo == null)
                    return _prestamo;
                _prestamo.Detalle.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return _prestamo;
        }


        public static List<Prestamo> GetList(Expression<Func<Prestamo, bool>> expression)
        {
            List<Prestamo> Lista = new List<Prestamo>();
            Contexto contexto = new Contexto();

            try
            {
                Lista = contexto.Prestamo.Where(expression).ToList();
               // contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return Lista;
        }

       /* public static DateTime PorcientoGanancia(DateTime vencimiento)
        {
            DateTime final;

            final = vencimiento;


            return final;
        }*/

    }
}
