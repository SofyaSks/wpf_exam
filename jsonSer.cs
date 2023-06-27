using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace wpf_exam
{
    public class jsonSer
    {
        private readonly string path;

        public jsonSer (string _path)
        {
            path = _path;
        }
        public BindingList<InOutCl> LoadData()
        {
            var fileExists = File.Exists(path);
            if (!fileExists)
            {
                File.CreateText(path).Dispose();
                return new BindingList<InOutCl>();
            }
            using (var reader = File.OpenText(path))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<InOutCl>>(fileText)??throw new NullReferenceException("Deserialization failed");
            }
        }

        public void SaveData(object inOut)
        {
            using (StreamWriter writer = File.CreateText(path))
            {
                string output = JsonConvert.SerializeObject(inOut);
                writer.Write(output);
            }
        }
    }
}
