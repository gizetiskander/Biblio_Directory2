using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblio_Directory2.Resources;
using Newtonsoft.Json;

namespace Biblio_Directory2.Service
{
    class FIleServiceIO
    {
        private string Path;
        public FIleServiceIO(string path)
        {
            Path = path;
        }
        public BindingList<BiblioResources> LoadData()
        {
            var fileExists = File.Exists(Path);
            if (!fileExists)
            {
                File.CreateText(Path).Dispose();
                return new BindingList<BiblioResources>();
            }
            using (var reader = File.OpenText(Path))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<BiblioResources>>(fileText);
            }
        }

        public void SaveData(List<BiblioResources> bibliodataList)
        {
            using (StreamWriter writer = File.CreateText(Path))
            {
                string output = JsonConvert.SerializeObject(bibliodataList);
                writer.Write(output);
            }
        }
    }
}
