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
    public partial class LibrosPorCategoria : Form
    {
        public LibrosPorCategoria()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Libro f = new Libro();
            this.Hide();
            f.Show();
        }

        private void LibrosPorCategoria_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryCatLibros = "SELECT nombreCategoria FROM categoria";
            DataTable tablaLibro = conex.selectQuery(queryCatLibros);
            for (int i = 0; i < tablaLibro.Rows.Count; i++)
            {
                cboCatLibros.Items.Add(tablaLibro.Rows[i]["nombreCategoria"]);
            }
        }

        private void CboVerLibros_Click(object sender, EventArgs e)
        {
            if (cboCatLibros.Text != "")
            {
                string query = "";

                ConexMySQL conex = new ConexMySQL();
                conex.open();
                try
                {
                    string queryAutor = "SELECT nombreCategoria FROM Categoria WHERE nombreCategoria = '" + cboCatLibros.Text + "'";
                    query = conex.selectQueryScalar(queryAutor);
                }
                catch (Exception error)
                {
                    string error1 = error.ToString();

                }
                string queryFinal = "select l.nombre from libro as l inner join libro_categoria as lc on l.ISBN = lc.LibroISBN inner join categoria as c on lc.CategoriaID = c.ID where c.nombreCategoria = '" + query + "'";
                //string queryFinal = "SELECT nombre FROM Libro WHERE autor = '" + query + "'";
                DataTable tabla = conex.selectQuery(queryFinal);
                dataGridView1.DataSource = tabla;
            }

        }

        private void cboCatLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}



