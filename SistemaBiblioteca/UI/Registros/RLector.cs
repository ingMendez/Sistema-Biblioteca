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
    public partial class RLector : Form
    {
        private RepositorioBase<Lector> repos;
        public RLector()
        {
            InitializeComponent();
        }
     

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            ApellidotextBox.Text = string.Empty;
            CedulatextBox.Text = string.Empty;
            NoTelefonoMaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
        }
        private Lector LlenaClase()
        {
            Lector lector = new Lector()
            {
                LectorID = Convert.ToInt32(IDnumericUpDown.Value),
                Nombre = NombretextBox.Text,
                Apellido = ApellidotextBox.Text,
                Cedula = CedulatextBox.Text,
                Telefono = NoTelefonoMaskedTextBox.Text,
                Direccion = DirecciontextBox.Text,
                Fecha = FechadateTimePicker.Value

            };
            return lector;

        }
        private void LlenaCampo(Lector lector)
        {

            IDnumericUpDown.Value = lector.LectorID;
            NombretextBox.Text = lector.Nombre;
            ApellidotextBox.Text = lector.Apellido;
            DirecciontextBox.Text = lector.Direccion;
            NoTelefonoMaskedTextBox.Text = lector.Telefono;
            CedulatextBox.Text =  lector.Cedula;
            FechadateTimePicker.Value = lector.Fecha.Date;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            repos = new RepositorioBase<Lector>(new Contexto());
            Lector lector = repos.Buscar((int)IDnumericUpDown.Value);
            return (lector != null);
        }

        private bool validar()
        {
            bool paso = true;
         
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                SuperErrorProvider.SetError(NombretextBox, "El campo no debe estar vacio");
                NombretextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ApellidotextBox.Text))
            {
                SuperErrorProvider.SetError(ApellidotextBox, "El campo no debe estar vacio");
                ApellidotextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                SuperErrorProvider.SetError(DirecciontextBox, "El Campo no debe estar vacio");
                DirecciontextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NoTelefonoMaskedTextBox.Text))
            {
                SuperErrorProvider.SetError(NoTelefonoMaskedTextBox, "El Campo no debe estar vacio");
                NoTelefonoMaskedTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CedulatextBox.Text))
            {
                SuperErrorProvider.SetError(CedulatextBox, "El Campo no debe estar vacio");
                CedulatextBox.Focus();
                paso = false;
            }
            if (FechadateTimePicker.Value > DateTime.Now)
            {
                SuperErrorProvider.SetError(FechadateTimePicker, "La fecha no es correcta");
                FechadateTimePicker.Focus();
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
            repos = new RepositorioBase<Lector>(new Contexto());
            Lector lector;
                bool paso = false;

                if (!validar())
                {
                    MessageBox.Show("Debe Llenar los Campos Indicados", "Validacion",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                lector = LlenaClase();

                    if (IDnumericUpDown.Value == 0)
                    {
                        paso = repos.Guardar(lector);
                        MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        SuperErrorProvider.Clear();
                    }
                    else
                    {
                        int id = Convert.ToInt32(IDnumericUpDown.Value);
                    lector = repos.Buscar(id);

                        if (lector != null)
                        {
                            paso = repos.Modificar(LlenaClase());
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            repos = new RepositorioBase<Lector>(new Contexto());
            int.TryParse(IDnumericUpDown.Text, out int id);
            if (!ExisteEnLaBaseDeDatos())
            {
                SuperErrorProvider.SetError(IDnumericUpDown, "Este Lector No Existe");
                IDnumericUpDown.Focus();
                return;
            }
            if (repos.Eliminar(id))
            {
                MessageBox.Show("Lector Eliminado!!", "Exitoso!!!", MessageBoxButtons.OK);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el Lector!!", "Fallo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repos = new RepositorioBase<Lector>(new Contexto());
            int.TryParse(IDnumericUpDown.Text, out int id);
            Lector lector = new Lector();
            lector = repos.Buscar(id);

            if (lector != null)
            {
                MessageBox.Show("Lector Encontrado.!!", "Exito!!!", MessageBoxButtons.OK);
                LlenaCampo(lector);
            }
            else
            {
                MessageBox.Show("Lector no Encontrada", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NoTelefonoMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void NoTelefonoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CedulatextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void CedulatextBox_KeyPress(object sender, KeyPressEventArgs e)
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
