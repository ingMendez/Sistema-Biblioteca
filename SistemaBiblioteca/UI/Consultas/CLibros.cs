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

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
         
      

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Libros, bool>> filtro = a => true;
            int id;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0: /// todos
                    break;
                case 1:

                   
                    id = Convert.ToInt32(ConsultanumericUpDown.Value);
                    
                    filtro = a => a.LibroID == id;
                    break;
                case 2:// por nombre

                    filtro = a => a.NombreLibro.Contains(Criterio_textBox.Text);
                    break;

                ///FECHA          
                case 3:
                    filtro = a => a.FechaImpresion >= Desde_dateTimePicker.Value.Date && a.FechaImpresion <= Hasta_dateTimePicker.Value.Date;

                    break;
                case 4:// por ISBN

                    filtro = a => a.ISBN.Contains(Criterio_textBox.Text);
                    break;
                case 5:// por CATEGORIA
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.CategoriaID == id;
                    break;

            }
            Consulta_dataGridView.DataSource = BLL.LibroBLL.GetList(filtro);
        
            Consulta_dataGridView.Columns[0].Visible= false;
            Consulta_dataGridView.Columns[7].Visible = false;
            Consulta_dataGridView.Columns[3].Visible = false;
            Consulta_dataGridView.Columns[5].Visible = false;


            //  Consulta_dataGridView.DataSource;
            // Consulta_dataGridView.Rows.Add(ID, textBoxNombre.Text, textBoxCantidad.Text, textBoxStock.Text, textBoxPrecio.Text, subTotal);
        }

        private void Criterio_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filtro_comboBox.SelectedIndex == 0)/// en caso de imprimir por todo 
            {
                Criterio_textBox.Visible = false;
                label2.Visible = false;
            }
           if(Filtro_comboBox.SelectedIndex == 1)
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
      
            



        }
       /* private void Criterio()
        {
           // object sender;
            KeyPressEventArgs e;

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se puede digitar Números", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }
}
