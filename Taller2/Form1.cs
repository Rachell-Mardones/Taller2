using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp1;

namespace Taller2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConexMySQL coneccion = new ConexMySQL();
            coneccion.open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresarModificaciones f = new IngresarModificaciones();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultas f = new Consultas();
            this.Hide();
            f.Show();
        }
    }
}