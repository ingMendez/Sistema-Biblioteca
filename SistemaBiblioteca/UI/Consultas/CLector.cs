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
    public partial class CLector : Form
    {
        private List<Lector> lectores = new List<Lector>();
        public CLector()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Lector, bool>> filtro = a => true;
            int id;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0: /// todos

                    break;
                case 1:

                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.LectorID == id;
                    break;
                case 2:// por nombre

                    filtro = a => a.Nombre.Contains(Criterio_textBox.Text);
                    break;

                ///FECHA          
                case 3:
                    filtro = a => a.Fecha >= Desde_dateTimePicker.Value.Date && a.Fecha <= Hasta_dateTimePicker.Value.Date;

                    break;

            }
            Consulta_dataGridView.DataSource = lectores; 
               lectores =  BLL.LectorBLL.GetList(filtro);

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (lectores.Count == 0)
            {
                MessageBox.Show("No hay datos pra mostrar en el Reporte");
                return;
            }
            LectorReview lectorReview= new LectorReview(lectores);
            lectorReview.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Hasta_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Desde_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Criterio_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
