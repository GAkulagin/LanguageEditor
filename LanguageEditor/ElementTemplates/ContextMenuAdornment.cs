using LanguageEditor.ElementTemplates.ContextMenuCommands;
using Northwoods.Go;

namespace LanguageEditor.ElementTemplates
{
    public class ContextMenuAdornment
    {
        private IContextMenuCommand _editCmd;
        private IContextMenuCommand _deleteCmd;
        public ContextMenuAdornment(IContextMenuCommand editcmd, IContextMenuCommand deletecmd)
        {
            _editCmd = editcmd;
            _deleteCmd = deletecmd;
        }
        
        public Adornment GetAdornment()
        {
            return Builder.Make<Adornment>("ContextMenu")
                .Add(
                    Builder.Make<Panel>("ContextMenuButton")
                        .Set(new {
                            Click = _editCmd.GetCommand()
                        })
                        .Add(new TextBlock("Изменить...")),
                    Builder.Make<Panel>("ContextMenuButton")
                        .Set(new {
                            Click = _deleteCmd.GetCommand()
                        })
                        .Add(new TextBlock("Удалить"))
                    );
        }
    }
}