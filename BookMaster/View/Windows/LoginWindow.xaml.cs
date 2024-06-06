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
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void CancelBTN_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text == "1" && PasswordPb.Password == "1")
            {
                DialogResult = true;
                MessageBox.Show("Вы успешно вошли в систему", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                DialogResult = false;
                MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
