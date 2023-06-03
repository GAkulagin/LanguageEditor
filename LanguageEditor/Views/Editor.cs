using Northwoods.Go;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private ElementData _selectedElemViewMode = ElementData.Properties;
        private Dictionary<string, object> _selectedElemProps = new Dictionary<string, object>();
        private Dictionary<string, object> _selectedElemAttrs = new Dictionary<string, object>();

        public Editor(DiagramModel model, EditorMode mode)
        {
            InitializeComponent();

            Text = model.Name;

            _canvas = diagramControl.Diagram;

            DataGridSetup();
            DiagramSetup();
            OverviewSetup();

            switch (mode)
            {
                case EditorMode.Metamodeling: MetamodelingSetup(); break;
                case EditorMode.Modeling: ModelingSetup(); break;
                default: MetamodelingSetup(); break;
            }

            _canvas.Model = model;

            Entity.EntityUpdated += OnElementChange;
            Relation.RelationUpdated += OnElementChange;
            _canvas.ChangedSelection += OnSelectionChanged;
        }


        private void DataGridSetup()
        {
            dgrSelectedElemData.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Свойство", ReadOnly = true });
            dgrSelectedElemData.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Значение", ReadOnly = true });
            dgrSelectedElemData.RowHeadersVisible = false;
            dgrSelectedElemData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            _canvas.NodeTemplate = new MetamodelEntityTemplate().GetTemplate();
            _canvas.LinkTemplate = (Link)new MetamodelRelationTemplate().GetTemplate();
            
            palette.Diagram.NodeTemplate = new Node("Horizontal")
                .Add(
                    new Shape { Width = 100, Height = 50, Fill = "lightgray" }
                        .Bind("Figure"),
                    new TextBlock().Bind("Text")
                );
            var md = new ModelData();
            md.Entities.Add(new Entity(){Text = "Новая вершина", Figure = "RoundedRectangle"});
            md.Entities.Add(new Entity(){Text = "Новая связь", Figure = "Arrow"});
            var model = new DiagramModel(md);
            model.NodeDataSource = md.Entities;
            palette.Diagram.Model = model;
        }
        private void ModelingSetup()
        {
            _canvas.NodeTemplateMap = new Dictionary<string, Part>
            {
                { TemplateCategories.Default, new ModelEntityTemplate().GetTemplate() },
                { TemplateCategories.Picture, new PictureTemplate().GetTemplate() }
            };
            _canvas.LinkTemplate = (Link)new ModelRelationTemplate().GetTemplate();
        }

        private void OnSelectionChanged(object sender, DiagramEvent args)
        {
            if (_canvas.Selection.Count == 0)
            {
                ClearDataGrid();
                _selectedElemProps.Clear();
                _selectedElemAttrs.Clear();
                return;
            }

            _selectedElemProps.Clear();
            _selectedElemAttrs.Clear();
            
            var selected = _canvas.Selection.Last();

            switch (selected.Data)
            {
                case Entity entity:
                    SetSelectedEntity(entity);
                    break;
                case Relation relation:
                    SetSelectedRelation(relation);
                    break;
            }

            switch (_selectedElemViewMode)
            {
                case ElementData.Attributes:
                    ClearDataGrid();
                    PopulateGridView(_selectedElemAttrs);
                    dgrSelectedElemData.Columns[0].HeaderText = "Атрибут";
                    break;
                case ElementData.Properties:
                    ClearDataGrid();
                    PopulateGridView(_selectedElemProps);
                    dgrSelectedElemData.Columns[0].HeaderText = "Свойство";
                    break;
            }
        }
        private void SetSelectedEntity(Entity entity)
        {
            _selectedElemProps.Add("Имя", entity.Name);
            _selectedElemProps.Add("Абстрактная", entity.IsAbstract);
            if(entity.CanSetMaxCount)
                _selectedElemProps.Add("Макс. число экземпляров", entity.CanSetMaxCount);
            _selectedElemProps.Add("Форма", entity.Figure);
            _selectedElemProps.Add("Изображение", entity.Image);
            _selectedElemProps.Add("Ширина", entity.Width);
            _selectedElemProps.Add("Высота", entity.Height);
            _selectedElemProps.Add("Угол поворота", Math.Round(entity.Angle, 2));
            _selectedElemProps.Add("Шрифт", entity.FontName);
            _selectedElemProps.Add("Размер шрифта", entity.FontSize);
            
            SetSelectedElementAttrs(entity);
        }
        private void SetSelectedRelation(Relation relation)
        {
            _selectedElemProps.Add("Имя", relation.Name);
            _selectedElemProps.Add("Источник", relation.From);
            _selectedElemProps.Add("Приемник", relation.To);
            _selectedElemProps.Add("Шрифт", relation.FontName);
            _selectedElemProps.Add("Размер шрифта", relation.FontSize);
            
            SetSelectedElementAttrs(relation);
        }
        private void SetSelectedElementAttrs(IAttributedElement element)
        {
            foreach(var attr in element.Attributes)
                _selectedElemAttrs.Add(attr.Name, attr.Value);
        }

        private void PopulateGridView(Dictionary<string, object> data)
        {
            foreach (var item in data)
            {
                dgrSelectedElemData.Rows.Add(new[] { item.Key, item.Value });
            }
        }

        private void ClearDataGrid()
        {
            dgrSelectedElemData.Rows.Clear();
            dgrSelectedElemData.Refresh();
        }

        private void OnElementChange(object element, Changelog changelog)
        {
            _canvas.Model.Commit(m =>
            {
                foreach (var record in changelog.Log)
                    m.Set(element, record.Key, record.Value);
                
            }, "OnElementChange");
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

            packager.Pack((DiagramModel)_canvas.Model, @"C:\Users\Professional\Desktop\sample.xml");
        }

        private void переименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void сеткаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _canvas.Grid.Visible = !_canvas.Grid.Visible;
        }

        private void btnViewProps_Click(object sender, EventArgs e)
        {
            _selectedElemViewMode = ElementData.Properties;
            ClearDataGrid();
            PopulateGridView(_selectedElemProps);
            dgrSelectedElemData.Columns[0].HeaderText = "Свойство";
        }

        private void btnViewAttributes_Click(object sender, EventArgs e)
        {
            _selectedElemViewMode = ElementData.Attributes;
            ClearDataGrid();
            PopulateGridView(_selectedElemAttrs);
            dgrSelectedElemData.Columns[0].HeaderText = "Атрибут";
        }

        private void новаяСущностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var entity = new Entity();
            var form = new EntityEdit(entity);
            form.Show();
            
            _canvas.Model.AddNodeData(entity);
        }

        private void новаяСвязьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rel = new Relation();
            var form = new RelationEdit(rel, ((DiagramModel)_canvas.Model).Data.Entities);
            form.Show();
            
            ((DiagramModel)_canvas.Model).AddLinkData(rel);
        }
    }
}
