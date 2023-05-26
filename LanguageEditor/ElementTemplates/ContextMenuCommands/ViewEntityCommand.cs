using System;
using System.Windows.Forms;
using LanguageEditor.Models;
using LanguageEditor.Views;
using Northwoods.Go;

namespace LanguageEditor.ElementTemplates.ContextMenuCommands
{
    public class ViewEntityCommand : IContextMenuCommand
    {
        public Action<InputEvent, GraphObject> GetCommand()
        {
            return (e, obj) =>
            {
                if (obj.Part.Data is Entity entity)
                {
                    var form = new SingleElementView(entity);
                    form.Text = entity.Name;
                    form.Show();
                }
            };
        }
    }
}