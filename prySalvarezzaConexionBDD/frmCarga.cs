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
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }
        clsConexión BD = new clsConexión(); 
        private void frmCarga_Load(object sender, EventArgs e)
        {
            BD.CargarProducto(dgvManejo);
            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbCategorias.DataSource = dt;
                cmbCategorias.DisplayMember = "Categoria";
                numPrecio.Maximum = 1000000;
                numPrecio.Minimum = 0;
                numStock.Maximum = 10000000;
                numStock.Minimum = 0;
                numCodigo.Maximum = 1000000;
                numCodigo.Minimum = 0;
                limpiarDatos();
            }
            using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT Codigo FROM Productos", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                cmbBuscar.DataSource = dt;
                cmbBuscar.DisplayMember = "Codigo"; 
                cmbBuscar.ValueMember = "Codigo"; 
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            controlDeDatos(txtNombre, numPrecio, txtDescripción, numPrecio, cmbCategorias);
            try
            {
                clsProducto producto = new clsProducto();
                producto.Codigo = Convert.ToInt32(numCodigo.Value);
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripción.Text;
                producto.Precio = Convert.ToInt32(numPrecio.Value);
                producto.Stock = Convert.ToInt32(numStock.Value);
                producto.Categoria = cmbCategorias.Text;
                BD.CargarProducto(dgvManejo);
                BD.Agregar(producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se agrego el producto");
            }
            BD.CargarProducto(dgvManejo);
            limpiarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            controlDeDatos(txtNombre, numStock, txtDescripción, numPrecio, cmbCategorias);
            try
            {
                clsProducto producto = new clsProducto();
                {
                    producto.Codigo = Convert.ToInt32(numCodigo.Value);
                    producto.Nombre = txtNombre.Text;
                    producto.Descripcion = txtDescripción.Text;
                    producto.Precio = Convert.ToInt32(numPrecio.Value);
                    producto.Stock = Convert.ToInt32(numStock.Value);
                    producto.Categoria = cmbCategorias.Text;
                    BD.Modificar(producto);
                    BD.CargarProducto(dgvManejo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se modifico el producto", ex.Message);
            }
            limpiarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            controlDeDatos(txtNombre, numPrecio, txtDescripción, numPrecio, cmbCategorias);
            try
            {
                int codigo = (int)numCodigo.Value;
                BD.Eliminar(codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se elimino el producto", ex.Message);
            }
            BD.CargarProducto(dgvManejo);
            limpiarDatos();
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            limpiarDatos();
            dgvManejo.ClearSelection();
            numCodigo.Focus();
        }
        public void controlDeDatos(TextBox txt, NumericUpDown num, TextBox txt2, NumericUpDown num2, ComboBox cmb)
        {
            if (numCodigo.Value != 0)
            {
                bool camposCompletos = txt.Text != "" && num.Value != 0 && txt2.Text != "" && num2.Value != 0 && cmb.SelectedIndex != -1;

                btnAgregar.Enabled = camposCompletos;
                btnModificar.Enabled = camposCompletos;
            }
            else
            {
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        public void limpiarDatos()
        {
            numCodigo.Value = 0;
            numCodigo.Enabled = true;
            txtNombre.Text = "";
            numStock.Value = 0;
            txtDescripción.Text = "";
            numPrecio.Value = 0;
            cmbCategorias.SelectedIndex = -1;
            cmbCategorias.Text = "Seleccione...";
            btnAgregar.Enabled = false;
        }

        private void numCodigo_ValueChanged(object sender, EventArgs e)
        {
            controlDeDatos(txtNombre, numPrecio, txtDescripción, numPrecio, cmbCategorias);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            controlDeDatos(txtNombre, numPrecio, txtDescripción, numPrecio, cmbCategorias);
        }

        private void txtDescripción_TextChanged(object sender, EventArgs e)
        {
            controlDeDatos(txtNombre, numPrecio, txtDescripción, numPrecio, cmbCategorias);
        }

        private void numPrecio_ValueChanged(object sender, EventArgs e)
        {
            controlDeDatos(txtNombre, numPrecio, txtDescripción, numPrecio, cmbCategorias);
        }

        private void numStock_ValueChanged(object sender, EventArgs e)
        {
            controlDeDatos(txtNombre, numPrecio, txtDescripción, numPrecio, cmbCategorias);
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlDeDatos(txtNombre, numPrecio, txtDescripción, numPrecio, cmbCategorias);
        }

        private void dgvManejo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Evita que cambie si selecciona el encabezado
            {
                DataGridViewRow fila = dgvManejo.Rows[e.RowIndex];

                numCodigo.Value = Convert.ToDecimal(fila.Cells["Codigo"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
                numStock.Value = Convert.ToDecimal(fila.Cells["Stock"].Value);
                txtDescripción.Text = fila.Cells["Descripcion"].Value?.ToString();
                numPrecio.Value = Convert.ToDecimal(fila.Cells["Precio"].Value);
                cmbCategorias.Text = fila.Cells["Categoria"].Value.ToString();
            }
        }

        private void dgvManejo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAgregar.Enabled = false;
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscar.SelectedIndex != -1)
            {
                btnBuscar.Enabled = true; 
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoSeleccionado = cmbBuscar.SelectedValue.ToString(); 
                using (SqlConnection conexion = new SqlConnection(BD.cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Codigo, Nombre, Descripcion, Precio, Stock, Categoria " +
                                                   "FROM Productos WHERE Codigo = @Codigo", conexion);
                    cmd.Parameters.AddWithValue("@Codigo", codigoSeleccionado);

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    dgvManejo.DataSource = dt; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los productos: " + ex.Message);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            BD.CargarProducto(dgvManejo);
            cmbBuscar.SelectedIndex = -1;  
            cmbBuscar.Text = "Seleccione...";
        }
    }
}
