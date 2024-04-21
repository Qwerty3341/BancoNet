using System;
using System.Windows;
using System.Windows.Controls;

namespace Banco.UI
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
                            Console.WriteLine("Pablo");
                            break;
                        }
                    }
                }
            }
        }


    }
}
