using System.Windows;
using Banco.UI.Main;
using System.Configuration;
using System.Data.SqlClient;

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
            string conectionString = ConfigurationManager.ConnectionStrings["Banco.properties.Settings.GestionLibreriaConnectionString"].ConnectionString; //[nombreProyecto,.Properties.Settings.cadenaGuardada]
            using (SqlConnection conexion = new SqlConnection(conectionString))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("Base de datos conectada");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Conexion fallida");
                }
            }
        }

        private void TextBox_TextChanged()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();
        }
    }
}
