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
    public partial class RCategoria : Form
    {
        private RepositorioBase<Categoria> repos;
        public RCategoria()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            SuperErrorProvider.Clear();
            IDCategorianumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            DescipcionTextBox.Text = string.Empty;
        }

        private Categoria LlenaClase()
        {
            Categoria tipo = new Categoria()
            {
                CategoriaID = Convert.ToInt32(IDCategorianumericUpDown.Value),
                Nombre = NombretextBox.Text,
                descripcion = DescipcionTextBox.Text
            };
            return tipo;
        }

        private void LlenaCampo(Categoria tipo)
        {
            IDCategorianumericUpDown.Value = tipo.CategoriaID;
            NombretextBox.Text = tipo.Nombre;
            DescipcionTextBox.Text = tipo.descripcion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            repos = new RepositorioBase<Categoria>(new Contexto());
            Categoria tipo = repos.Buscar((int)IDCategorianumericUpDown.Value);
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
            if (string.IsNullOrWhiteSpace(DescipcionTextBox.Text))
            {
                SuperErrorProvider.SetError(DescipcionTextBox, "El Campo no debe estar vacio");
                DescipcionTextBox.Focus();
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
            repos = new RepositorioBase<Categoria>(new Contexto());
            Categoria tipo;
            bool paso = false;
            tipo = LlenaClase();
            if (!validar())
            {
                return;
            }
            if (IDCategorianumericUpDown.Value == 0)
            {
                paso = repos.Guardar(tipo);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Categoria  no existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("No se Guardo la Categoria!!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repos = new RepositorioBase<Categoria>(new Contexto());
            int.TryParse(IDCategorianumericUpDown.Text, out int id);
            Categoria tipos = new Categoria();
            tipos = repos.Buscar(id);

            if (tipos != null)
            {
                MessageBox.Show("Categoria Encontrado.!!", "Exito!!!", MessageBoxButtons.OK);
                LlenaCampo(tipos);
            }
            else
            {
                MessageBox.Show("Categoria no Encontrada", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            repos = new RepositorioBase<Categoria>(new Contexto());
            int.TryParse(IDCategorianumericUpDown.Text, out int id);
            if (!ExisteEnLaBaseDeDatos())
            {
                SuperErrorProvider.SetError(IDCategorianumericUpDown, "Esta Categoria No Existe");
                IDCategorianumericUpDown.Focus();
                return;
            }
            if (repos.Eliminar(id))
            {
                MessageBox.Show("Categoria Eliminada!!", "Exitoso!!!", MessageBoxButtons.OK);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar El Tipo De Categoria!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
    }
}
