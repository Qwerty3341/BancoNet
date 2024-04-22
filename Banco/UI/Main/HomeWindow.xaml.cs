using System;
using System.Windows;
using System.Windows.Controls;
using Banco.UI.Main.User.Account;
using Banco.UI.Main.User.Account;
using Banco.UI.Main.User.History;

namespace Banco.UI.Main
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (listBox.SelectedItem != null)
            {
                ListBoxItem selectedItem = (ListBoxItem)listBox.SelectedItem;
                StackPanel stackPanel = (StackPanel)selectedItem.Content;

                foreach (var item in stackPanel.Children)
                {
                    if (item is TextBlock)
                    {
                        TextBlock textBlock = (TextBlock)item;
                        if (textBlock.Text == "Cuentas")
                        {
                            // Instancia el UserControl CuentasUserControl
                            AccountList accList = new AccountList();

                            // Agrega el UserControl al Grid en la segunda columna
                            Grid.SetColumn(accList, 1);
                            contentGrid.Children.Add(accList);

                            break;
                        }
                        else if (textBlock.Text == "Movimientos")
                        {
                            // Instancia el UserControl CuentasUserControl
                            HistoryContainer historyContainer = new HistoryContainer();

                            // Agrega el UserControl al Grid en la segunda columna
                            Grid.SetColumn(historyContainer, 1);
                            contentGrid.Children.Add(historyContainer);
                            break;
                        }
                        else
                        {
                            EmptyPanel empty = new EmptyPanel();
                            Grid.SetColumn(empty, 1);
                            contentGrid.Children.Add(empty);
                        }
                    }
                }
            }
        }



    }
}
