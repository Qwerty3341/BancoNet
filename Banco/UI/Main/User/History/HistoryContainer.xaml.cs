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
    /// Interaction logic for HistoryContainer.xaml
    /// </summary>
    public partial class HistoryContainer : UserControl
    {
        public HistoryContainer()
        {
            InitializeComponent();

            HistoryChartContainer chartContainer = new HistoryChartContainer();
            Grid.SetColumn(chartContainer,0);
            HistoryContainerGrid.Children.Add(chartContainer);

            HistoryListContainer listContainer = new HistoryListContainer();
            Grid.SetColumn(listContainer,1);
            HistoryContainerGrid.Children.Add(listContainer);


        }
    }
}
