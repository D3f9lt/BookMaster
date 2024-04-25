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
    /// Логика взаимодействия для BrowseCatalogWindow.xaml
    /// </summary>
    public partial class BrowseCatalogWindow : Window
    {
        public BrowseCatalogWindow()
        {
            InitializeComponent();

            // Загружаем данные из БД в ListView
            BookAuthorsLv.ItemsSource = App.context.BookAuthor.ToList();
            CountOfBooksTbl.DataContext = App.context.Book.ToList();

            // Выбираем элемент из списка по его индексу
            BookAuthorsLv.SelectedIndex = 0;

            // Прячем элементы меню
            LogoutMi.Visibility = Visibility.Collapsed;
            LibraryMi.Visibility = Visibility.Collapsed;
        }

        // Отслеживаем изменение выбора в ListView
        private void BookAuthorsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Загружаем в контекст днных Grid'а с выбранный элемент из ListView (для реализации привязки элемента)
            BookDetailsGrid.DataContext = BookAuthorsLv.SelectedItem as BookAuthor;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // Открывем окно в режиме диалогового
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();

            LoginMi.Visibility = Visibility.Collapsed;
            LoginMi.Visibility = Visibility.Visible;
            LibraryMi.Visibility = Visibility.Visible;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginMi.Visibility = Visibility.Visible;
            LoginMi.Visibility = Visibility.Collapsed;
            LibraryMi.Visibility = Visibility.Collapsed;
        }

        private void CloseMi_Click(object sender, RoutedEventArgs e)
        {
            // Закрываем текущее окно
            Close();
        }

        private void ManCustomersMi_Click(object sender, RoutedEventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.Show();
        }

        private void CirculationMi_Click(object sender, RoutedEventArgs e)
        {
            CirculationWindow circulationWindow = new CirculationWindow();
            circulationWindow.Show();
        }

        private void ReportsMi_Click(object sender, RoutedEventArgs e)
        {
            ReportsWindow reportsWindow = new ReportsWindow();
            reportsWindow.Show();
        }

        private void SearchBTN_Click(object sender, RoutedEventArgs e)
        {
            BookAuthorsLv.ItemsSource = App.context.BookAuthor.Where(ba => ba.Book.Title.Contains(TitleTb.Text) && ba.Author.Lastname.Contains(AuthorTb.Text)).ToList();
        }

        private void AuthorsHl_Click(object sender, RoutedEventArgs e)
        {
            BookAuthorsDetailsWindow bookAuthorsDetailsWindow = new BookAuthorsDetailsWindow(BookAuthorsLv.SelectedItem as BookAuthor);
            bookAuthorsDetailsWindow.ShowDialog();
        }
    }
}
