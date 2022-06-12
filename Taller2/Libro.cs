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
    public partial class Libro : Form
    {
        public Libro()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Consultas f = new Consultas();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibrosMasVendidos_12_ f = new LibrosMasVendidos_12_();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LibrosMasVendidos_13_ f = new LibrosMasVendidos_13_();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LibrosPorCategoria f = new LibrosPorCategoria();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LibrosPorAutor f = new LibrosPorAutor();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LibrosPorCaracter f = new LibrosPorCaracter();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LibrosCompradosPorCliente f = new LibrosCompradosPorCliente();
            this.Hide();
            f.Show();
        }
    }
}
