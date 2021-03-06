﻿using SistemaBiblioteca.BLL;
using SistemaBiblioteca.DAL;
using SistemaBiblioteca.Entidades;
using SistemaBiblioteca.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace SistemaBiblioteca.UI.Consultas
{
    public partial class CPrestamo : Form
    {
        private RepositorioBase<Prestamo> repositorio;
        private List<Prestamo> prestamo = new List<Prestamo>();
        public CPrestamo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Expression<Func<Prestamo, bool>> filtro = a => true;
            int id;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0: /// todos
                    break;
                case 1:

                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.PrestamoID == id;
                    break;
                case 2://lector
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.LectorID == id;
                    // filtro = a => a.Email.Contains(Criterio_textBox.Text);

                    break;
                case 3://matriula
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.Matricula == id;
                    // filtro = a => a.Matricula.Contains(Criterio_textBox.Text);

                    break;

                case 4://Fecha
                    filtro = a => a.Fecha >= Desde_dateTimePicker.Value.Date && a.Fecha <= Hasta_dateTimePicker.Value.Date;
                    break;

            }
            /*Lista = repositorio.GetList(p => true);
            prestamo = repositorio.GetList(filtro);
            filtro = a => a.Fecha >= Desde_dateTimePicker.Value.Date && a.Fecha <= Hasta_dateTimePicker.Value.Date;
            ConsultadataGridView.DataSource = prestamo;// repositorio.GetList(filtro);
*/
            prestamo = BLL.PrestamoBLL.GetList(filtro);
            ConsultadataGridView.DataSource = null;
           // ConsultadataGridView.DataSource = prestamo;
            filtro = a => a.Fecha >= Desde_dateTimePicker.Value.Date && a.Fecha <= Hasta_dateTimePicker.Value.Date;
            ConsultadataGridView.DataSource = prestamo;

            //  Consulta_dataGridView.DataSource = BLL.UsuarioBLL.GetList(filtro);

        }

        private void ConsultacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Prestamo>(new Contexto());
            var Lista = new List<Prestamo>(); 
            Expression<Func<Prestamo, bool>> filtro = a => true;
            int id;
            if(Criterio_textBox.Text.Trim().Length > 0)
            {
                switch (Filtro_comboBox.SelectedIndex)
                {
                    case 0: /// todos
                        Lista = repositorio.GetList(p => true);
                        break;
                    case 1://id

                        id = Convert.ToInt32(Criterio_textBox.Text);
                        repositorio.GetList(p => p.PrestamoID.Equals(filtro));
                        //    filtro = a => a.LibroID == id;


                        break;
                    case 2:// por nombre
                        id = Convert.ToInt32(Criterio_textBox.Text);
                        filtro = a => a.LibroID == id;
                        break;
                    case 3:
                        id = Convert.ToInt32(Criterio_textBox.Text);
                        filtro = a => a.LectorID == id;
                        break;
                    case 4:
                        filtro = a => a.Fecha >= Desde_dateTimePicker.Value.Date && a.Fecha <= Hasta_dateTimePicker.Value.Date;
                        break;

                        ///FECHA          



                }


            }
            Lista = repositorio.GetList(p => true);
            prestamo = repositorio.GetList(filtro);
            filtro = a => a.Fecha >= Desde_dateTimePicker.Value.Date && a.Fecha <= Hasta_dateTimePicker.Value.Date;
            ConsultadataGridView.DataSource = prestamo;// repositorio.GetList(filtro);

        }

        private void HastadateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

            if(prestamo.Count == 0)
            {
                MessageBox.Show("No hay datos para presentar");
                return;
            }
           // PrestamoReporte reporte = new PrestamoReporte();
            PrestamoReview prestamoReview = new PrestamoReview(prestamo);
            prestamoReview.ShowDialog();

        }

        private void CPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
}
