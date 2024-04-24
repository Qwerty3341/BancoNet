using Banco.UI.Main.User.History;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Banco.UI.Main.User.Transfer
{
    /// <summary>
    /// Interaction logic for TransferContainer.xaml
    /// </summary>
    public partial class TransferContainer : UserControl
    {
        public TransferContainer()
        {
            InitializeComponent();

            for (int i = 0; i < 2; i++)
            {
                TransferContactDetail transferContactDetail = new TransferContactDetail();
                if (i > 0)
                {
                    ContactList.Margin = new Thickness(0, 10, 0, 0); // Margen de 5 unidades arriba
                }
                ContactList.Children.Add(transferContactDetail);
            }
        }
    }
}
