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
    public partial class CambiarSalario : Form
    {
        public CambiarSalario()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesEmpleados f = new ModificacionesEmpleados();
            this.Hide();
            f.Show();
        }

        private void BotonBuscarEmpleado_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();


            /*string c = "SELECT * FROM Empleado";
            DataTable c1 = conex.selectQuery(c);
            for (int i = 0; i < c1.Rows.Count; i++)
            {
                cboRut.Items.Add(c1.Rows[i]["Rut"]);
            }*/



            string buscarsaldo = "SELECT Salario FROM Empleado WHERE Rut ='" +cboRut.Text+ "'";
            string saldo = conex.selectQueryScalar(buscarsaldo);
            salarioactual.Text = saldo;

            conex.close();

        }

        private void ActualizarSaldo_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string actualizarsaldo = "UPDATE Empleado SET Salario = '" +saldonuevo.Text+ "' WHERE Rut = '" +cboRut.Text+ "'";
            int x = conex.executeNonQuery(actualizarsaldo);
            if (x == 1)
            {
                MessageBox.Show("se actualizo exitosamente");
            }
            else
            {
                MessageBox.Show("no se actualizo");
            }
            conex.close();


        }

        private void CambiarSalario_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string c = "SELECT * FROM Empleado";
            DataTable c1 = conex.selectQuery(c);
            for (int i = 0; i < c1.Rows.Count; i++)
            {
                cboRut.Items.Add(c1.Rows[i]["Rut"]);
            }
        }
    }
}
