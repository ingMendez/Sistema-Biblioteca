using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaBiblioteca.Entidades
{
   public class TipoEditorial
    {
        [Key]
        public int EditarialID { get; set; }
        public string Nombre { get; set; }
        public string Dirrecion { get; set; }
        public TipoEditorial()
        {
            EditarialID = 0;
            Nombre = string.Empty;
            Dirrecion = string.Empty;
        }
    }
}
