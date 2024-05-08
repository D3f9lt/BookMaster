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
    /// Логика взаимодействия для BookAuthorsDetailsWindow.xaml
    /// </summary>
    public partial class BookAuthorsDetailsWindow : Window
    {
        public BookAuthorsDetailsWindow(BookAuthor bookAuthor)
        {
            InitializeComponent();

            AuthorCmb.ItemsSource = App.context.BookAuthor.Where(ba => ba.BookId == bookAuthor.BookId).ToList();

            DataContext = AuthorCmb.SelectedItem = bookAuthor;
        }

        private void AuthorCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // В контекст данных окна передаем выбранный элемент из выпадающего списка. Сам элемент приводим к типу BookAuthor.
            DataContext = AuthorCmb.SelectedItem as BookAuthor;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
