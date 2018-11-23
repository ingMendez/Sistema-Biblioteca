using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SistemaBiblioteca.Entidades
{
    public class PrestamoDetalle
    {
        [Key]
        public int ID { get; set; }
        public int PrestamoID { get; set; }
        public int LectorID { get; set; }
        public int LibroID { get; set; }
        Libros libro = new Libros();
       /* [/ForeignKey("PretamoID")]
        public virtual Prestamo _pretamo { get; set; }*/

        [ForeignKey("LibroID")]
        public virtual Libros Libro { get; set; }


        public PrestamoDetalle()
        {
            ID = 0;
            PrestamoID = 0;
            LectorID = 0;
            LibroID = 0;

        }

        public PrestamoDetalle(int id,int prestamoid,int lectorid,string nombre)
        {
            ID = id;
            PrestamoID = PrestamoID;
            LectorID = lectorid;
            libro.NombreLibro = nombre;
        }

    }
}
