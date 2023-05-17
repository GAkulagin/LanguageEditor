using LanguageEditor.Models;

namespace LanguageEditor.RepositoryClasses
{
    interface IPackager
    {
        void Pack(DiagramModel model, string filepath);
        DiagramModel Unpack();
    }
}
