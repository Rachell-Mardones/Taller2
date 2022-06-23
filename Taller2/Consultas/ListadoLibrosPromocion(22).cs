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

        public void mostrarDato(string categoria)
        {
            MySqlDataAdapter adapt;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable dt = new DataTable();
           
            if (categoria == null)
            {
                adapt = new MySqlDataAdapter("Select * from libro;", conex.getConexion());
            }
            else
            {
                adapt = new MySqlDataAdapter("Select * from libro where libro.isbn=" + "'" + categoria + "';", conex.getConexion());
            }
            adapt.Fill(dt);
            dato.DataSource = dt;
            conex.close();

        }

        private void verLibros_Click(object sender, EventArgs e)
        {
            if (cboCategoriaLibro.Text != "")
            {
                string codCliente = "";               
                ConexMySQL conex = new ConexMySQL();
                conex.open();
                try
                {
                    string query = "SELECT isbn, titulo, categoria from libro where categoria = '" + cboCategoriaLibro.Text + "'";
                    codCliente = conex.selectQueryScalar(query);
                }
                catch (Exception error)
                {
                    string error1 = error.ToString();
                    
                }
                string query2 = "SELECT categoria, libro from libro";               
                DataTable tabla = conex.selectQuery(query2);
                dato.DataSource = tabla;

            }

        }

        private void ListadoLibrosPromocion_22__Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryCboLibroPromocion = "SELECT categoria FROM Libro";
            DataTable tablaLibro = conex.selectQuery(queryCboLibroPromocion);
            for (int i = 0; i < tablaLibro.Rows.Count; i++)
            {
                cboCategoriaLibro.Items.Add(tablaLibro.Rows[i]["categoria"]);
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
