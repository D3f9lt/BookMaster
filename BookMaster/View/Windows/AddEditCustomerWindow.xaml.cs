using BookMaster.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
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
    /// Логика взаимодействия для AddEditCustomerWindow.xaml
    /// </summary>
    public partial class AddEditCustomerWindow : Window
    {
        public AddEditCustomerWindow()
        {
            InitializeComponent();

            
            
        }

        public AddEditCustomerWindow(Customer selectedCustomer)
        {
            InitializeComponent();

            DataContext = selectedCustomer;

            
            
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Добавление записи в БД
                // Создаем объект (запись для БД)
                Customer newCustomer = new Customer()
                {
                    Fullname = NameTb.Text,
                    Adress = AddressTb.Text,
                    ZipCode = Convert.ToInt32(ZipTb.Text),
                    City = CityTb.Text,
                    Phone = PhoneTb.Text,
                    Email = EmailTb.Text
                };

                // 2) Добавляем объект в таблицу
                App.context.Customer.Add(newCustomer);

                // 3) Сохраняем изменения
                App.context.SaveChanges();

                // 4) Уведомить пользователя
                MessageBox.Show("Запись успешно добавлена!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);

                DialogResult = true;
            }
            catch
            {
                MessageBox.Show("Данные введены некорректно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}