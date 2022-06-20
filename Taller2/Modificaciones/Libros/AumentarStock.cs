using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;

namespace Taller2
{
    public partial class AumentarStock : Form
    {
        public AumentarStock()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesLibros f = new ModificacionesLibros();
            this.Hide();
            f.Show();
        }

        private void AumentarStock_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryCboLibro = "SELECT isbn FROM Libro";
            DataTable tablaLibro = conex.selectQuery(queryCboLibro);
            for (int i = 0; i < tablaLibro.Rows.Count; i++)
            {
                cboISBNLibro.Items.Add(tablaLibro.Rows[i]["isbn"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = cboISBNLibro.Text;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "UPDATE libro set CantidadStock=@CantidadStock where isbn=@isbn;";
            MySqlCommand cmd = new MySqlCommand(query, conex.getConexion());
            cmd.Parameters.AddWithValue("@CantidadStock", textStockLibro.Text);
            cmd.Parameters.AddWithValue("@isbn", cboISBNLibro.Text);            
            mostrarDato(isbn);

            try
            {
                MySqlCommand comando = new MySqlCommand(query, conex.getConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Stock Actualizado.");

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error al guardar: " + ex.Message);

            }
            finally
            {
                conex.close();

            }
        }

        public void mostrarDato(string isbn)
        {
            MySqlDataAdapter adapt;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            DataTable dt = new DataTable();            
            if (isbn == null)
            {
                adapt = new MySqlDataAdapter("Select * from libro;", conex.getConexion());
            }
            else
            {
                adapt = new MySqlDataAdapter("Select * from libro where libro.isbn=" + "'" + isbn + "';", conex.getConexion());
            }
            adapt.Fill(dt);
            dato.DataSource = dt;
            conex.close();

        }
        private void verDireccion_Click(object sender, EventArgs e)
        {
            mostrarDato(null);
        }

        private void verLibros_Click(object sender, EventArgs e)
        {

        }
    }
}
