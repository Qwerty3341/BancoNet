using System.Windows.Controls;
using Banco.UI.Main.User.Account;

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

            for (int i = 0; i < 10; i++)
            {
                AccountStackPanel.Children.Add(new AccountDetails());
            }
        }
    }
}
