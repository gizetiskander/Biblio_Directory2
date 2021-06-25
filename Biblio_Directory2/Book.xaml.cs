using Biblio_Directory2.Resources;
using Biblio_Directory2.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        private string Path = $"{Environment.CurrentDirectory}\\bibliodataList.json";
        private BindingList<BiblioResources> _bibliodataList;
        private FIleServiceIO _fileServiceIO;
        public Book()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _fileServiceIO = new FIleServiceIO(Path);

            try
            {
                _bibliodataList = _fileServiceIO.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            _bibliodataList = new BindingList<BiblioResources>()
            {
                new BiblioResources() { Name = "AnnaKarenina", Author = "LevTolstoy", Publishing = "Isdatelstvo" }
            };

            BiblioList.ItemsSource = _bibliodataList;
        }
    }
}
