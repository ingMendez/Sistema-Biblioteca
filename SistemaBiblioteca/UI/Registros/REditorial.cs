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
    public partial class REditorial : Form
    {
        private RepositorioBase<TipoEditorial> repos;
        public REditorial()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            SuperErrorProvider.Clear();
            IDEditorialnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
        }

        private TipoEditorial LlenaClase()
        {
            TipoEditorial tipo = new TipoEditorial()
            {
                EditarialID = Convert.ToInt32(IDEditorialnumericUpDown.Value),
                Nombre = NombretextBox.Text,
                Dirrecion = DireccionTextBox.Text,
                Fecha = FechadateTimePicker.Value
            };
            return tipo;
        }

        private void LlenaCampo(TipoEditorial tipo)
        {
            IDEditorialnumericUpDown.Value = tipo.EditarialID;
            NombretextBox.Text = tipo.Nombre;
            DireccionTextBox.Text = tipo.Dirrecion;
            FechadateTimePicker.Value = tipo.Fecha;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            repos = new RepositorioBase<TipoEditorial>(new DAL.Contexto());
            TipoEditorial tipo = repos.Buscar((int)IDEditorialnumericUpDown.Value);
            return (tipo != null);
        }

        private bool validar()
        {
            bool paso = true;
            /*  if(IDEditorialnumericUpDown.Value != 0)
              {
                  SuperErrorProvider.SetError(IDEditorialnumericUpDown, "EL campod ebe de estar en 0");
                   paso = false;
              }*/
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                SuperErrorProvider.SetError(NombretextBox, "El campo no debe estar vacio");
                NombretextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                SuperErrorProvider.SetError(DireccionTextBox, "El Campo no debe estar vacio");
                DireccionTextBox.Focus();
                paso = false;
            }
           
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            repos = new RepositorioBase<TipoEditorial>(new Contexto());
            TipoEditorial tipo;
            bool paso = false;
            tipo = LlenaClase();
            if (!validar())
            {
                return;
            }
            if (IDEditorialnumericUpDown.Value == 0)
            {
                paso = repos.Guardar(tipo);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificr un editorial no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                paso = repos.Modificar(tipo);
            }
            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //RCuentas.pas = 1;
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se Guardo El Editorial!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repos = new RepositorioBase<TipoEditorial>(new Contexto());
            int.TryParse(IDEditorialnumericUpDown.Text, out int id);
            TipoEditorial tipos = new TipoEditorial();
            tipos = repos.Buscar(id);

            if (tipos != null)
            {
                MessageBox.Show("Editorial Encontrado.!!", "Exito!!!", MessageBoxButtons.OK);
                LlenaCampo(tipos);
            }
            else
            {
                MessageBox.Show("Editorial no Encontrada", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            repos = new RepositorioBase<TipoEditorial>(new Contexto());
            int.TryParse(IDEditorialnumericUpDown.Text, out int id);
            if (!ExisteEnLaBaseDeDatos())
            {
                SuperErrorProvider.SetError(IDEditorialnumericUpDown, "Esta Editora No Existe");
                IDEditorialnumericUpDown.Focus();
                return;
            }
            if (repos.Eliminar(id))
            {
                MessageBox.Show("Editorial Eliminado!!", "Exitoso!!!", MessageBoxButtons.OK);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar El Tipo De Cuenta!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Direccicon_Click(object sender, EventArgs e)
        {

        }

        private void DireccionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NombretextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDEditorialnumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FechadateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

