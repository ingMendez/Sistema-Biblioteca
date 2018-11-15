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
    public partial class CLibros : Form
    {
        public CLibros()
        {
            InitializeComponent();
        }

        private void ConsultacomboBox_SelectedIndexChanged(object sender, EventArgs e)

        {

            Expression<Func<Libros, bool>> filtro = a => true;
            int id;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0: /// todos
                    break;
                case 1:

                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.LibroID == id;
                    break;
                case 2:// por nombre

                    filtro = a => a.NombreLibro.Contains(Criterio_textBox.Text);
                    break;

                ///FECHA          
                case 3:
                    filtro = a => a.FechaImpresion >= Desde_dateTimePicker.Value.Date && a.FechaImpresion <= Hasta_dateTimePicker.Value.Date;

                    break;
                case 4:// por nombre

                    filtro = a => a.ISBN.Contains(Criterio_textBox.Text);
                    break;
                case 5:// por nombre
                        id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.CategoriaID == id;
                    break;

            }
            Consulta_dataGridView.DataSource = BLL.LibroBLL.GetList(filtro);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      

        private void Consultarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
