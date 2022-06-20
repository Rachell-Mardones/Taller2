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
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesEmpleados f = new ModificacionesEmpleados();
            this.Hide();
            f.Show();
        }

        private void BotonAgregarEmpleado_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            
            string agregar = "INSERT INTO Empleado(Rut, Nombre,Salario,Fecha) VALUES ('"+rut.Text+"', '"+nombre.Text+"','"+salario.Text+"','"+fecha.Text+"')";
            int x=conex.executeNonQuery(agregar);
            if (x == 1)
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
