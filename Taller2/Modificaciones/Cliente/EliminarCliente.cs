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
    public partial class EliminarCliente : Form
    {
        
        public EliminarCliente()
        {

            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesCliente f = new ModificacionesCliente();
            this.Hide();
            f.Show();
        }

       

        /*private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (cboEliminarCliente.Text != "")
            {
                EliminarCliente del = new EliminarCliente();
                del.SetNombreCliente(cboEliminarCliente.Text);                               
                del.Show();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
        }*/


        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();

            string query = "UPDATE Cliente SET Estado =" + 0 + " WHERE Rut ='" + cboEliminarCliente.Text + "'";

            int con = conex.executeNonQuery(query);
            if (con == 1)
            {

                MessageBox.Show("Se ha eliminado la cuenta del cliente: " + cboEliminarCliente.Text + "");

            }
            else
            {
                MessageBox.Show("No se ha podido eliminar la cuenta.");
            }
            conex.close();

        }
             
        
        private void EliminarCliente_Load(object sender, EventArgs e)
        {
            ConexMySQL conex = new ConexMySQL();
            conex.open();
            string queryComboCli = "SELECT Rut FROM Cliente";
            DataTable tablaCli = conex.selectQuery(queryComboCli);
            for (int i = 0; i < tablaCli.Rows.Count; i++)
            {
                cboEliminarCliente.Items.Add(tablaCli.Rows[i]["rut"]);
            }

        }

        private void cboEliminarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
