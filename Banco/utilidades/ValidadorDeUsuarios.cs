using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace Banco.Utilidades
{
    //Clase usada para verificar que los usuarios existan
    internal class ValidadorDeUsuarios
    {
        public static string ValidarUsuario(string username, string password)
        {
            if (ValidarUsuarioCliente(username, password))
            {
                return "cliente";
            }
            else if (ValidarUsuarioEjecutivo(username, password))
            {
                return "ejecutivo";
            }
            else
            {
                return "null";
            }
        }

        private static bool ValidarUsuarioCliente(string correo, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Banco.Properties.Settings.GestionBancoConnectionString1"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM cliente WHERE correo=@correo AND contrasenia=@password", conexion);
                conexion.Open();
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@password", password);

                
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.Close();
                return count == 1;
            }
        }

        private static bool ValidarUsuarioEjecutivo(string rfc, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Banco.Properties.Settings.GestionBancoConnectionString1"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM ejecutivo WHERE rfc=@rfc AND contrasenia=@password", conexion);
                conexion.Open();
                cmd.Parameters.AddWithValue("@rfc", rfc);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conexion.Close ();
                return count == 1;
            }
        }
    }
}
