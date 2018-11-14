using SistemaBiblioteca.BLL;
using SistemaBiblioteca.DAL;
using SistemaBiblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaBiblioteca.UI.Registros
{
    public partial class RPrestamo : Form
    {
        public RPrestamo()
        {
            InitializeComponent();
            LlenaCombox();
        }

        private void LlenaCombox()
        {
            RepositorioBase<Lector> lectores = new RepositorioBase<Lector>(new Contexto());
            RepositorioBase<Libros> libro = new RepositorioBase<Libros>(new Contexto());

            LectorcomboBox.DataSource = lectores.GetList(c => true);
            LectorcomboBox.ValueMember = "LectorID";
            LectorcomboBox.DisplayMember = "Nombre";

            LibrocomboBox.DataSource = libro.GetList(c => true);
            LibrocomboBox.ValueMember = "LibroID";
            LibrocomboBox.DisplayMember = "NombreLibro";

        }

    }
}
