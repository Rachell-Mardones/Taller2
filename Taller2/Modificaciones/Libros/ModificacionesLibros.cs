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
    public partial class ModificacionesLibros : Form
    {
        public ModificacionesLibros()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertarLibro f = new InsertarLibro();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AumentarStock f = new AumentarStock();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ModificarDescuento f = new ModificarDescuento();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarCategoria f = new AgregarCategoria();
            this.Hide();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Modificaciones f = new Modificaciones();
            this.Hide();
            f.Show();
        }
    }
}
