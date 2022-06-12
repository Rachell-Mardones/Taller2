using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string clave = textBox1.Text;

            if (clave != "123456")
            {

                MessageBox.Show("Clave de administrador incorrecto ");


            }
            else
            {
                Modificaciones f2 = new Modificaciones();
                this.Hide();
                f2.Show();

            }
        }
    }
}
