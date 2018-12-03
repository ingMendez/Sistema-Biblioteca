using SistemaBiblioteca.UI.Consultas;
using SistemaBiblioteca.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/// <summary>
/// /https://github.com/ingMendez/Sistema-Biblioteca.git
/// </summary>
namespace SistemaBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegistrarLectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RLector rlector = new RLector();
            rlector.MdiParent = this;
            rlector.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //registrarUsuarioToolStripMenuItem.Visible = Program.usuario.pocision;
        }

        private void RegistrarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RLibros rlibros = new RLibros();
            rlibros.MdiParent = this;
            rlibros.Show();
        }

        private void RegistrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCategoria rcategoria = new RCategoria();
            rcategoria.MdiParent = this;
            rcategoria.Show();
        }

        private void RegistrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RUsuario rUsuario = new RUsuario();
            rUsuario.MdiParent = this;
            rUsuario.Show();
        }

       public void Activos()
        {
            registrarCategoriaToolStripMenuItem.Enabled = true;
            registrarLectorToolStripMenuItem.Enabled = true;
            registrarLibroToolStripMenuItem.Enabled = true;
            registrarUsuarioToolStripMenuItem.Enabled = true;

        }
        public void Loo()
        {
            RLogin log = new RLogin();
            log.MdiParent = this;
            log.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RLogin log = new RLogin();
            log.ShowDialog();
        }

        private void RegistrarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPrestamo prestamo = new RPrestamo();
            prestamo.MdiParent = this;
            prestamo.Show();
          
        }

        private void ConsultarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLibros Clibros = new CLibros();
            Clibros.MdiParent = this;
            Clibros.Show();
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CUsuario CUsuario = new CUsuario();
            CUsuario.MdiParent = this;
            CUsuario.Show();
        }

        private void ConsultarPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPrestamo cPrestamo = new CPrestamo();
            cPrestamo.MdiParent = this;
            cPrestamo.Show();
        }

        private void consultarLectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLector lector = new CLector();
            lector.MdiParent = this;
            lector.Show();
        }
    }
}
