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
    public partial class LibrosCompradosPorCliente : Form
    {
        public LibrosCompradosPorCliente()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Libro f = new Libro();
            this.Hide();
            f.Show();
        }
    }
}
