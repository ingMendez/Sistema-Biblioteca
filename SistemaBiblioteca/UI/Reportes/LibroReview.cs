﻿using SistemaBiblioteca.Entidades;
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
    public partial class LibroReview : Form
    {
        private List<Libros> Libro = new List<Libros>();
        public LibroReview(List<Libros>Lista)
        {
            InitializeComponent();
            this.Libro = Lista;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LibrosReportes libroReporte = new LibrosReportes();
            libroReporte.SetDataSource(Libro);
            crystalReportViewer1.ReportSource = libroReporte;
            libroReporte.Refresh();
        }
    }
}
