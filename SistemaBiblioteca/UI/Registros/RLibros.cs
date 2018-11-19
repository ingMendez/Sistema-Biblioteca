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
    public partial class RLibros : Form
    {
        private RepositorioBase<Libros> repositorio;

        public RLibros()
        {
            InitializeComponent();
            LlenaCombox();
        }

        private void LlenaCombox()
        {
            RepositorioBase<TipoEditorial> tipo = new RepositorioBase<TipoEditorial>(new Contexto());
            RepositorioBase<Categoria> cat = new RepositorioBase<Categoria>(new Contexto());
            EditoracomboBox.DataSource = tipo.GetList(c => true);
            EditoracomboBox.ValueMember = "EditarialID";
            EditoracomboBox.DisplayMember = "Nombre";

            CategoriacomboBox.DataSource = cat.GetList(c => true);
            CategoriacomboBox.ValueMember = "CategoriaID";
            CategoriacomboBox.DisplayMember = "Nombre";

        }

        private void Limpiar()
        {
            SuperErrorProvider.Clear();
            LibroIdnumericUpDown.Value = 0;
            ISBNtextBox.Text = string.Empty;
            CategoriacomboBox.Text = string.Empty;
            NobretextBox.Text = string.Empty;
            DescripciontextBox.Text = string.Empty;
            EditoracomboBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
        }

        private Libros LlenaClase()
        {
            Libros libro = new Libros()
            {
                LibroID = Convert.ToInt32(LibroIdnumericUpDown.Value),
                NombreLibro = NobretextBox.Text,
                Descripcion = DescripciontextBox.Text,
                ISBN = ISBNtextBox.Text,
                CategoriaID = Convert.ToInt32(CategoriacomboBox.SelectedValue),
                EditarialID = Convert.ToInt32(EditoracomboBox.SelectedValue),
                FechaImpresion = FechadateTimePicker.Value
            };
            return libro;
        }

        private void LlenaCampo(Libros tipo)
        {


            LibroIdnumericUpDown.Value = tipo.LibroID;
            NobretextBox.Text = tipo.NombreLibro;
            DescripciontextBox.Text = tipo.Descripcion;
            ISBNtextBox.Text = tipo.ISBN;
            CategoriacomboBox.SelectedItem =tipo.CategoriaID;
            EditoracomboBox.SelectedItem = tipo.EditarialID;
            FechadateTimePicker.Value = tipo.FechaImpresion;



        }

        private bool ExisteEnLaBaseDeDatos()
        {
            repositorio = new RepositorioBase<Libros>(new DAL.Contexto());
            Libros tipo = repositorio.Buscar((int)LibroIdnumericUpDown.Value);
            return (tipo != null);
        }

        private bool validar()
        {
            bool paso = true;
          
            if (string.IsNullOrWhiteSpace(NobretextBox.Text))
            {
                SuperErrorProvider.SetError(NobretextBox, "El campo no debe estar vacio");
                NobretextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ISBNtextBox.Text))
            {
                SuperErrorProvider.SetError(ISBNtextBox, "El Campo no debe estar vacio");
                ISBNtextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                SuperErrorProvider.SetError(DescripciontextBox, "El Campo no debe estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CategoriacomboBox.Text))
            {
                SuperErrorProvider.SetError(CategoriacomboBox, "El Campo no debe estar vacio");
                CategoriacomboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EditoracomboBox.Text))
            {
                SuperErrorProvider.SetError(EditoracomboBox, "El Campo no debe estar vacio");
                EditoracomboBox.Focus();
                paso = false;
            }
          
            return paso;
        }

        private void RLibros_Load(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Libros _libro;
            bool paso = false;

            if (!validar())
            {
                MessageBox.Show("Debe Llenar los Campos Indicados", "Validacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _libro = LlenaClase();

                if (LibroIdnumericUpDown.Value == 0)
                {
                    paso = LibroBLL.Guardar(_libro);
                    MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    SuperErrorProvider.Clear();
                }
                else
                {
                    int id = Convert.ToInt32(LibroIdnumericUpDown.Value);
                    _libro = LibroBLL.Buscar(id);

                    if (_libro != null)
                    {
                        paso = LibroBLL.Modificar(LlenaClase());
                        MessageBox.Show("Modificado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Id no existe", "Falló",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (paso)
                {
                    Limpiar();
                }
                else
                {

                    MessageBox.Show("No se pudo guardar!!", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibroIdnumericUpDown.Value);
            Libros libros = LibroBLL.Buscar(id);

            int.TryParse(LibroIdnumericUpDown.Text, out id);

            if (libros != null)
            {
                MessageBox.Show("Libro Encontrado.!!", "Exito!!!",
                   MessageBoxButtons.OK);
                LlenaCampo(libros);
            }
            else
            {
                MessageBox.Show("Libro no Encontrado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(LibroIdnumericUpDown.Value);

            Libros mercancia = LibroBLL.Buscar(id);
            if (mercancia != null)
            {
                if (LibroBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Categoriabutton_Click(object sender, EventArgs e)
        {
            RCategoria r = new RCategoria();
            r.ShowDialog();
            LlenaCombox();
        }

        private void AddEditorial_Click(object sender, EventArgs e)
        {
            REditorial Editoria = new REditorial();
            Editoria.ShowDialog();
            LlenaCombox();
        }
    }
}


