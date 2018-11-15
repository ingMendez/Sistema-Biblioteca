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

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-ABF85DA\\SQLEXPRESS; Initial Catalog = BiBliotecaDB; "
            + "Integrated Security=true;");

            conexion.Open();
            string cadena = "select Email, Contraseña from Usuarios where Email ='" + EmailTextBox.Text + "' and Contraseña = '" + ContraseñaTextBox.Text + "' ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {

                if ((registro["Email"].ToString() == EmailTextBox.Text) && (registro["Contraseña"].ToString() == ContraseñaTextBox.Text))
                {
                    MessageBox.Show("Correcto");
                    Form1 principal = new Form1();
                    principal.Show();
                    principal.Activos();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("El Email o la Contraseña estan incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            conexion.Close();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
