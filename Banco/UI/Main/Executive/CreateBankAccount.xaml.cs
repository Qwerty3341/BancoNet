using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Banco.UI.Main.Executive
{
    /// <summary>
    /// Interaction logic for CreateBankAccount.xaml
    /// </summary>
    public partial class CreateBankAccount : Window
    {
        public CreateBankAccount()
        {
            InitializeComponent();

            List<string> items = new List<string>
            {
                "Elemento 1",
                "Elemento 2",
                "Elemento 3"
            };

            // Asignar la lista como origen de datos para el ComboBox
            tiposCuenta.ItemsSource = items;
        }
    }
}
