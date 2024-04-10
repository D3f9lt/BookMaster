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
        }

        // Отслеживаем изменение выюора в ListView
        private void BookAuthorsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Загружаем в контекст днных Grid'а с выбранный элемент из ListView (для реализации привязки элемента)
            BookDetailsGrid.DataContext = BookAuthorsLv.SelectedItem as BookAuthor;
        }
    }
}
