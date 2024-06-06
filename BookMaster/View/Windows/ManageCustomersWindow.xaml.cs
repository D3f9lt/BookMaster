using BookMaster.Model;
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

namespace BookMaster.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для ManageCustomers.xaml
    /// </summary>
    public partial class ManageCustomers : Window
    {
        public ManageCustomers()
        {
            InitializeComponent();

            ManageCustomersLv.ItemsSource = App.context.Customer.ToList();
        }

        private void Btn_Cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ManageCustomerLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ManageCustomersLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ManageCustomersLv.SelectedItem != null)
            {
                AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow(ManageCustomersLv.SelectedItem as Customer);
                if (addEditCustomerWindow.ShowDialog() == true)
                {
                    // Обновление списка
                    ManageCustomersLv.ItemsSource = App.context.Customer.ToList();
                }
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditCustomerWindow addEditCustomerWindow = new AddEditCustomerWindow(ManageCustomersLv.SelectedItem as Customer);
            if (addEditCustomerWindow.ShowDialog() == true)
            {
                // Обновление списка
                ManageCustomersLv.ItemsSource = App.context.Customer.ToList();
            }
        }
    }
}
    

