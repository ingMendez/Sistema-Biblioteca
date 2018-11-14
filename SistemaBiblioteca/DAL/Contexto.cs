using SistemaBiblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SistemaBiblioteca.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Lector> Lectores { get; set; }
        public DbSet<Libros> Libro { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
        public DbSet<TipoEditorial> Editorial { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Categoria> categorias { get; set; }
        

        public Contexto() : base("ConStr")
        {
            
        }
    }
}
