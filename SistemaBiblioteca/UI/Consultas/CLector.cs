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
                case 1:// por id
                    id = Convert.ToInt32(ConsultanumericUpDown.Value);
                    filtro = a => a.LectorID == id;
                    break;
                case 2:// por nombre
                    id = Convert.ToInt32(ConsultanumericUpDown.Value);
                      filtro = a =>a.Nombre.Length == id;
                    break;
                ///FECHA          
                case 3:
                    filtro = a => a.Fecha >= Desde_dateTimePicker.Value.Date && a.Fecha <= Hasta_dateTimePicker.Value.Date;

                    break;

            }

            lectores = BLL.LectorBLL.GetList(filtro);
            Consulta_dataGridView.DataSource = lectores;
            Consulta_dataGridView.ReadOnly = true;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (lectores.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar en el Reporte");
                return;
            }
            LectorReview lectorReview= new LectorReview(lectores);
            lectorReview.ShowDialog();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Hasta_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Desde_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Criterio_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filtro_comboBox.SelectedIndex == 0)/// en caso de imprimir por todo 
            {
                Criterio_textBox.Visible = false;
                label2.Visible = false;
                ConsultanumericUpDown.Visible = false;
            }
            if (Filtro_comboBox.SelectedIndex == 1)
            {
                Criterio_textBox.Visible = false;
                ConsultanumericUpDown.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;

                Hasta_dateTimePicker.Visible = false;
                Desde_dateTimePicker.Visible = false;

                Criterio_textBox.Visible = true;
                label2.Visible = true;
                // Criterio();
                //Criterio_textBox = .Criterio_textBox();

            }
            if (Filtro_comboBox.SelectedIndex == 2)
            {
                Criterio_textBox.Visible = true;
                ConsultanumericUpDown.Visible = false;

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

                Hasta_dateTimePicker.Visible = true;
                Desde_dateTimePicker.Visible = true;

                Criterio_textBox.Visible = true;
                label2.Visible = true;
                // Criterio();
                //Criterio_textBox = .Criterio_textBox();

            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
