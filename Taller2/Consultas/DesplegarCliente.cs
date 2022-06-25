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
    public partial class DesplegarCliente : Form
    {
        public DesplegarCliente()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Consultas f = new Consultas();
            this.Hide();
            f.Show();
        }

        private void cboRutCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerDatos_Click(object sender, EventArgs e)
        {
            if (cboRutCliente.Text != "")
            {
                string query1 = "";

                ConexMySQL conex = new ConexMySQL();
                conex.open();
                try
                {
                    string queryRut = "SELECT rut FROM Cliente WHERE rut= '" + cboRutCliente.Text + "'";
                    query1 = conex.selectQueryScalar(queryRut);
                }
                catch (Exception error)
                {
                    string error1 = error.ToString();

                }
                                
                string queryFinal = "select distinct c.nombre, c.email, c.saldo, SUM(dv.TotalAPagar), v.fecha from cliente as c inner join venta as v on c.Rut = v.ClienteRut inner join detalledeventa as dv on v.ID = dv.VentaID where Rut = '" + query1 + "' and v.fecha >= date_sub(NOW(), INTERVAL 3 month)";
                DataTable tabla = conex.selectQuery(queryFinal);
                dataGridView1.DataSource = tabla;
            }
        }

        private void DesplegarCliente_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryLibro = "SELECT rut FROM Cliente";
            DataTable tablaLibro = conex.selectQuery(queryLibro);
            for (int i = 0; i < tablaLibro.Rows.Count; i++)
            {
                cboRutCliente.Items.Add(tablaLibro.Rows[i]["rut"]);
            }
        }
    }
}
