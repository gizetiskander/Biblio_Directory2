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
        public string Book
        {
            get { return _Text; }
            set { _Text = value; }
        }
        public string Puzzle { get; set; }
        public string Games { get; set; }
    }
}
