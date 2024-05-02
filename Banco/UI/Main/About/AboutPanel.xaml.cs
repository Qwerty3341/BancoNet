using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Banco.UI.Main.About
{
    /// <summary>
    /// Interaction logic for AboutPanel.xaml
    /// </summary>
    public partial class AboutPanel : UserControl
    {
        public AboutPanel()
        {
            InitializeComponent();

            string filePath = "C:/Users/ndahai/source/repos/Qwerty3341/BancoNet/Banco/UI/Main/About/AboutText.txt";

            try
            {
                string text = File.ReadAllText(filePath);
                AboutText.Text = text;
                Console.WriteLine("LEIDO");
            }
            catch (IOException ex)
            {
                AboutText.Text = $"Error al leer el archivo: {ex.Message}";
            }
        
        }
    }
}
