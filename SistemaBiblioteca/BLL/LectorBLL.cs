﻿using SistemaBiblioteca.DAL;
using SistemaBiblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SistemaBiblioteca.BLL
{
   public class LectorBLL
    {
        public static bool Guardar(Lector Lectores)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Lectores.Add(Lectores) != null)
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


        public static bool Modificar(Lector lectores)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(lectores).State = EntityState.Modified;
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
                Lector lectore = contexto.Lectores.Find(id);

                contexto.Lectores.Remove(lectore);

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


        public static Lector Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Lector lector = new Lector();
            try
            {
                lector = contexto.Lectores.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return lector;
        }


        public static List<Lector> GetList(Expression<Func<Lector, bool>> expression)
        {
            List<Lector> lector = new List<Lector>();
            Contexto contexto = new Contexto();

            try
            {
                lector = contexto.Lectores.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return lector;
        }


    }
}

