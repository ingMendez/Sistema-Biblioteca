using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaBiblioteca.Entidades
{
  public  class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }
        public string descripcion { get; set; }
        public Categoria()
        {
            CategoriaID = 0;
            Nombre = string.Empty;
            descripcion = string.Empty;
        }
    }
}
