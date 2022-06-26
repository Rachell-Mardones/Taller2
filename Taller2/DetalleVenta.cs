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
    public partial class DetalleVenta : Form
    {
        public DetalleVenta()
        {
            InitializeComponent();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            autor.ReadOnly = true;
            neto.ReadOnly = true;
            descuento.ReadOnly = true;
            valor.ReadOnly = true;
            totalneto.ReadOnly = true;
            totaliva.ReadOnly = true;
            total.ReadOnly = true;
            descuentocliente.ReadOnly = true;
            totalpagar.ReadOnly = true;
        }

        private void calculartotal_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string dato = "SELECT Autor FROM Libro WHERE Nombre = '" + nombrelibro.Text + "'";
            string a = conex.selectQueryScalar(dato);
            autor.Text = a;

            string dato2 = "SELECT PrecioNeto FROM Libro WHERE Nombre = '" + nombrelibro.Text + "'";
            string a2 = conex.selectQueryScalar(dato2);
            neto.Text = a2;
            int num_neto = Int32.Parse(a2);

            string dato3 = "SELECT PorcentajeDescuento FROM Libro WHERE Nombre = '" + nombrelibro.Text + "'";
            string a3 = conex.selectQueryScalar(dato3);
            descuento.Text = a3;
            int num_descuento = Int32.Parse(a3);

            
            //valor
            Double num_cant = Double.Parse(cantidad.Text);
            double valorint = (((num_cant*num_neto)*(100 - num_descuento))/100);
            string valorstring = valorint.ToString();
            valor.Text = valorstring;

            
            //total neto
            totalneto.Text = valor.Text;

            //total iva
            double total_iva = valorint * 0.19;
            String totalivastring = total_iva.ToString();
            totaliva.Text = totalivastring;
            
            //total (neto+iva)
            double tnetoiva = valorint + total_iva;
            String tnetoibastring = tnetoiva.ToString();
            total.Text = tnetoibastring;
            
            //descuento cliente
            string dato4 = "SELECT  Comprador FROM Venta WHERE ID = (SELECT MAX(ID) FROM Venta)";
            string a4 = conex.selectQueryScalar(dato4);
            string dato5 = "SELECT Descuento FROM Cliente WHERE Nombre = '" + a4 + "'";
            string a5 = conex.selectQueryScalar(dato5);
            descuentocliente.Text = a5;
            Double descuentoc = Double.Parse(descuentocliente.Text);
            
            //total a pagar (total(neto+iva)*descuento)
            double tpagar = ((tnetoiva * (100 - descuentoc)) / 100);
            int tpagarint = (int)tpagar;
            String tpagarstring= tpagarint.ToString();
            totalpagar.Text = tpagarstring;
            

            conex.close();
        }

        private void BotonComprar_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string dato = "SELECT ISBN FROM Libro WHERE Nombre = '" + nombrelibro.Text + "'";
            string a = conex.selectQueryScalar(dato);
           

            //el id de la venta
            string idventa = "SELECT MAX(ID) FROM Venta";
            string idv = conex.selectQueryScalar(idventa);

            //insertar los datos a la tabla detalle_de_venta
            string Detalle = "INSERT INTO DetalleDeVenta(Autor, Nombre, Cantidad, Neto, Descuento, Valor, TotalAPagar, DescuentoCliente, VentaID) VALUES('" + autor.Text + "','" + nombrelibro.Text + "','" + cantidad.Text + "','" + neto.Text + "','" + descuento.Text + "','" + valor.Text + "','" + totalpagar.Text + "','" + descuentocliente.Text + "','" + idv + "')";
            int q = conex.executeNonQuery(Detalle);
            if (q == 1)
            {
                MessageBox.Show("Compra realzada");
            }
            else
            {
                MessageBox.Show("No se pudo resalizar la compra");
            }
    
            //agregar libro al detalleventa_libro
            string detalleventa_libro = "INSERT INTO Libro_DetalleDeVenta(LibroISBN, DetalleDeVentaID) VALUES('" + idv + "','" + a + "')";
            int x = conex.executeNonQuery(detalleventa_libro);
            
            //verificar que al loquito le alcance el saldo
            //verificar si los libros existen y que tengan stock

            conex.close();
        }
    }
}
