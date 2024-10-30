using App1MensajeriaCliente;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1Mensajeria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var ClienteForm = new ClienteChatForm(txtIP.Text, txtPuerto.Text);
            ClienteForm.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the "Guardar" button
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            // Recoger los valores de los TextBox
            string nombreUsuario = txtUsernameNew.Text;
            string direccionIP = txtIP.Text;
            int puerto = int.Parse(txtPuerto.Text);

            // Cadena de conexión a la base de datos SQL Server
            string connectionString = "Data Source=;Initial Catalog=TeleChat;User ID=usuario;Password=contraseña";
            // La consulta SQL de inserción
            string insertQuery = "INSERT INTO Usuarios (Username, IpNumber, Puerto) VALUES (@NombreUsuario, @DireccionIP, @Puerto)";
            // Conexión a la base de datos y ejecución de la consulta
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear el comando SQL
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Agregar los parámetros para prevenir inyecciones SQL
                        command.Parameters.AddWithValue("@Username", nombreUsuario);
                        command.Parameters.AddWithValue("@IpNumber", direccionIP);
                        command.Parameters.AddWithValue("@Puerto", puerto);

                        // Ejecutar la consulta
                        int result = command.ExecuteNonQuery();

                        // Verificar si se insertó una fila
                        if (result > 0)
                        {
                            MessageBox.Show("Datos guardados exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar los datos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
