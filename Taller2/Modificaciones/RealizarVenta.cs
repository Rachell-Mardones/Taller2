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
            fecha.Text = DateTime.Now.ToString("dd/MM/yyyy") + " / " + DateTime.Now.ToString("HH:mm");
        }

        private void ingresardatosventa_Click(object sender, EventArgs e)
        {
            

            ConexMySQL conex = new ConexMySQL();
            conex.open();

            

            string cliente = "SELECT Nombre FROM Cliente WHERE Rut = '" + rutcliente.Text + "'";
            string buscarcliente = conex.selectQueryScalar(cliente);
            string vendedor = "SELECT Nombre FROM Empleado WHERE Rut = '" + rutvendedor.Text + "'";
            string buscarvendedor = conex.selectQueryScalar(vendedor);
            string datosventa = "INSERT INTO Venta(Comprador, Vendedor, Fecha, EmpleadoRut, ClienteRut) VALUES ('" + buscarcliente + "', '" + buscarvendedor + "', '" +fecha.Text  + "', '" + rutvendedor.Text + "', '" + rutcliente.Text + "')";

            int x = conex.executeNonQuery(datosventa);
            if (x == 1)
            {
                MessageBox.Show("se ingreso exitosamente");
            }
            else
            {
                MessageBox.Show("no se agrego");
            }
            conex.close();



            DetalleVenta f = new DetalleVenta();
            this.Hide();
            f.Show();
        }
    }
}
