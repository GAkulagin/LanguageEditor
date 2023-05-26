using LanguageEditor.ElementTemplates.ContextMenuCommands;
using Northwoods.Go;

namespace LanguageEditor.ElementTemplates
{
    public class ContextMenuAdornment
    {
        private IContextMenuCommand _editCmd;
        private IContextMenuCommand _deleteCmd;
        private IContextMenuCommand _viewCmd;
        public ContextMenuAdornment(IContextMenuCommand editcmd, IContextMenuCommand deletecmd, IContextMenuCommand viewCmd)
        {
            _editCmd = editcmd;
            _deleteCmd = deletecmd;
            _viewCmd = viewCmd;
        }
        
        public Adornment GetAdornment()
        {
            return Builder.Make<Adornment>("ContextMenu")
                .Add(
                    Builder.Make<Panel>("ContextMenuButton")
                        .Set(new {
                            Click = _viewCmd.GetCommand()
                        })
                        .Add(new TextBlock("Просмотр")),
                    Builder.Make<Panel>("ContextMenuButton")
                        .Set(new {
                            Click = _editCmd.GetCommand()
                        })
                        .Add(new TextBlock("Изменить")),
                    Builder.Make<Panel>("ContextMenuButton")
                        .Set(new {
                            Click = _deleteCmd.GetCommand()
                        })
                        .Add(new TextBlock("Удалить"))
                    );
        }
    }
}