using LanguageEditor.Models;
using Northwoods.Go;

namespace LanguageEditor.ElementTemplates.EventHandlers
{
    public class SelectionHandler
    {
        public void OnEntitySelectionChanged(Part node)
        {
            var entity = node.Data as Entity;
            if (entity == null) return;

            if (node.IsSelected)
            {
                
            }
        }
    }
}