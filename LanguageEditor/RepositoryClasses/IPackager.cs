using LanguageEditor.Models;

namespace LanguageEditor.RepositoryClasses
{
    public interface IPackager
    {
        void Pack(DiagramModel model, string filepath);
        DiagramModel Unpack(string filepath);
    }
}
