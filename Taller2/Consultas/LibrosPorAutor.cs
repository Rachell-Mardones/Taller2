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
    public partial class LibrosPorAutor : Form
    {
        public LibrosPorAutor()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Libro f = new Libro();
            this.Hide();
            f.Show();
        }

        private void btnVerLibros_Click(object sender, EventArgs e)
        {
            if (cboAutores.Text != "")
            {
                string query = "";
                
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                try
                {
                    string queryAutor = "SELECT Autor FROM Libro WHERE autor = '" + cboAutores.Text + "'";
                    query = conex.selectQueryScalar(queryAutor);
                }
                catch (Exception error)
                {
                    string error1 = error.ToString();
                    
                }
                              
                string queryFinal = "SELECT nombre FROM LIBRO WHERE autor = '" + query + "'";
                DataTable tabla = conex.selectQuery(queryFinal);
                dataGridView1.DataSource = tabla;
            }

        }

        private void LibrosPorAutor_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryCatLibros = "SELECT autor FROM libro";
            DataTable tablaLibro = conex.selectQuery(queryCatLibros);
            for (int i = 0; i < tablaLibro.Rows.Count; i++)
            {
                cboAutores.Items.Add(tablaLibro.Rows[i]["autor"]);
            }
        }
    }
}
