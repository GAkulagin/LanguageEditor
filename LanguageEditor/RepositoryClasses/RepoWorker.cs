using LanguageEditor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LanguageEditor.RepositoryClasses
{
    internal static class RepoWorker
    {
        private static string _repoPath = @"G:\Users\User\source\repos\LanguageEditor\projects";


        public static List<ModelFile> GetModelFiles()
        {
            List<ModelFile> metamodels = new List<ModelFile>();

            try
            {
                string[] dirs = Directory.GetDirectories(_repoPath);

                foreach(string dir in dirs)
                {
                    string metamodelFile = Directory.GetFiles(dir, "*.xml", SearchOption.TopDirectoryOnly)[0];
                    string[] models = Directory.GetFiles(dir + "\\models", "*.xml", SearchOption.TopDirectoryOnly);
                    ModelFile metamodel = new ModelFile(metamodelFile);               

                    foreach(string model in models)
                    {
                        metamodel.Models.Add(new ModelFile(model));
                    }

                    metamodels.Add(metamodel);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return metamodels;
        }
    }
}
