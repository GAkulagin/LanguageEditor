using System;
using LanguageEditor.Models;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace LanguageEditor.RepositoryClasses
{
    class XmlPackager : IPackager
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

        public DiagramModel Unpack()
        {
            throw new NotImplementedException();
        }
    }
}
