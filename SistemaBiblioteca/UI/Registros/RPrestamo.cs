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
         List<PrestamoDetalle> detalle;
        public RPrestamo()
        {
            InitializeComponent();
            LlenaCombox();
            CargarUsuario();
            detalle = new List<PrestamoDetalle>();
        }

       private void CargarUsuario()
        {
           /* UsuarioTextBox.DataBindings.Clear();
            var Usuario = UsuarioBLL.GetList(c => true);
            Binding doBinding = new Binding("Text", Usuario, "Nombres");
            UsuarioTextBox.DataBindings.Add(doBinding);*/
        }
        private void Limpiar()
        {
            SuperErrorProvider.Clear();
            LectorcomboBox.SelectedIndex = 0; 
            LibrocomboBox.SelectedIndex = 0;
            FechadateTimePicker.Value = DateTime.Now;
            PrestamoDetalleDataGridView = null;
       }

        private Prestamo LlenaCampo(Prestamo prestamo)
        {
            prestamoidnumericUpDown.Value = prestamo.PrestamoID;
            LectorcomboBox.SelectedValue = prestamo.LectorID;
            FechadateTimePicker.Value = prestamo.Fecha;

           // PrestamoDetalleDataGridView.DataSource = prestamo.Detalle;

            /*PrestamoDetalleDataGridView.Columns["Id"].Visible = false;
            PrestamoDetalleDataGridView.Columns["PrestamoID"].Visible = false;*/
            return prestamo;
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
                       ToInt(item.Cells["id"].Value),
                    ToInt(item.Cells["prestamoid"].Value),
                    ToInt(item.Cells["lectorid"].Value),
                    ToInt(item.Cells["libroid"].Value)

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
        private bool Validar()
        {
            bool Validar = false;

            if (PrestamoDetalleDataGridView.RowCount == 0)
            {
                SuperErrorProvider.SetError(PrestamoDetalleDataGridView,
                    "Debe Agregar los Productos ");
                Validar = true;
            }

            return Validar;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            Limpiar();
            
        }

        
        private void Llenarvalores()
        {
            List<PrestamoDetalle> detalle = new List<PrestamoDetalle>();

            if (PrestamoDetalleDataGridView.DataSource != null)
            {
                detalle = (List<PrestamoDetalle>)PrestamoDetalleDataGridView.DataSource;
            }
        }

        private void AgregarButtton_Click_1(object sender, EventArgs e)
        {


            // detalle = (List<PrestamoDetalle>)PrestamoDetalleDataGridView.DataSource;

            PrestamoDetalle pr = new PrestamoDetalle();

            pr.ID = 0;
            pr.PrestamoID = (int)prestamoidnumericUpDown.Value;
            pr.LectorID = (int)LectorcomboBox.SelectedValue;
            pr.LibroID = (int)LibrocomboBox.SelectedValue;
            if (detalle.Count == 0)
            {
                detalle.Add(pr);
             
            }
            else
            {
                if (!pr.Equals(detalle.FindAll(x => x.LibroID == pr.LibroID && x.LectorID == pr.LectorID)))
                {
                    detalle.Add(pr);
                }
                   

            }


            /*detalle.Add(
                    new PrestamoDetalle(
                       id: 0,
                       prestamoid: (int)prestamoidnumericUpDown.Value,
                       lectorid: (int)LectorcomboBox.SelectedValue,
                       libroid: (int)LibrocomboBox.SelectedValue
                       ));*/


      
            PrestamoDetalleDataGridView.DataSource = null;
                PrestamoDetalleDataGridView.DataSource = detalle;

            

        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (PrestamoDetalleDataGridView.Rows.Count > 0 && PrestamoDetalleDataGridView.CurrentRow != null)
            {
                List<PrestamoDetalle> detalle = (List<PrestamoDetalle>)PrestamoDetalleDataGridView.DataSource;

                detalle.RemoveAt(PrestamoDetalleDataGridView.CurrentRow.Index);

                PrestamoDetalleDataGridView.DataSource = null;
                PrestamoDetalleDataGridView.DataSource = detalle;

              
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Prestamo prestamo;
            bool Paso = false;

            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos!!", "Validación!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            prestamo = LlenaClase();

            if (prestamoidnumericUpDown.Value == 0)
            {
                Paso = PrestamoBLL.Guardar(prestamo);
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(prestamoidnumericUpDown.Value);
                Prestamo pres = PrestamoBLL.Buscar(id);

                if (pres != null)
                {
                    Paso = PrestamoBLL.Modificar(prestamo);
                    MessageBox.Show("Modificado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Paso)
            {
                NuevoButton.PerformClick();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(prestamoidnumericUpDown.Value);

            Prestamo prestamo = PrestamoBLL.Buscar(id);

            if (prestamo != null)
            {
                if (PrestamoBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(prestamoidnumericUpDown.Value);
            Prestamo prestamo = PrestamoBLL.Buscar(id);

            if (prestamo != null)
            {
                MessageBox.Show("Encontrado !!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(prestamo);
            }
            else
                MessageBox.Show("No se encontró!!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
