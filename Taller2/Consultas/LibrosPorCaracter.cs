using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace Taller2
{
    public partial class LibrosPorCaracter : Form
    {
        public LibrosPorCaracter()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Libro f = new Libro();
            this.Hide();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textCaracter.Text.Contains("'"))
            {
                MessageBox.Show("El caracter ingresado no es valido");
                textCaracter.Clear();
            }

            else

            {
                ConexMySQL conex = new ConexMySQL();
                conex.open();

                string query = "SELECT Nombre FROM libro WHERE Nombre LIKE '%" + textCaracter.Text + "%'";
                DataTable dt = conex.selectQuery(query);
                dataGrid.DataSource = dt;
                dataGrid.Show();
                conex.close();

            }
        }
    }
}
