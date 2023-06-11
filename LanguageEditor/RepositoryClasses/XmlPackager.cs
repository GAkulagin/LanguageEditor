using System;
using LanguageEditor.Models;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using Northwoods.Go.Models;

namespace LanguageEditor.RepositoryClasses
{
    public class XmlPackager : IPackager
    {
        private static XmlPackager _instance;
        private XmlSerializer _xmlserializer = new XmlSerializer(typeof(ModelData));

        private XmlPackager() { }


        public static IPackager CreateInstance()
        {
            if (_instance == null) _instance = new XmlPackager();

            return _instance;
        }

        public void Pack(DiagramModel model, string filepath)
        {
            try
            {
                using (var fs = new FileStream(filepath, FileMode.Truncate, FileAccess.Write))
                {
                    _xmlserializer.Serialize(fs, model.Data);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"{e.Message}\n{e.InnerException}");
            }
        }

        public DiagramModel Unpack(string filepath)
        {
            DiagramModel model = null;
            try
            {
                using (var fs = new FileStream(filepath, FileMode.Open))
                {
                    var md = _xmlserializer.Deserialize(fs) as ModelData;
                    model = new DiagramModel(md);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"{e.Message}\n{e.InnerException}");
            }

            return model;
        }
    }
}
