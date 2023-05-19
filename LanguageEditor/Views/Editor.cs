using Northwoods.Go;
using System;
using System.Windows.Forms;
using LanguageEditor.Models;
using LanguageEditor.RepositoryClasses;
using LanguageEditor.ElementTemplates;


namespace LanguageEditor.Views
{
    public partial class Editor : Form
    {
        private Diagram _canvas;
        private Overview _overview;

        public Editor(DiagramModel model, EditorMode mode)
        {
            InitializeComponent();

            Text = model.Name;

            _canvas = diagramControl.Diagram;

            DiagramSetup();
            OverviewSetup();

            switch (mode)
            {
                case EditorMode.Metamodeling: MetamodelingSetup(); break;
                case EditorMode.Modeling: ModelingSetup(); break;
                default: MetamodelingSetup(); break;
            }

            _canvas.Model = model;

            Entity.EntityChanged += OnEntityChange;
        }


        private void DiagramSetup()
        {
            _canvas.ViewportBoundsChanged += (s, e) =>
            {
                toolStripScaleLabel.Text = $"Масштаб: {Math.Round(_canvas.Scale * 100, 2)}%";
            };
            _canvas.Grid.Visible = true;
            _canvas.Scale = 1.0;
            _canvas.UndoManager.IsEnabled = true;
            _canvas.ToolManager.DraggingTool.IsGridSnapEnabled = true;
            _canvas.ToolManager.ResizingTool.IsGridSnapEnabled = true;
        }

        private void OverviewSetup()
        {
            _overview = overviewControl.Diagram as Overview;
            _overview.Observed = _canvas;
            _overview.DrawsTemporaryLayers = false;
        }

        private void MetamodelingSetup()
        {

        }

        private void ModelingSetup()
        {
            var template = new ModelEntityTemplate();
            _canvas.NodeTemplate = template.GetTemplate();
        }

        private void OnEntityChange(long key)
        {
            _canvas.Model.Commit(m =>
            {
                var node = ((DiagramModel)_canvas.Model).Data.Entities.Find(e => e.Key == key);
                
                m.Set(node, "Name", "human11111");
            }, "OnEntityChange");
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _canvas.Scale = 0.25;
        }

        private void toolStripMenuItemScale50_Click(object sender, EventArgs e)
        {
            _canvas.Scale = 0.5;
        }

        private void toolStripMenuItemScale75_Click(object sender, EventArgs e)
        {
            _canvas.Scale = 0.75;
        }

        private void toolStripMenuItemScale100_Click(object sender, EventArgs e)
        {
            _canvas.Scale = 1.0;
        }

        private void toolStripMenuItemScale125_Click(object sender, EventArgs e)
        {
            _canvas.Scale = 1.25;
        }

        private void toolStripMenuItemScale150_Click(object sender, EventArgs e)
        {
            _canvas.Scale = 1.5;
        }

        private void toolStripMenuItemScale200_Click(object sender, EventArgs e)
        {
            _canvas.Scale = 2.0;
        }

        private void toolStripMenuItemScale300_Click(object sender, EventArgs e)
        {
            _canvas.Scale = 3.0;
        }

        private void toolStripButtonUpscale_Click(object sender, EventArgs e)
        {
            _canvas.Scale += 0.1;
        }

        private void toolStripButtonDownScale_Click(object sender, EventArgs e)
        {
            _canvas.Scale -= 0.1;
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            _canvas.UndoManager.Undo();
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            _canvas.UndoManager.Redo();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IPackager packager = XmlPackager.CreateInstance();

            packager.Pack((DiagramModel)_canvas.Model, "sample.xml");
        }

        private void переименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void сеткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _canvas.Grid.Visible = _canvas.Grid.Visible == true ? false : true;
        }

        private void buttonAddEntity_Click(object sender, EventArgs e)
        {
            EntityEdit form = new EntityEdit(((DiagramModel)_canvas.Model).Data.Entities[0]);
            form.Show();
        }
    }
}
