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
using System.Text.RegularExpressions;

namespace Taller2
{
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesLibros f = new ModificacionesLibros();
            this.Hide();
            f.Show();
        }

        private void BotonAgregarCategoria_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            String categoria = NombreCategoria.Text;


            if (categoria != "")
            {

                string query = "INSERT INTO Categoria (nombre) values('" + NombreCategoria.Text + "')"; 

                MySqlCommand cmd = new MySqlCommand(query, conex.getConexion());

                cmd.Parameters.AddWithValue("@nombre", NombreCategoria.Text);
                               

                try
                {
                    MySqlCommand comando = new MySqlCommand(query, conex.getConexion());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Categoria agregada.");

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
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }

        }
    }
}
