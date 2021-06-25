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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            {
                new BiblioResources() { Name = "AnnaKarenina", Author = "LevTolstoy", Publishing = "Isdatelstvo" },
                new BiblioResources() { Name = "Mymy" }
            };

            BiblioList.ItemsSource = _bibliodataList;
            _bibliodataList.ListChanged += _bibliodataList_ListChanged;
        }

        private void _bibliodataList_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch(e.ListChangedType)
            {
                case ListChangedType.Reset:
                    break;
                case ListChangedType.ItemAdded:
                    break;
                case ListChangedType.ItemDeleted:
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.ItemChanged:
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                    break;
                case ListChangedType.PropertyDescriptorChanged:
                    break;
                case ListChangedType.PropertyDescriptorDeleted:
                    break;
            }
        }

        private void Close()
        {
            throw new NotImplementedException();
        }
    }
}
