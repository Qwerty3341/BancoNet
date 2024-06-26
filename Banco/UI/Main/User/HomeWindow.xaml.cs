﻿using System.Windows;
using System.Windows.Controls;
using Banco.UI.Main.About;
using Banco.UI.Main.User.Account;
using Banco.UI.Main.User.History;
using Banco.UI.Main.User.Transfer;
using Banco.UI.Main.User.Withdraw;

namespace Banco.UI.Main.User
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
                        else if (textBlock.Text == "Transferir")
                        {
                            // Instancia el UserControl CuentasUserControl
                            TransferContainer transferContainer = new TransferContainer();

                            // Agrega el UserControl al Grid en la segunda columna
                            Grid.SetColumn(transferContainer, 1);
                            contentGrid.Children.Add(transferContainer);
                        }
                        else if (textBlock.Text == "Retirar")
                        {
                            // Instancia el UserControl CuentasUserControl
                            WithdrawContainer withdrawContainer = new WithdrawContainer();

                            // Agrega el UserControl al Grid en la segunda columna
                            Grid.SetColumn(withdrawContainer, 1);
                            contentGrid.Children.Add(withdrawContainer);
                        }
                        else if (textBlock.Text == "Acerca de...")
                        {
                            AboutPanel aboutPanel = new AboutPanel();

                            Grid.SetColumn(aboutPanel, 1);
                            contentGrid.Children.Add(aboutPanel);
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
