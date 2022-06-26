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
    public partial class IngresarModificaciones : Form
    {

        
        public IngresarModificaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string c = "SELECT Clave FROM Contraseña";
            string clave = conex.selectQueryScalar(c);

            if (contraseña.Text != clave)
            {

                MessageBox.Show("Clave de administrador incorrecto.");


            }
            else
            {
                Modificaciones f2 = new Modificaciones();
                this.Hide();
                f2.Show();


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void IngresarModificaciones_Load(object sender, EventArgs e)
        {

        }

        
    }
}

