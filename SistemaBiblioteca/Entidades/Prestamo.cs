using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaBiblioteca.Entidades
{
   public  class Prestamo
    {
        [Key]
        public int PrestamoID { get; set; }
        public int LectorID { get; set; }
        public int LibroID { get; set; }
        public DateTime  Fecha { get; set; }
        public int Matricula { get; set; }
        public virtual List<PrestamoDetalle> Detalle { get; set; }

        public Prestamo()
        { 

            this.Detalle = new List<PrestamoDetalle>();

            PrestamoID = 0;
            LectorID = 0;
            LibroID = 0;
            Matricula = 0;
            Fecha = DateTime.Now;
        }
        public void AgregarDetalle(int id,int prestamoid,int lectorid,int libroID,int matricula)
        {
            this.Detalle.Add(new PrestamoDetalle(matricula,id, prestamoid,lectorid,libroID));
        }
        public override string ToString()
        {
            return PrestamoID.ToString();
        }
    }
}
