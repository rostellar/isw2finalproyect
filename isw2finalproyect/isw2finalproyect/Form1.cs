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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtPass.Text;

            /* String cadenaConexion = "Database=mysql; Data Source=localhost; Port=3306; User Id=root; Password=0012";

            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null;
            string data = null;

            try
            {
                String consulta = "SHOW DATABASES;";
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Connection = conexionBD;
                conexionBD.Open();
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    data += reader.GetString(0) + "\n";
                }

                MessageBox.Show(data);
            } 
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            */

            String user = txtUser.Text;
            String pass = txtPass.Text;

            if (user == "admin" && pass == "admin")
            {
                homeForm f2 = new homeForm();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario inválido");
            }
        }
    }
}
