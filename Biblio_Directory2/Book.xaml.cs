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
    /// Логика взаимодействия для Book.xaml
    /// </summary>
    public partial class Book : Page
    {
        private List<BiblioResources> _bibliodata;
        public Book()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _bibliodata = new List<BiblioResources>()
            {
                new BiblioResources(){Name="AnnaKarenina"},
                new BiblioResources(){Name="Mymy"}
            };

            BiblioList.ItemsSource = _bibliodata;
        }
    }
}
