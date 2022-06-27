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
            

            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string L = "SELECT * FROM Libro";
            DataTable L1 = conex.selectQuery(L);
            for (int i = 0; i < L1.Rows.Count; i++)
            {
                listalibro.Items.Add(L1.Rows[i]["Nombre"]);
            }

        }

        private void calculartotal_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string dato8 = "SELECT CantidadStock FROM Libro WHERE Nombre = '" + listalibro.Text + "'";
            string a8 = conex.selectQueryScalar(dato8);
            Double stock1 = Double.Parse(a8);
            Double num_cant = Double.Parse(cantidad.Text);
            if (stock1 < num_cant)
            {
                MessageBox.Show("No hay suficientes libros");
            }
            else
            {
                string dato = "SELECT Autor FROM Libro WHERE Nombre = '" + listalibro.Text + "'";
                string a = conex.selectQueryScalar(dato);
                autor.Text = a;

                string dato2 = "SELECT PrecioNeto FROM Libro WHERE Nombre = '" + listalibro.Text + "'";
                string a2 = conex.selectQueryScalar(dato2);
                neto.Text = a2;
                int num_neto = Int32.Parse(a2);

                string dato3 = "SELECT PorcentajeDescuento FROM Libro WHERE Nombre = '" + listalibro.Text + "'";
                string a3 = conex.selectQueryScalar(dato3);
                descuento.Text = a3;
                int num_descuento = Int32.Parse(a3);


                //valor
                double valorint = (((num_cant * num_neto) * (100 - num_descuento)) / 100);
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
                String tpagarstring = tpagarint.ToString();
                totalpagar.Text = tpagarstring;
            }
            
            
                


                conex.close();
            


            
        }

        private void BotonComprar_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string dato4 = "SELECT  Comprador FROM Venta WHERE ID = (SELECT MAX(ID) FROM Venta)";
            string a4 = conex.selectQueryScalar(dato4);
            string dato5 = "SELECT Saldo FROM Cliente WHERE Nombre = '" + a4 + "'";
            string a5 = conex.selectQueryScalar(dato5);
            Double sald = Double.Parse(a5);
            Double tpagar = Double.Parse(totalpagar.Text);
            if (tpagar > sald)
            {
                MessageBox.Show("No se puede realizada la venta, saldo insuficiente");
            }
            else
            {
                string dato = "SELECT ISBN FROM Libro WHERE Nombre = '" + listalibro.Text + "'";
                string a = conex.selectQueryScalar(dato);


                //el id de la venta
                string idventa = "SELECT MAX(ID) FROM Venta";
                string idv = conex.selectQueryScalar(idventa);

                //insertar los datos a la tabla detalle_de_venta
                string Detalle = "INSERT INTO DetalleDeVenta(Autor, Nombre, Cantidad, Neto, Descuento, Valor, TotalAPagar, DescuentoCliente, VentaID) VALUES('" + autor.Text + "','" + listalibro.Text + "','" + cantidad.Text + "','" + neto.Text + "','" + descuento.Text + "','" + valor.Text + "','" + totalpagar.Text + "','" + descuentocliente.Text + "','" + idv + "')";
                int q = conex.executeNonQuery(Detalle);
                if (q == 1)
                {
                    MessageBox.Show("Compra realizada");
                }
                else
                {
                    MessageBox.Show("No se pudo realizada la compra");
                }

                //agregar libro al detalleventa_libro

                string detalleventa_libro = "INSERT INTO Libro_DetalleDeVenta(LibroISBN, DetalleDeVentaID) VALUES('" + a + "','" + idv + "')";
                int w = conex.executeNonQuery(detalleventa_libro);
                
            }







            conex.close();

            listalibro.Text = "";
            cantidad.Text = "";
            autor.Text = "";
            neto.Text = "";
            descuento.Text = "";
            valor.Text = "";
            totalneto.Text = "";
            totaliva.Text = "";
            total.Text = "";
            descuentocliente.Text = "";
            totalpagar.Text = "";



        }
    }
}
