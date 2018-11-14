using SistemaBiblioteca.BLL;
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
    public partial class RUsuario : Form
    {
        public RUsuario()
        {
            InitializeComponent();
        }
        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        //Métodos
        private Usuario LlenaClase()
        {
            Usuario usuario = new Usuario();

            usuario.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            usuario.Nombres = NombresTextBox.Text;
            usuario.Email = EmailTextBox.Text;
            usuario.NoTelefono = NoTelefonoMaskedTextBox.Text;
            usuario.Contraseña = ContraseñaTextBox.Text;

            return usuario;
        }

        private void LimpiarObjetos()
        {
            UsuarioIdNumericUpDown.Value = 0;
            NombresTextBox.Clear();
            EmailTextBox.Clear();
            NoTelefonoMaskedTextBox.Clear();
            ContraseñaTextBox.Clear();
            SuperErrorProvider.Clear();
        }

        private bool HayErrores()
        {
            bool paso = false;

            if (String.IsNullOrEmpty(NombresTextBox.Text))
            {
                SuperErrorProvider.SetError(NombresTextBox,
                    "Debe escribir el Nombre Completo para el Usuario");
                paso = true;
            }
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                SuperErrorProvider.SetError(EmailTextBox,
                    "Debe ingresar un Email para el Usuario");
                paso = true;
            }
            if (String.IsNullOrEmpty(NoTelefonoMaskedTextBox.Text))
            {
                SuperErrorProvider.SetError(NoTelefonoMaskedTextBox,
                    "Debe ingresar un Número de Teléfono para el Usuario");
                paso = true;
            }
            if (String.IsNullOrEmpty(ContraseñaTextBox.Text))
            {
                SuperErrorProvider.SetError(ContraseñaTextBox,
                    "Debe ingresar una Contraseña para el Usuario");
                paso = true;
            }

            return paso;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarObjetos();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuario usuario;
            bool paso = false;

            if (HayErrores())
                MessageBox.Show("Debe llenar los campos indicados", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            usuario = LlenaClase();

            if (UsuarioIdNumericUpDown.Value == 0)
            {
                paso = UsuarioBLL.Guardar(usuario);
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
                usuario = UsuarioBLL.Buscar(id);

                if (usuario != null)
                {
                    paso = UsuarioBLL.Modificar(LlenaClase());
                    MessageBox.Show("Modificado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (paso)
            {
                LimpiarObjetos();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);

            Usuario usuario = UsuarioBLL.Buscar(id);
            if (usuario != null)
            {
                if (UsuarioBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarObjetos();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existe!!", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            Usuario usuario = UsuarioBLL.Buscar(id);

            if (usuario != null)
            {
                NombresTextBox.Text = usuario.Nombres;
                EmailTextBox.Text = usuario.Email;
                NoTelefonoMaskedTextBox.Text = usuario.NoTelefono;
                ContraseñaTextBox.Text = usuario.Contraseña;
            }
        }
    }
}
