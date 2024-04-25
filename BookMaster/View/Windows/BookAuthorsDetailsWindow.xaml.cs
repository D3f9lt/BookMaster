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
        }

        private void AuthorCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
