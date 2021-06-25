using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Directory2.Resources
{
    class BiblioResources: INotifyPropertyChanged
    {
        private string _Name;
        private string _Author;
        private string _Publishing;


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        public string Publishing
        {
            get { return _Publishing; }
            set { _Publishing = value; }
        }

        public DateTime PublishingDate { get; set; } = DateTime.Now;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string nameproperty = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nameproperty));
            }
        }
    }
    
}
