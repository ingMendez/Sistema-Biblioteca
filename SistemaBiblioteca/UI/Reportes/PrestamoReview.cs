using SistemaBiblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaBiblioteca.UI.Reportes
{
    public partial class PrestamoReview : Form
    {
        private List<Prestamo> prestamo = new List<Prestamo>();

        public PrestamoReview(List<Prestamo>Lista)
        {
            InitializeComponent();
            this.prestamo = Lista;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
