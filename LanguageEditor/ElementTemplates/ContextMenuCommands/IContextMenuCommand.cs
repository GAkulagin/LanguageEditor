using System;
using Northwoods.Go;

namespace LanguageEditor.ElementTemplates.ContextMenuCommands
{
    public interface IContextMenuCommand
    {
        Action<InputEvent, GraphObject> GetCommand();
    }
}