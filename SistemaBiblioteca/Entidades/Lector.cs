using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaBiblioteca.Entidades
{
   public class Lector
    {
        [Key]
        public int LectorID { get; set; }
        public string Nombre { get; set; }
        public string  Apellido { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
    
        public Lector()
        {
            LectorID = 0;
            Nombre =string.Empty;
            Apellido = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Fecha = DateTime.Now;
        }


    }
}
