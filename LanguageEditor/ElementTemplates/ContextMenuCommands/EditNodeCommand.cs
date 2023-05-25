using System;
using LanguageEditor.Models;
using Northwoods.Go;
using LanguageEditor.Views;

namespace LanguageEditor.ElementTemplates.ContextMenuCommands
{
    public class EditNodeCommand : IContextMenuCommand
    {
        public Action<InputEvent, GraphObject> GetCommand()
        {
            return (e, obj) =>
            {
                if (obj.Part.Data is Entity entity)
                    new EntityEdit(entity).Show();
            };
        }
    }
}