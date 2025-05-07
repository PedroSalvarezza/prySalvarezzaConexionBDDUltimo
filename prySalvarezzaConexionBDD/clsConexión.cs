using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySalvarezzaConexionBDD
{
    internal class clsConexión
    {
        public string cadenaConexion;
        public clsConexión()
        {
            cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;";
        }
        public void Agregar(clsProducto producto)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "INSERT INTO Productos(Codigo, Nombre, Descripcion, Precio, Stock, Categoria)" +
                    "VALUES (@Codigo, @Nombre, @Descripcion, @Precio, @Stock, @Categoria)";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Codigo", producto.Codigo);
                comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@Stock", producto.Stock);
                comando.Parameters.AddWithValue("@Categoria", producto.Categoria);
                comando.ExecuteNonQuery();
            }
        }
        public void CargarProducto(DataGridView dgv)
        {
            try
            {
                string query = "SELECT Codigo, Nombre, Descripcion, Precio, Stock, Categoria FROM Productos";

                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgv.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        public void CargarContactos(DataGridView dgv)
        {
            try
            {
                string query = "SELECT ID,Email,Telefono FROM Contactos";

                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dgv.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
        public void Modificar(clsProducto producto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE Productos SET Nombre=@Nombre, Descripcion=@Descripcion, Precio=@Precio, " +
                                   "Stock=@Stock, Categoria=@Categoria WHERE Codigo=@Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudo modificar el producto: {error.Message}");
            }
        }
        public void Eliminar(int codigo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaConexion))
                {
                    string query = "DELETE FROM Productos WHERE Codigo = @Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudo eliminar el producto: {error.Message}");
            }
        }
    }
}
