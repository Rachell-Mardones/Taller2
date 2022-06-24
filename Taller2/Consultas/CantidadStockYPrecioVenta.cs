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
    public partial class CantidadStockYPrecioVenta : Form
    {
        public CantidadStockYPrecioVenta()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Libro2 f = new Libro2();
            this.Hide();
            f.Show();
        }

        private void VerLibro_Click(object sender, EventArgs e)
        {
            if (cboLibro.Text != "")
            {
                string queryLibro = "";

                ConexMySQL conex = new ConexMySQL();
                conex.open();
                try
                {
                    string queryNombre = "SELECT nombre FROM Libro WHERE nombre = '" + cboLibro.Text + "'";
                    queryLibro = conex.selectQueryScalar(queryNombre);
                }
                catch (Exception error)
                {
                    string error1 = error.ToString();

                }
                                
                string queryFinal = "select l.isbn, l.nombre, l.editorial, l.CantidadStock, dv.TotalAPagar from libro as l inner join libro_detalledeventa as ld on l.ISBN = ld.LibroISBN inner join detalledeventa as dv on ld.DetalleDeVentaID = dv.id where l.Nombre = '" + queryLibro + "'";
                DataTable tabla = conex.selectQuery(queryFinal);
                dataGridView1.DataSource = tabla;
            }
        }

        private void CantidadStockYPrecioVenta_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryLibro = "SELECT nombre FROM libro";
            DataTable tablaLibro = conex.selectQuery(queryLibro);
            for (int i = 0; i < tablaLibro.Rows.Count; i++)
            {
                cboLibro.Items.Add(tablaLibro.Rows[i]["nombre"]);
            }
        }
    }
}
