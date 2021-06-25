using Biblio_Directory2.Resources;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biblio_Directory2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<BiblioResources> _bibliodata;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _bibliodata = new List<BiblioResources>()
            {
                new BiblioResources(){Book = "test"},
                new BiblioResources(){Book = "ANNA KARENINA"} 
            };

            BiblioList.ItemsSource = _bibliodata;
            
        }
    }
}
