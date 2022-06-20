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
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesLibros f = new ModificacionesLibros();
            this.Hide();
            f.Show();
        }

        private void BotonAgregarCategoria_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string agregar = "INSERT INTO Categoria( Nombre) VALUES ('" + NombreCategoria.Text + "')";
            int x = conex.executeNonQuery(agregar);
            if ( x == 1)
            {
                MessageBox.Show("Se ingreso exitosamente");
            }
            conex.close();
            
        }
    }
}
