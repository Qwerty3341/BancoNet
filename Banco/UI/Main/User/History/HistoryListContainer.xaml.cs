using Banco.UI.Main.User.Account;
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

namespace Banco.UI.Main.User.History
{
    /// <summary>
    /// Interaction logic for HistoryListContainer.xaml
    /// </summary>
    public partial class HistoryListContainer : UserControl
    {
        public HistoryListContainer()
        {
            InitializeComponent();

            for (int i = 0; i < 2; i++)
            {
                HistoryDetail historyDetail = new HistoryDetail();
                if (i > 0)
                {
                    historyDetail.Margin = new Thickness(0, 10, 0, 0); // Margen de 5 unidades arriba
                }
                HistoryListStackPanel.Children.Add(historyDetail);
            }
            
        }
    }
}
