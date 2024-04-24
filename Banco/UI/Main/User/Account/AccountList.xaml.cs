using System.Windows;
using System.Windows.Controls;
using Banco.UI.Main.User.Account;
using Banco.UI.Main.User.History;

namespace Banco.UI.Main.User.Account
{
    /// <summary>
    /// Interaction logic for AccountList.xaml
    /// </summary>
    public partial class AccountList : UserControl
    {
        public AccountList()
        {
            InitializeComponent();

            for (int i = 0; i < 2; i++)
            {
                AccountDetails accDetails = new AccountDetails();
                if (i > 0)
                {
                    accDetails.Margin = new Thickness(0, 10, 0, 0); // Margen de 5 unidades arriba
                }
                AccountStackPanel.Children.Add(accDetails);
            }
        }
    }
}
