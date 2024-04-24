using System.Windows;
using Banco.UI.Main;
using System.Configuration;
using System.Data.SqlClient;
using System;
using Banco.UI.Main.User;

namespace Banco.UI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ConectarALaBase();
        }

        private void ConectarALaBase()
        {
            string conectionString = ConfigurationManager.ConnectionStrings["Banco.Properties.Settings.GestionBancoConnectionString1"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(conectionString))
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(conectionString);
                builder.ConnectTimeout = 1;
                conexion.ConnectionString = builder.ConnectionString;
                try
                {
                    conexion.Open();
                    MessageBox.Show("Base de datos conectada");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Conexion fallida " + ex.Message);
                }
            }
        }

        private void TextBox_TextChanged()
        {

        }

        //Metodo temporal en lo que se implementan las validaciones
        private void Button_Click(object sender, RoutedEventArgs e)
        {

                HomeWindow homeWindow = new HomeWindow();
                homeWindow.Show();
                this.Close();
        }

            
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //        //Aqui se validara que el usuario exista

        //    string nombreUsuario = txtUsername.Text;
        //    string contrasenia = txtPassword.Password;

        //    if (ValidarUsuario(nombreUsuario, contrasenia))
        //    {
        //        HomeWindow homeWindow = new HomeWindow();
        //        homeWindow.Show();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nombre o contraseña incorrectos");
        //    }

        //}

        //private bool ValidarUsuario(string username, string password)
        //{
        //    return ValidarUsuarioCliente(username, password) || ValidarUsuarioEjecutivo(username, password) ;
        //}

        //private bool ValidarUsuarioCliente(string nombre, string password)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["Banco.Properties.Settings.GestionBancoConnectionString"].ConnectionString;
        //    using (SqlConnection conexion = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM cliente WHERE nombre=@nombre AND contrasenia=@password", conexion);
        //        cmd.Parameters.AddWithValue("@nombre", nombre);
        //        cmd.Parameters.AddWithValue("@password", password);

        //        conexion.Open();
        //        int count = Convert.ToInt32(cmd.ExecuteScalar());
        //        return count == 1;
        //    }
        //}

        //private bool ValidarUsuarioEjecutivo(string rfc, string password)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["Banco.Properties.Settings.GestionBancoConnectionString"].ConnectionString;
        //    using (SqlConnection conexion = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM ejecutivo WHERE rfc=@rfc AND contrasenia=@password", conexion);
        //        cmd.Parameters.AddWithValue("@rfc", rfc);
        //        cmd.Parameters.AddWithValue("@password", password);

        //        conexion.Open();
        //        int count = Convert.ToInt32(cmd.ExecuteScalar());
        //        return count == 1;
        //    }
        //}
            
        }
}
