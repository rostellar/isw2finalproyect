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
    public partial class homeForm : Form
    {
        public homeForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            addBookForm f3 = new addBookForm();
            f3.ShowDialog();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            prestarForm f4 = new prestarForm();
            f4.ShowDialog();
        }

        private void btnPrestados_Click(object sender, EventArgs e)
        {
            librosPrestadosForm f5 = new librosPrestadosForm();
            f5.ShowDialog();
        }

        private void btnBuscarLibros_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construcción");
        }
    }
}
