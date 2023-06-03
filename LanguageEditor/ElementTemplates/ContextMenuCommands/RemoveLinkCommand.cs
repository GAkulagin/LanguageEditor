using System;
using LanguageEditor.Models;
using Northwoods.Go;

namespace LanguageEditor.ElementTemplates.ContextMenuCommands
{
    public class RemoveLinkCommand : IContextMenuCommand
    {
        public Action<InputEvent, GraphObject> GetCommand()
        {
            return (e, obj) =>
            {
                if(obj.Part.Data is Relation link)
                    ((DiagramModel)obj.Part.Diagram.Model).RemoveLinkData(link);
            };
        }
    }
}