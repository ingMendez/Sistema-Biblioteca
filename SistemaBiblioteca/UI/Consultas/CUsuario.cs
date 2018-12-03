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
    public partial class CUsuario : Form
    {
        private List<Usuario> usuario = new List<Usuario>();

        public CUsuario()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuario, bool>> filtro = a => true;
            int id;
            switch (Filtro_comboBox.SelectedIndex)
            {
                case 0: /// todos
                    break;
                case 1:

                    id = Convert.ToInt32(ConsultanumericUpDown.Value);
                    filtro = a => a.UsuarioId == id;
                    break;
                case 2:// por nombre

                    filtro = a => a.Nombres.Contains(Criterio_textBox.Text);
                    break;
                case 3://Email

                    filtro = a => a.Email.Contains(Criterio_textBox.Text);
                    break;
                case 4://Fecha
                    filtro = a => a.FechaCreacion >= Desde_dateTimePicker.Value.Date && a.FechaCreacion <= Hasta_dateTimePicker.Value.Date;
                    break;

            }
            /*Lista = repositorio.GetList(p => true);
            prestamo = repositorio.GetList(filtro);
            filtro = a => a.Fecha >= Desde_dateTimePicker.Value.Date && a.Fecha <= Hasta_dateTimePicker.Value.Date;
            ConsultadataGridView.DataSource = prestamo;// repositorio.GetList(filtro);
*/
            usuario = BLL.UsuarioBLL.GetList(filtro);
            Consulta_dataGridView.DataSource = null;
            Consulta_dataGridView.DataSource = usuario;
            filtro = a => a.FechaCreacion >= Desde_dateTimePicker.Value.Date && a.FechaCreacion <= Hasta_dateTimePicker.Value.Date;
            Consulta_dataGridView.DataSource = usuario;

          //  Consulta_dataGridView.DataSource = BLL.UsuarioBLL.GetList(filtro);

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (usuario.Count == 0)
            {
                MessageBox.Show("No hay datos pra mostrar en el Reporte");
                return;
            }
            UsuarioReview lectorReview = new UsuarioReview(usuario);
            lectorReview.ShowDialog();
        }

        private void CUsuario_Load(object sender, EventArgs e)
        {

        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filtro_comboBox.SelectedIndex == 1)
            {
                Criterio_textBox.Visible = false;
                ConsultanumericUpDown.Visible = true;
               //// label3.Visible = false;
               /// label4.Visible = false;
               // label5.Visible = false;

                Hasta_dateTimePicker.Visible = true;
                Desde_dateTimePicker.Visible = true;

                Criterio_textBox.Visible = true;
              //  label2.Visible = true;
                // Criterio();
                //Criterio_textBox = .Criterio_textBox();

            }
            if (Filtro_comboBox.SelectedIndex == 2)
            {
                Criterio_textBox.Visible = true;
                ConsultanumericUpDown.Visible = false;
               // label3.Visible = false;
               // label4.Visible = false;
               // label5.Visible = false;

                Hasta_dateTimePicker.Visible = true;
                Desde_dateTimePicker.Visible = true;

                Criterio_textBox.Visible = true;
                label2.Visible = true;
                // Criterio();
                //Criterio_textBox = .Criterio_textBox();

            }

        }
    }
}
