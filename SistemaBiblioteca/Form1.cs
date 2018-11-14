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

        private void registrarLectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RLector rlector = new RLector();
            rlector.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RLibros rlibros = new RLibros();
            rlibros.ShowDialog();
        }

        private void registrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCategoria rcategoria = new RCategoria();
            rcategoria.ShowDialog();
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RUsuario rUsuario = new RUsuario();
            rUsuario.ShowDialog();
        }
    }
}
