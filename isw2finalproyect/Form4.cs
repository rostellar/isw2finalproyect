using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isw2finalproyect
{
    public partial class prestarForm : Form
    {
        public prestarForm()
        {
            InitializeComponent();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            //Conexión de la base de datos.
            String cadenaConexion = "Database=biblioteca; Data Source=localhost; Port=3306; User Id=root; Password=0012";
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            //Recopilación de datos
            String identificador = txtIdLibro.Text;
            String nombre = txtNombre.Text;
            String apellido = txtApellido.Text;
            String celular = txtCelular.Text;
            String direccion = txtDireccion.Text;

            String insertar = "INSERT INTO clientes(nombre, apellido, movil, direccion, libros_prest) VALUES('" + nombre + "', '" + apellido + "', '" + celular + "', '" + direccion + "', '" + identificador+"')";
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(insertar, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Correcto");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
