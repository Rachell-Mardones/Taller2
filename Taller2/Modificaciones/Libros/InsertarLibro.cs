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
    public partial class InsertarLibro : Form
    {
        public InsertarLibro()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesLibros f = new ModificacionesLibros();
            this.Hide();
            f.Show();
        }

        private void InsertarLibro_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string c = "SELECT * FROM Categoria";
            DataTable categorias = conex.selectQuery(c);
            for (int i = 0; i < categorias.Rows.Count; i++)
            {
                listacategorias.Items.Add(categorias.Rows[i]["Nombre"]);
            }
        }

        private void BotonInsertarLibro_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string insertar = "INSERT INTO Libro( ISBN, Autor, Editorial, Anio, Idioma, Reseña, PrecioNeto, CantidadStock, PorcentajeDescuento) VALUES ( '"+isbn.Text+"', '"+autor.Text+"', '"+editorial.Text+"', '"+anio.Text+"', '"+idioma.Text+"', '"+reseña.Text+"', '"+precioneto.Text+"', '"+stock.Text+"', '"+descuento.Text+"')";
            int x = conex.executeNonQuery(insertar);


            string categoria = "SELECT ID FROM Categoria WHERE Nombre ='" + listacategorias.Text+"'";
            string codigocategoria = conex.selectQueryScalar(categoria);
            string insertarcategoria = "INSERT INTO Libro_Categoria(LibroISBN, CategoriaID) VALUES ('"+isbn.Text+"', '"+codigocategoria+"')";
            int y = conex.executeNonQuery(insertarcategoria);
            if (y == 1)
            {
                MessageBox.Show("se ingreso exitosamente");
            }
            else
            {
                MessageBox.Show("no se agrego");
            }

            conex.close();
        }

        
    }
}
