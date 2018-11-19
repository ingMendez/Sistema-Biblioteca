using SistemaBiblioteca.BLL;
using SistemaBiblioteca.DAL;
using SistemaBiblioteca.Entidades;
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
        public CPrestamo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Prestamo>(new Contexto());
            Expression<Func<Prestamo, bool>> filtro = a => true;
            int id;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0: /// todos
                    break;
                case 1://id

                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.LibroID == id;
                    break;
                case 2:// por nombre
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.LibroID == id;
                    break;

                ///FECHA          
               
                  

                   


            }
            filtro = a => a.Fecha >= Desde_dateTimePicker.Value.Date && a.Fecha <= Hasta_dateTimePicker.Value.Date;
            ConsultadataGridView.DataSource = repositorio.GetList(filtro);

        }

        private void HastadateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
