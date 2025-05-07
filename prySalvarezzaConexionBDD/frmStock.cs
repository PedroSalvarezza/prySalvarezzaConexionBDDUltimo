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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }
        clsConexión BD = new clsConexión();
        private void frmStock_Load(object sender, EventArgs e)
        {
            BD.CargarProducto(dgvStock);
            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbCodigo.DataSource = dt;
                cmbCodigo.DisplayMember = "Codigo";
                cmbCodigo.SelectedIndex = -1;
                cmbCodigo.Text = "Seleccione...";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                int codigoSeleccionado = Convert.ToInt32(((DataRowView)cmbCodigo.SelectedItem)["Codigo"]);
                using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
                {
                    conexion.Open();
                    string query = "SELECT * FROM Productos WHERE Codigo = @Codigo";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Codigo", codigoSeleccionado);

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    dgvStock.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccioná un código primero.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            BD.CargarProducto(dgvStock); 
            cmbCodigo.SelectedIndex = -1;
            cmbCodigo.Text = "Seleccione...";
        }
    }
}
