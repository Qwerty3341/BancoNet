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
            string miConexion = ConfigurationManager.ConnectionStrings["Banco.properties.Settings.GestionLibreriaConnectionString"].ConnectionString; //[nombreProyecto,.Properties.Settings.cadenaGuardada]
            miConexionSQL = new SqlConnection(miConexion);
        }

        SqlConnection miConexionSQL;

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
