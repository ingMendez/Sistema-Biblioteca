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
    public partial class UsuarioReview : Form
    {
        private List<Usuario> usuario = new List<Usuario>();

        public UsuarioReview(List<Usuario> Lista)
        {
            InitializeComponent();
            this.usuario = Lista;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            UsuarioReportes usuario = new UsuarioReportes();
            usuario.SetDataSource(usuario);
            crystalReportViewer1.ReportSource = usuario;
            usuario.Refresh();
        }
    }
}
