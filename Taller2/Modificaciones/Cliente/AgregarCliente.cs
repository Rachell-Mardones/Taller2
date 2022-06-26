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
    public partial class AgregarCliente : Form
    {

        
        public AgregarCliente()
        {
            InitializeComponent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModificacionesCliente f = new ModificacionesCliente();
            this.Hide();
            f.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

            try {

                String nombre = textNombre.Text;
                String rut = textRut.Text;
                int saldo = int.Parse(textSaldo.Text);
                String contraseña = textContraseña.Text;
                String email= textEmail.Text;
                Boolean estado = true;
                int descuento = 0;

                if (estado)
                {                
                    if(nombre != "" && rut != "" && saldo >= 0 && contraseña != "" && email != "" )
                    {
                        string query = "INSERT INTO cliente (rut,nombre,saldo,contraseña,email,estado,descuento) values(@rut,@nombre,@saldo,@contraseña,@email,@estado,@descuento)";
            
                        ConexMySQL conex = new ConexMySQL();
                        conex.open();

                        MySqlCommand cmd = new MySqlCommand(query, conex.getConexion());
           
                        cmd.Parameters.AddWithValue("@rut", textRut.Text);
                        cmd.Parameters.AddWithValue("@nombre", textNombre.Text);
                        cmd.Parameters.AddWithValue("@saldo", textSaldo.Text);
                        cmd.Parameters.AddWithValue("@contraseña", textContraseña.Text);
                        cmd.Parameters.AddWithValue("@email", textEmail.Text);
                        cmd.Parameters.AddWithValue("@estado", true);
                        cmd.Parameters.AddWithValue("@descuento", 0);


                        MySqlCommand cmd2 = new MySqlCommand("Select rut from cliente Where rut = @Aux", conex.getConexion());
            
                        cmd2.Parameters.AddWithValue("@Aux", textRut.Text);

                        try
                        {
                            MySqlCommand comando = new MySqlCommand(query, conex.getConexion());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cliente guardado");

                        }
                        catch (MySqlException ex)
                        {
                
                            MessageBox.Show("Error al guardar: " + ex.Message);

                        }
                        finally
                        {
                            conex.close();
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar todos los campos");
                    }
                }

            }
            catch(FormatException fex)
            {
                MessageBox.Show("Datos incorrectos " + fex.Message);
            }


        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSaldo_TextChanged(object sender, EventArgs e)
        {

        }
             
   
    }
}



