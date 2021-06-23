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
    public partial class addBookForm : Form
    {
        public addBookForm()
        {
            InitializeComponent();
        }

        private void btnPrestados_Click(object sender, EventArgs e)
        {
            //Conexión de la base de datos.
            String cadenaConexion = "Database=biblioteca; Data Source=localhost; Port=3306; User Id=root; Password=0012";
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            //Recopilación de datos
            String titulo = txtTitulo.Text;
            String autor = txtAutor.Text;
            String year = txtYear.Text;
            String editorial = txtEditorial.Text;
            String paginas = txtPaginas.Text;
            String coleccion = txtColeccion.Text;

            String insertar = "INSERT INTO libros(titulo, nombre_autor, nombre_edit, year, paginas, coleccion) VALUES('" + titulo + "', '" + autor + "', '" + editorial + "', '" + year + "', '" + paginas + "', '" + coleccion + "')";
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(insertar, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Libro agregado");
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
