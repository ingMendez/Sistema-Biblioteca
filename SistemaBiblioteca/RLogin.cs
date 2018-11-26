using SistemaBiblioteca;
using SistemaBiblioteca.BLL;
using SistemaBiblioteca.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class RLogin : Form
    {
        public RLogin()
        {
            InitializeComponent();
        }
        public Usuario Llenarclase()
        {
            Usuario usuario = new Usuario()
            {
                Nombres = EmailTextBox.Text,
                Contraseña = Program.Hash(ContraseñaTextBox.Text)
            };
            return usuario;
        }

        public bool Validar()
        {
            bool paso = true;
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text) || string.IsNullOrWhiteSpace(ContraseñaTextBox.Text))
            {
                paso = true;
            }
            return paso;
        }

        public void Limpiar()
        {
            errorProvider1.Clear();
            EmailTextBox.Clear();
            ContraseñaTextBox.Clear();
        }

        public void Entrar()
        {
            if (Validar())
            {

                Usuario usuario = Llenarclase();
                RepositorioBase<Usuario> repositorio = new RepositorioBase<Usuario>(new DAL.Contexto());
                List<Usuario> lista = repositorio.GetList(u => true);
                if (lista.Count > 0)
                {
                    bool paso = false;
                    Usuario UsuarioIniciado = null;
                    foreach (var item in lista)
                    {
                        if (item.Nombres == usuario.Nombres && item.Contraseña == usuario.Contraseña)
                        {
                            UsuarioIniciado = item;
                            paso = true;
                            break;
                        }
                    }

                    if (paso)
                    {
                        Limpiar();
                        Program.usuario = UsuarioIniciado;
                        Program.menu = new Form1();
                        Program.menu.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El usuario y la Contrasena No conciden");
                    }
                }
                else
                {
                    repositorio.Guardar(new Usuario()
                    {
                        Nombres = "Admin",
                        pocision = true,
                        Contraseña = Program.Hash("1234"),
                        Email = "Admin",
                        NoTelefono = "123",
                        FechaCreacion = DateTime.Now
                    });
                    MessageBox.Show("Intentar De Nuevo");
                    Limpiar();
                }
            }


            else
            {
                MessageBox.Show("LLenar Todo  lo Campo");
                if (string.IsNullOrEmpty(ContraseñaTextBox.Text))
                {
                    errorProvider1.SetError(ContraseñaTextBox, " LLenar Este Campo");
                }
                if (string.IsNullOrEmpty(EmailTextBox.Text))
                {
                    errorProvider1.SetError(EmailTextBox, "Llenar Campo");
                }
            }
        }
    


      private void EntrarButton_Click(object sender, EventArgs e)
        {
            Entrar();
            
            /*
            Form1 principal = new Form1();
            principal.Show();
             principal.Activos();
           
            /*    SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-ABF85DA\\SQLEXPRESS; Initial Catalog = BiBliotecaDB; "
                 + "Integrated Security=true;");

              conexion.Open();
                 string cadena = "select Email, Contraseña from Usuarios where Email ='" + EmailTextBox.Text + "' and Contraseña = '" + ContraseñaTextBox.Text + "' ";
                 SqlCommand comando = new SqlCommand(cadena, conexion);
                string adminis = "select Email, Contraseña from Administradors where Email ='" + EmailTextBox.Text + "' and Contraseña = '" + ContraseñaTextBox.Text + "' ";
               SqlCommand comandoAdmn = new SqlCommand(adminis, conexion);

               SqlDataReader RegistroAdmin = comandoAdmn.ExecuteReader();
               SqlDataReader registro = comando.ExecuteReader();
               if (registro.Read())
               {

                   if (Usuario.Checked = true && (registro["Email"].ToString() == EmailTextBox.Text) && (registro["Contraseña"].ToString() == ContraseñaTextBox.Text))
                   {
                       MessageBox.Show("Correcto");
                       Form1 principal = new Form1();
                       principal.Show();
                       // principal.Activos();

                       this.Hide();
                   }
                   else
                   {
                       MessageBox.Show("Usuario incorrecto");
                      conexion.Close();
                  }
                  conexion.Open();
               }else if (RegistroAdmin.Read())
               {

                   if (Admin.Checked = true && (RegistroAdmin["Email"].ToString() == EmailTextBox.Text) && (RegistroAdmin["Contraseña"].ToString() == ContraseñaTextBox.Text))
                   {
                       MessageBox.Show("Correcto");
                       Form1 principal = new Form1();
                       principal.Show();
                        principal.Activos();

                       this.Hide();
                   }
                   else
                   {
                       MessageBox.Show("Usuario incorrecto");
                   }



               }else
                   MessageBox.Show("El Email o la Contraseña estan incorrectos", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                 conexion.Close();*/
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RLogin_Load(object sender, EventArgs e)
        {

        }

        private void Usuario_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
