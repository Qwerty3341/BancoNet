using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace Banco.Utilidades
{
    //Clase usada para verificar que los usuarios existan
    internal class ValidadorDeUsuarios
    {
        public bool ValidarUsuario(string username, string password)
        {
            return ValidarUsuarioCliente(username, password) || ValidarUsuarioEjecutivo(username, password);
        }

        private bool ValidarUsuarioCliente(string correo, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Banco.Properties.Settings.GestionBancoConnectionString"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM cliente WHERE correo=@correo AND contrasenia=@password", conexion);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@password", password);

                conexion.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }

        private bool ValidarUsuarioEjecutivo(string rfc, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Banco.Properties.Settings.GestionBancoConnectionString"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM ejecutivo WHERE rfc=@rfc AND contrasenia=@password", conexion);
                cmd.Parameters.AddWithValue("@rfc", rfc);
                cmd.Parameters.AddWithValue("@password", password);

                conexion.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 1;
            }
        }
    }
}
