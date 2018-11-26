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
      public List<PrestamoDetalle> Detalle { get; set; }
        public RPrestamo()
        {
            InitializeComponent();
            LlenaCombox();
            CargarUsuario();
            this.Detalle = new List<PrestamoDetalle>();
            LibrocomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LectorcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }

       private void CargarUsuario()
        {
            UsuarioTextBox.Enabled = false;
            UsuarioTextBox.DataBindings.Clear();
            var Usuario = UsuarioBLL.GetList(c => true);
            Binding doBinding = new Binding("Text", Usuario, "Nombres");
            UsuarioTextBox.DataBindings.Add(doBinding);
        }
        private void Limpiar()
        {
            SuperErrorProvider.Clear();
            LectorcomboBox.SelectedIndex = 0; 
            LibrocomboBox.SelectedIndex = -1;
            FechadateTimePicker.Value = DateTime.Now.Date;
            MatriculatextBox.Text = string.Empty;
            PrestamoDetalleDataGridView.DataSource = null;
            this.Detalle = new List<PrestamoDetalle>();
            CargarGrid();
        }

        private void LlenaCampo(Prestamo prestamo)
        {
        
            prestamoidnumericUpDown.Value = prestamo.PrestamoID;
            LectorcomboBox.SelectedValue = prestamo.LectorID;
            FechadateTimePicker.Value = prestamo.Fecha;
            MatriculatextBox.Text = prestamo.Matricula.ToString();
            this.Detalle = prestamo.Detalle;
            CargarGrid();
           // PrestamoDetalleDataGridView.DataSource = null;
           // PrestamoDetalleDataGridView.DataSource = prestamo.Detalle;
            
           /*PrestamoDetalleDataGridView.Columns["id"].Visible = false;
             PrestamoDetalleDataGridView.Columns["Prestmoid"].Visible = false;*/
            
        }

       /* private void visibilidad()
        {
            PrestamoDetalleDataGridView.Columns["id"].Visible = false;
            PrestamoDetalleDataGridView.Columns["Prestamoid"].Visible = false;
        }*/
        private Prestamo LlenaClase()
        {
            Prestamo prestamo = new Prestamo
            {
                PrestamoID = Convert.ToInt32(prestamoidnumericUpDown.Value),
                LectorID = Convert.ToInt32(LectorcomboBox.SelectedValue),
                Fecha = FechadateTimePicker.Value,
                Matricula = Convert.ToInt32(MatriculatextBox.Text)
            };

            foreach (DataGridViewRow item in PrestamoDetalleDataGridView.Rows)
              {
                  prestamo.AgregarDetalle(
                         ToInt(item.Cells["id"].Value),
                      ToInt(item.Cells["prestamoid"].Value),
                      ToInt(item.Cells["matricula"].Value),
                      ToInt(item.Cells["libroId"].Value),
                      ToInt(item.Cells["lectorid"].Value)
                    //   item.Cells["fecha"]
                    //  id, prestamoid, lectorid, libroId
                      );

              }
            prestamo.Detalle = this.Detalle;

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

            LibrocomboBox.DataSource = libro.GetList(c=> c.Disponibilidad ==true);
            LibrocomboBox.ValueMember = "LibroID";
            LibrocomboBox.DisplayMember = "NombreLibro";
            


        }
        private bool Validar()
        {
            bool Validar = false;

           /* if (PrestamoDetalleDataGridView.RowCount == 0)
            {
                SuperErrorProvider.SetError(PrestamoDetalleDataGridView,
                    "Debe Agregar los libros ");
                Validar = true;
            }*/
             if(LibrocomboBox.SelectedValue == null)
            {
                SuperErrorProvider.SetError(LibrocomboBox, "debe llenar este campo");
                Validar = true;
            }
            if (LectorcomboBox.SelectedValue == null)
            {
                SuperErrorProvider.SetError(LectorcomboBox, "debe llenar este campo");
                Validar = true;
            }
            if (string.IsNullOrWhiteSpace(MatriculatextBox.Text))
            {
                SuperErrorProvider.SetError(MatriculatextBox, "debe llenar este campo");
                Validar = true;
            }
            return Validar;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            SuperErrorProvider.Clear();
            Limpiar();
            Limpiar();
            
        }

        private void AgregarButtton_Click_1(object sender, EventArgs e)
        {
          
            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos!!", "Validación!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SuperErrorProvider.Clear();
                return;
            }
            else
            {
                if (PrestamoDetalleDataGridView.DataSource != null)
                {
                    Detalle = (List<PrestamoDetalle>)PrestamoDetalleDataGridView.DataSource;
                }

                this.Detalle.Add(
                    new PrestamoDetalle(
                       id: 0,
                         prestamoid: (int)prestamoidnumericUpDown.Value,
                         matricula:(int)Convert.ToInt32(MatriculatextBox.Text),
                         libroId: (int)LibrocomboBox.SelectedValue,
                         lectorid: (int)LectorcomboBox.SelectedValue
                     // fecha: FechadateTimePicker.Value

                     ));
                CargarGrid();
                LibrocomboBox.SelectAll();
                /* if (this.Detalle.Count == 0)
                 {
                     SuperErrorProvider.SetError(PrestamoDetalleDataGridView,
                         "Debe Agregar los libros ");
                     LibrocomboBox.Focus();
                     // Validar = true;
                 }*/
                int ejemplo =0,error=0;
                if (error == 1 && int.TryParse(LibrocomboBox.Text, out ejemplo ) == false)
                {
                  SuperErrorProvider.SetError(LibrocomboBox, "Debe de ser un numero");
                 
                }
            }
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (PrestamoDetalleDataGridView.Rows.Count > 0 && PrestamoDetalleDataGridView.CurrentRow != null)
            {
                List<PrestamoDetalle> detalle = (List<PrestamoDetalle>)PrestamoDetalleDataGridView.DataSource;

                detalle.RemoveAt(PrestamoDetalleDataGridView.CurrentRow.Index);

                CargarGrid();
              
            }
        }
        private void CargarGrid()
        {
            PrestamoDetalleDataGridView.DataSource = null;
            PrestamoDetalleDataGridView.DataSource=this.Detalle;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {

            Prestamo prestamo;
            bool Paso = false;
            LlenaCombox();
            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos!!", "Validación!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                SuperErrorProvider.Clear();
                return;
            }
            else
            {



                prestamo = LlenaClase();

                if (prestamoidnumericUpDown.Value == 0)
                {


                    Paso = PrestamoBLL.Guardar(prestamo);
                    MessageBox.Show("Guardado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenaCombox();
                    PrestamoDetalleDataGridView.DataSource = null;

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
                    LlenaCombox();
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
           if (prestamo == null)
            { 
            MessageBox.Show("No se encontró!!!", "Falló",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }else
            {
                MessageBox.Show("Encontrado !!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenaCampo(prestamo);
               // Llenarvalores();
            }
            
        }
        
        private void LibrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrestamoDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void RPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void MatriculatextBox_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void MatriculatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        }
    }

}
