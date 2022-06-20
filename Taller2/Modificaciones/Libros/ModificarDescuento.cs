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
    public partial class ModificarDescuento : Form
    {
        public ModificarDescuento()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesLibros f = new ModificacionesLibros();
            this.Hide();
            f.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            string isbn = cboISBNLibro.Text;
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string query = "UPDATE libro set PorcentajeDescuento=@PorcentajeDescuento where isbn=@isbn;";
            MySqlCommand cmd = new MySqlCommand(query, conex.getConexion());            
            cmd.Parameters.AddWithValue("@PorcentajeDescuento", textStock.Text);
            cmd.Parameters.AddWithValue("@isbn", cboISBNLibro.Text);
                               
            mostrarDato(isbn);

            try
            {
                MySqlCommand comando = new MySqlCommand(query, conex.getConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Descuento actualizado.");

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error al actualizar: " + ex.Message);

            }
            finally
            {
                conex.close();

            }
        }

        private void textDinero_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboRutCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModificarDescuento_Load(object sender, EventArgs e)
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

        private void verDireccion_Click(object sender, EventArgs e)
        {
            mostrarDato(null);
        }
    }
}
