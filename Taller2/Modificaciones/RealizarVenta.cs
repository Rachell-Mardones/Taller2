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

            string c = "SELECT * FROM Cliente";
            DataTable c1 = conex.selectQuery(c);
            for (int i = 0; i < c1.Rows.Count; i++)
            {
                listacliente.Items.Add(c1.Rows[i]["Rut"]);
            }

            string v = "SELECT * FROM Empleado";
            DataTable v1 = conex.selectQuery(v);
            for (int i = 0; i < v1.Rows.Count; i++)
            {
                listavendedor.Items.Add(v1.Rows[i]["Rut"]);
            }


        }

        private void ingresardatosventa_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            if (string.IsNullOrWhiteSpace(listacliente.Text) || string.IsNullOrWhiteSpace(listavendedor.Text))
            {
                MessageBox.Show("Complete los campos");
            }
            else
            {
                string cliente = "SELECT Nombre FROM Cliente WHERE Rut = '" + listacliente.Text + "'";
                string buscarcliente = conex.selectQueryScalar(cliente);

                string vendedor = "SELECT Nombre FROM Empleado WHERE Rut = '" + listavendedor.Text + "'";
                string buscarvendedor = conex.selectQueryScalar(vendedor);

                string datosventa = "INSERT INTO Venta(Comprador, Vendedor, EmpleadoRut, ClienteRut, Fecha, Hora) VALUES ('" + buscarcliente + "', '" + buscarvendedor + "','" + listavendedor.Text + "', '" + listacliente.Text + "','" + fecha.Text + "', '" + hora.Text + "')";
                

                DetalleVenta f = new DetalleVenta();
                this.Hide();
                f.Show();
            }
            

            
            conex.close();
            
            
        }
    }
}
