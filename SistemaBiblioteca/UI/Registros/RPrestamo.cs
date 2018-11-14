using SistemaBiblioteca.BLL;
using SistemaBiblioteca.DAL;
using SistemaBiblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaBiblioteca.UI.Registros
{
    public partial class RPrestamo : Form
    {
        public RPrestamo()
        {
            InitializeComponent();
            LlenaCombox();
            CargarUsuario();
        }

        private void CargarUsuario()
        {
            UsuarioTextBox.DataBindings.Clear();
            var Usuario = UsuarioBLL.GetList(c => true);
            Binding doBinding = new Binding("Text", Usuario, "Nombres");
            UsuarioTextBox.DataBindings.Add(doBinding);
        }

        private void LlenaCampo(Prestamo prestamo)
        {
            prestamoidnumericUpDown.Value = prestamo.PrestamoID;
            LectorcomboBox.SelectedValue = prestamo.LectorID;
            FechadateTimePicker.Value = prestamo.Fecha;

            PrestamoDetalleDataGridView.DataSource = prestamo.Detalle;

            PrestamoDetalleDataGridView.Columns["Id"].Visible = false;
            PrestamoDetalleDataGridView.Columns["PrestamoID"].Visible = false;
        }

        private Prestamo LlenaClase()
        {
            Prestamo prestamo = new Prestamo
            {
                PrestamoID = Convert.ToInt32(prestamoidnumericUpDown.Value),
                LectorID = Convert.ToInt32(LectorcomboBox.SelectedValue),
                Fecha = FechadateTimePicker.Value
            };

            foreach (DataGridViewRow item in PrestamoDetalleDataGridView.Rows)
            {
                prestamo.AgregarDetalle(
                       ToInt(item.Cells["ID"].Value),
                    ToInt(item.Cells["PrestamoID"].Value),
                    ToInt(item.Cells["LectorID"].Value),
                    ToInt(item.Cells["LibroID"].Value)

                    );

            }
            return prestamo;

        }
        private int ToInt(object valor)
        {
            int.TryParse(valor.ToString(), out int retorno);

            return retorno;
        }



        private void LlenaCombox()
        {
            RepositorioBase<Lector> lectores = new RepositorioBase<Lector>(new Contexto());
            RepositorioBase<Libros> libro = new RepositorioBase<Libros>(new Contexto());

            LectorcomboBox.DataSource = lectores.GetList(c => true);
            LectorcomboBox.ValueMember = "LectorID";
            LectorcomboBox.DisplayMember = "Nombre";

            LibrocomboBox.DataSource = libro.GetList(c => true);
            LibrocomboBox.ValueMember = "LibroID";
            LibrocomboBox.DisplayMember = "NombreLibro";

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
