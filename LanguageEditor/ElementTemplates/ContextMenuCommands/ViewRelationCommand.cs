using System;
using System.Linq;
using LanguageEditor.Models;
using LanguageEditor.Views;
using Northwoods.Go;

namespace LanguageEditor.ElementTemplates.ContextMenuCommands
{
    public class ViewRelationCommand : IContextMenuCommand
    {
        public Action<InputEvent, GraphObject> GetCommand()
        {
            return (e, obj) =>
            {
                if (obj.Part.Data is Relation relation)
                {
                    var entities = ((DiagramModel)obj.Part.Diagram.Model).Data.Entities;
                    var source = entities.Single(ent => ent.Key == relation.From);
                    var target = entities.Single(ent => ent.Key == relation.To);
                    var form = new SingleElementView(relation, source, target);
                    form.Text = relation.Name;
                    form.Show();
                }
            };
        }
    }
}