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
            string conectionString = ConfigurationManager.ConnectionStrings["Banco.Properties.Settings.GestionBancoConnectionString"].ConnectionString;

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
        //private void button_click(object sender, routedeventargs e)
        //{

        //    //aqui se validara que el usuario exista

        //    string nombreusuario = txtusername.text;
        //    string contrasenia = txtpassword.password;

        //    if (validarusuario(nombreusuario, contrasenia))
        //    {
        //        homewindow homewindow = new homewindow();
        //        homewindow.show();
        //        this.close();
        //    }
        //    else
        //    {
        //        messagebox.show("nombre o contraseña incorrectos");
        //    }

        //}
    }
}
