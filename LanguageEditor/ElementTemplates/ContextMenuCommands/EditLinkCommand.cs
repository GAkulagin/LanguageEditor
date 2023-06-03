using System;
using LanguageEditor.Models;
using LanguageEditor.Views;
using Northwoods.Go;

namespace LanguageEditor.ElementTemplates.ContextMenuCommands
{
    public class EditLinkCommand : IContextMenuCommand
    {
        public Action<InputEvent, GraphObject> GetCommand()
        {
            return (e, obj) =>
            {
                if (obj.Part.Data is Relation link)
                {
                    var form = new RelationEdit(link);
                    form.Entities = ((DiagramModel)obj.Diagram.Model).Data.Entities;
                    form.Show();
                }
            };
        }
    }
}