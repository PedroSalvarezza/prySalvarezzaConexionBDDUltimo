using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySalvarezzaConexionBDD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clsConexión BD = new clsConexión();
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor completá ambos campos.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);

                int resultado = (int)cmd.ExecuteScalar();

                if (resultado > 0)
                {
                    MessageBox.Show("Inicio de sesión exitoso.");
                    this.Hide();
                    frmMenú menú = new frmMenú();
                    menú.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }
        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMostrar.Checked)
            {
                txtContraseña.UseSystemPasswordChar = true; 
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = false; 
            }
        }
    }
}
