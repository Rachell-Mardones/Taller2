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
    public partial class RealizarVenta : Form
    {
        public RealizarVenta()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesEmpleados f = new ModificacionesEmpleados();
            this.Hide();
            f.Show();
            
        }

        private void RealizarVenta_Load(object sender, EventArgs e)
        {
            fecha.ReadOnly = true;
            hora.ReadOnly = true;
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            hora.Text = DateTime.Now.ToString("HH:mm");


            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string s = "SELECT STR_TO_DATE('" + fecha.Text + "', '%e %M %Y')";
            string q = conex.selectQueryScalar(s);
            MessageBox.Show(q);

        }

        private void ingresardatosventa_Click(object sender, EventArgs e)
        {
            

            ConexMySQL conex = new ConexMySQL();
            conex.open();


            


            if (string.IsNullOrWhiteSpace(rutcliente.Text) || string.IsNullOrWhiteSpace(rutvendedor.Text))
            {
                MessageBox.Show("Complete los campos");
            }
            else
            {
                string cliente = "SELECT Nombre FROM Cliente WHERE Rut = '" + rutcliente.Text + "'";
                string buscarcliente = conex.selectQueryScalar(cliente);

                string vendedor = "SELECT Nombre FROM Empleado WHERE Rut = '" + rutvendedor.Text + "'";
                string buscarvendedor = conex.selectQueryScalar(vendedor);

                string datosventa = "INSERT INTO Venta(Comprador, Vendedor, EmpleadoRut, ClienteRut, Fecha, Hora) VALUES ('" + buscarcliente + "', '" + buscarvendedor + "','" + rutvendedor.Text + "', '" + rutcliente.Text + "','" + fecha.Text + "', '" + hora.Text + "')";
                

                DetalleVenta f = new DetalleVenta();
                this.Hide();
                f.Show();
                

                
                
            }
            

            
            conex.close();
            
            
        }
    }
}
