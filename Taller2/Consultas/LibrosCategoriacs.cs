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
    public partial class LibrosCategoriacs : Form
    {
        public LibrosCategoriacs()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Libro2 f = new Libro2();
            this.Hide();
            f.Show();
        }

        
        private void LibrosCategoriacs_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryCategoria = "SELECT nombre FROM categoria";            
            DataTable tablaLibro = conex.selectQuery(queryCategoria);            
            for (int i = 0; i < tablaLibro.Rows.Count; i++)
            {
                cboNombreCategoria.Items.Add(tablaLibro.Rows[i]["nombre"]);                
            }
            string queryCliente = "SELECT comprador FROM venta";
            DataTable tablaLibro2 = conex.selectQuery(queryCliente);
            for (int i = 0; i < tablaLibro2.Rows.Count; i++)
            {
                cboNombreCliente.Items.Add(tablaLibro2.Rows[i]["comprador"]);
            }


        }

        private void VerLibros_Click(object sender, EventArgs e)
        {
            if (cboNombreCliente.Text != "" && cboNombreCategoria.Text != "")
            {
                string query1 = "";
                string query2 = "";

                ConexMySQL conex = new ConexMySQL();
                conex.open();
                try
                {
                    string queryCategoria = "SELECT nombre FROM Categoria WHERE nombre = '" + cboNombreCategoria.Text + "'";
                    query1 = conex.selectQueryScalar(queryCategoria);

                    string queryCliente = "SELECT distinct Comprador FROM venta WHERE comprador = '" + cboNombreCliente.Text + "'";
                    query2 = conex.selectQueryScalar(queryCliente);
                }
                catch (Exception error)
                {
                    string error1 = error.ToString();

                }

                string queryFinal = "select l.isbn, l.nombre, l.autor from libro as l inner join libro_categoria as lc on l.ISBN = lc.LibroISBN inner join categoria as c on lc.CategoriaID = c.ID inner join libro_detalledeventa as ld on l.ISBN = ld.LibroISBN inner join detalledeventa as dv on ld.DetalleDeVentaID = dv.ID inner join venta as v on dv.id = v.ID where c.nombre = '" + query1 + "' and v.Comprador = '" + query2 + "'";
               
                DataTable tabla = conex.selectQuery(queryFinal);
                dataGridView1.DataSource = tabla;
            }
        }
    }
}
