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
using MySql.Data.MySqlClient;

namespace Taller2
{
    public partial class ListadoLibrosPromocion_22_ : Form
    {
        public ListadoLibrosPromocion_22_()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Libro2 f = new Libro2();
            this.Hide();
            f.Show();
        }

        
        private void verLibros_Click(object sender, EventArgs e)
        {

            if (cboCategoriaLibro.Text != "")
            {
                string query = "";

                ConexMySQL conex = new ConexMySQL();
                conex.open();
                try
                {
                    string queryAutor = "SELECT nombre FROM Categoria WHERE nombre = '" + cboCategoriaLibro.Text + "'";
                    query = conex.selectQueryScalar(queryAutor);
                }
                catch (Exception error)
                {
                    string error1 = error.ToString();

                }
                string queryFinal = "select l.isbn, l.nombre, l.autor, l.PorcentajeDescuento from libro as l inner join libro_categoria as lc on l.ISBN = lc.LibroISBN inner join categoria as c on lc.CategoriaID = c.ID where c.nombre = '" + query + "' and PorcentajeDescuento > 0";
                
                DataTable tabla = conex.selectQuery(queryFinal);
                dato.DataSource = tabla;
            }

        }

        private void ListadoLibrosPromocion_22__Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryCboLibroPromocion = "SELECT nombre FROM Categoria";
            DataTable tablaLibro = conex.selectQuery(queryCboLibroPromocion);
            for (int i = 0; i < tablaLibro.Rows.Count; i++)
            {
                cboCategoriaLibro.Items.Add(tablaLibro.Rows[i]["nombre"]);
            }
        }

        private void cboCategoriaLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
