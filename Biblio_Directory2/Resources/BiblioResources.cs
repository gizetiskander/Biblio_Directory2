using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio_Directory2.Resources
{
    class BiblioResources
    {
        private string _Text;
        public string Name
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public string Author
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public string Publishing
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public DateTime PublishingDate { get; set; } = DateTime.Now;

        public string Puzzle { get; set; }
        public string Games { get; set; }
    }
    
}
