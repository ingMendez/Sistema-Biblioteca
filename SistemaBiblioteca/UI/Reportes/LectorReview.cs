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
    public partial class LectorReview : Form
    {
        private List<Lector> lector = new List<Lector>();


        public LectorReview(List<Lector> Lista)
        {
            InitializeComponent();
            this.lector = Lista;
        }



        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            LectorReportes reportelector = new LectorReportes();
            reportelector.SetDataSource(lector);
            crystalReportViewer1.ReportSource = reportelector;
            reportelector.Refresh();
        }
    }
}
