using Northwoods.Go;
using Northwoods.Go.Layouts;
using Northwoods.Go.PanelLayouts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageEditor.Models;

namespace LanguageEditor.Views
{
    public partial class Editor : Form
    {
        private Diagram _canvas;
        private Overview _overview;

        public Editor(ModelData model)
        {
            InitializeComponent();

            Text = model.Name;


            _canvas = diagramControl.Diagram;

            DiagramSetup();
            OverviewSetup();
            NodeTemplateSetup();

            _canvas.Model = model;
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

        private void NodeTemplateSetup()
        {
            _canvas.NodeTemplate =
                new Node("Auto")
                  .Add(
                    new Shape("RoundedRectangle") { Fill = "lightblue" },
                    new TextBlock { Margin = 3 }
                    .Bind("Text", "Name")
                    );
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
            Entity entity1 = new Entity();
            entity1.Name = "human";
            entity1.MaxCount = 100;
            entity1.IsAbstract = false;
            entity1.Attributes.Add(new Attribute<string>
            {
                Name = "Name",
                IsValueUnique = false,
                Value = "Bill Clinton",
            });
            entity1.Attributes.Add(new Attribute<int>
            {
                Name = "Age",
                IsValueUnique = false,
                Value = 50,
            });
            entity1.Poles.Add(new Pole
            {
                IsExternal = true
            });
            entity1.Poles.Add(new Pole
            {
                IsExternal = false
            });

            EntityEdit form = new EntityEdit(entity1);
            form.Show();
        }
    }
}
