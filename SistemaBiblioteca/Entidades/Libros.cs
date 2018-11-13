using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaBiblioteca.Entidades
{
    public class Libros
    {
        [Key]
        public int LibroID { get; set; }
        public string NombreLibro { get; set; }
        public string ISBN{ get; set; }
        public string  Categoria { get; set; }
        public string Descripcion { get; set; }
        public string  NombreEditorial { get; set; }
        public DateTime FechaImpresion { get; set; }

        public Libros()
        {
            LibroID = 0;
            NombreLibro = "";
            ISBN = "";
            Categoria = " ";
            Descripcion = " ";
            NombreEditorial = "";
            FechaImpresion = DateTime.Now;

    }






}

}
