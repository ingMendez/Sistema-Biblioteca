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
            rlector.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RLibros rlibros = new RLibros();
            rlibros.ShowDialog();
            rlibros.MdiParent = this;
        }

        private void RegistrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCategoria rcategoria = new RCategoria();
            rcategoria.ShowDialog();
        }

        private void RegistrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RUsuario rUsuario = new RUsuario();
            rUsuario.ShowDialog();
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
            log.ShowDialog();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RLogin log = new RLogin();
            log.ShowDialog();
        }

        private void RegistrarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPrestamo prestamo = new RPrestamo();
            prestamo.ShowDialog();
        }

        private void ConsultarLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CLibros Clibros = new CLibros();
            Clibros.Show();
            Clibros.MdiParent = this;
        }

        private void consultarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CUsuario CUsuario = new CUsuario();
            CUsuario.Show();
            CUsuario.MdiParent = this;
        }

        private void ConsultarPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPrestamo cPrestamo = new CPrestamo();
            cPrestamo.Show();
            cPrestamo.MdiParent = this;
        }
    }
}
