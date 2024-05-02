using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace Banco.Utilidades
{
    // Clase usada para verificar que los usuarios existan
    internal class ValidadorDeUsuarios
    {
        public static string ValidarUsuario(string username, string password)
        {
            if (ValidarCredenciales("cliente", "correo", username, password))
            {
                return "cliente";
            }
            else if (ValidarCredenciales("ejecutivo", "rfc", username, password))
            {
                return "ejecutivo";
            }
            else
            {
                return "null";
            }
        }

        private static bool ValidarCredenciales(string tabla, string columnaUsuario, string usuario, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Banco.Properties.Settings.GestionBancoConnectionString1"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = $"SELECT COUNT(1) FROM {tabla} WHERE {columnaUsuario}=@usuario AND contrasenia=@password";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@password", password);
                    try
                    {
                        conexion.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 1;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                        return false;
                    }
                    finally
                    {
                        conexion.Close();
                    }
                }
            }
        }
    }
}
