using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SistemaBiblioteca.Entidades
{
    public class Administrador
    {
        [Key]
        public int AdministradorID { get; set; }

        public string Nombres { get; set; }

        public string NoTelefono { get; set; }

        public string Email { get; set; }

        public string Contraseña { get; set; }

        public DateTime FechaCreacion { get; set; }

        public Administrador()
        {
            AdministradorID = 0;
            Nombres = string.Empty;
            NoTelefono =string.Empty;
            Email = string.Empty;
            Contraseña = string.Empty;
            FechaCreacion = DateTime.Now;
        }
    }
}
