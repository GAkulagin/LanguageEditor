using System;
using LanguageEditor.Models;
using Northwoods.Go;

namespace LanguageEditor.ElementTemplates.ContextMenuCommands
{
    public class RemoveNodeCommand : IContextMenuCommand
    {
        public Action<InputEvent, GraphObject> GetCommand()
        {
            return (e, obj) =>
            {
                if(obj.Part.Data is Entity entity)
                    obj.Part.Diagram.Model.RemoveNodeData(entity);
            };
        }
    }
}