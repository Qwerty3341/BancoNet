using System.Windows;
using Banco.UI.Main;
using System.Configuration;
using System.Data.SqlClient;
using Banco.Utilidades;
using Banco.UI.Main.User;
using System.Windows.Controls;

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
            string connectionString = ConfigurationManager.ConnectionStrings["Banco.Properties.Settings.GestionBancoConnectionString1"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString)
                {
                    ConnectTimeout = 30 // Tiempo de espera más largo para conexión
                };

                try
                {
                    conexion.Open();
                    MessageBox.Show("Base de datos conectada");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Conexión fallida: " + ex.Message);
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Implementar lógica si es necesario cuando el texto cambia
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombreUsuario = txtUsername.Text;
            string contrasenia = txtPassword.Password;

            string resultado = ValidadorDeUsuarios.ValidarUsuario(nombreUsuario, contrasenia);
            switch (resultado)
            {
                case "cliente":
                    break;
                case "ejecutivo":
                    break;
                case "admin":
                    if (nombreUsuario == "admin" && contrasenia == "admin")
                    {
                        HomeWindow homeWindow = new HomeWindow();
                        homeWindow.Show();
                        this.Close();
                    }
                    break;
                default:
                    MessageBox.Show("ERROR: Nombre de usuario o contraseña incorrectos.");
                    break;
            }
        }
    }
}
