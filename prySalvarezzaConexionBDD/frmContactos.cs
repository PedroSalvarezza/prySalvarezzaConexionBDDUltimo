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
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }
        clsConexión BD = new clsConexión();
        private void frmContactos_Load(object sender, EventArgs e)
        {
            BD.CargarContactos(dgvContactos); // Mostrar toda la tabla

            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID FROM Contactos", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                cmbContactos.DataSource = dt;
                cmbContactos.DisplayMember = "ID";
                cmbContactos.ValueMember = "ID";

                cmbContactos.SelectedIndex = -1;
                cmbContactos.Text = "Seleccione...";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbContactos.SelectedIndex != -1)
            {
                int idSeleccionado = Convert.ToInt32(((DataRowView)cmbContactos.SelectedItem)["ID"]);

                using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Contactos WHERE ID = @ID";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@ID", idSeleccionado);

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    dgvContactos.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccioná un ID antes de buscar.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            BD.CargarContactos(dgvContactos);
            cmbContactos.SelectedIndex = -1;
            cmbContactos.Text = "Seleccione...";
        }
    }
}
