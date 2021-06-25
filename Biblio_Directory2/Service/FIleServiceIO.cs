using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblio_Directory2.Resources;

namespace Biblio_Directory2.Service
{
    class FIleServiceIO
    {
        private string Path;
        public FIleServiceIO(string path)
        {
            Path = path;
        }
        public List<BiblioResources> LoadData()
        {
            return null;
        }

        public SaveData(List<BiblioResources> bibliodataList)
        {
            using (StreamWriter wrieter = File.Create)
        }
    }
}
