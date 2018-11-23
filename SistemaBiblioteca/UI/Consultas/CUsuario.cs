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

                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.UsuarioId == id;
                    break;
                case 2:// por nombre

                    filtro = a => a.Nombres.Contains(Criterio_textBox.Text);
                    break;

                ///FECHA          
                case 3:
                    filtro = a => a.FechaCreacion >= Desde_dateTimePicker.Value.Date && a.FechaCreacion <= Hasta_dateTimePicker.Value.Date;

                    break;
                case 4://Email

                    filtro = a => a.Email.Contains(Criterio_textBox.Text);
                    break;

            }
            Consulta_dataGridView.DataSource = BLL.UsuarioBLL.GetList(filtro);

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
    }
}
