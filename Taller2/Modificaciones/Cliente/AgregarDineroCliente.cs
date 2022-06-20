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
    public partial class AgregarDineroCliente : Form
    {
        public AgregarDineroCliente()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesCliente f = new ModificacionesCliente();
            this.Hide();
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "UPDATE Cliente SET Saldo = Saldo+'" + textDinero.Text + "' WHERE Rut ='" + cboRutCliente.Text + "'";
            int con = conex.executeNonQuery(query);

            if (con == 1)
            {

                MessageBox.Show("Se han agregado :" + textDinero.Text + " a la cuenta");

            }
            else
            {
                MessageBox.Show("No se ha podido actualizar el saldo");
            }
            conex.close();

        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AgregarDineroCliente_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryComboCli = "SELECT Rut FROM Cliente";
            DataTable tablaCli = conex.selectQuery(queryComboCli);
            for (int i = 0; i < tablaCli.Rows.Count; i++)
            {
                cboRutCliente.Items.Add(tablaCli.Rows[i]["rut"]);
            }
        }
    }
}
