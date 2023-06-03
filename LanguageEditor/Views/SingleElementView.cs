using System.Windows.Forms;
using LanguageEditor.ElementTemplates;
using LanguageEditor.Models;
using Northwoods.Go;

namespace LanguageEditor.Views
{
    public partial class SingleElementView : Form
    {
        private Diagram _canvas;
        
        public SingleElementView(Entity entity)
        {
            InitializeComponent();

            var md = new ModelData();
            md.Entities.Add(entity);
            var model = new DiagramModel(md);

            DiagramSetup();
            _canvas.Model = model;
        }

        public SingleElementView(Relation relation, Entity source, Entity target)
        {
            InitializeComponent();
            
            var md = new ModelData();
            md.Relations.Add(relation);
            md.Entities.Add(source);
            if(source.Key != target.Key) md.Entities.Add(target);
            var model = new DiagramModel(md);

            DiagramSetup();
            _canvas.Model = model;
        }

        private void DiagramSetup()
        {
            _canvas = diagramControl.Diagram;
            _canvas.Grid.Visible = true;
            _canvas.NodeTemplate = new ModelEntityTemplate().GetTemplate();
            _canvas.LinkTemplate = (Link)new ModelRelationTemplate().GetTemplate();
            _canvas.ToolManager.DraggingTool.IsEnabled = false;
            _canvas.ToolManager.ContextMenuTool.IsEnabled = false;
            _canvas.ToolManager.ClickSelectingTool.IsEnabled = false;
        }
    }
}