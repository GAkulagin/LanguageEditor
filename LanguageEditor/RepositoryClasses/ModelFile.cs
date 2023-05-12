using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.RepositoryClasses
{
    // represents a metamodel and models list
    internal class ModelFile
    {
        public string Path { get; }
        public string Name { get; }
        public List<ModelFile> Models { get; }


        public ModelFile(string path)
        {
            Path = path;
            Name = path.Split('\\').Last();
            Models = new List<ModelFile>();
        }
    }
}
