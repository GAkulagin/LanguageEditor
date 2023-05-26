using LanguageEditor.Models;
using LanguageEditor.RepositoryClasses;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Northwoods.Go.Extensions;

namespace LanguageEditor.Views
{
    public partial class MainMenu : Form
    {
        private List<ModelFile> _metamodels;

        public MainMenu()
        {
            InitializeComponent();

            Figures.DefineExtraFigures();
        }
        
        private void SetListViewItems(ListView view, List<ModelFile> models)
        {
            foreach(var model in models)
            {
                var item = new ListViewItem();
                item.Text = model.Name;
                item.ImageIndex = 0;

                view.Items.Add(item);
            }
        }

        private void metamodelsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ModelFile currentMetamodel = _metamodels[metamodelsListView.SelectedIndices[0]];
                modelsListView.Clear();
                SetListViewItems(modelsListView, currentMetamodel.Models);
            }
            catch { }
        }

        // event of metamodelListview
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // event of metamodelListview
        private void создатьМодельНаОсновеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // event of metamodelListview
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metamodelsListView_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = metamodelsListView.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    metamodelContextMenu.Show(Cursor.Position);
                }
            }
        }

        // event of modelsListview
        private void редактироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        // event of modelsListview
        private void модельмодельToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // event of modelsListview
        private void модельтекстToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // event of modelsListview
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modelsListView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = modelsListView.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    modelContextMenu.Show(Cursor.Position);
                }
            }
        }

        private void CreateMetamodelBtn_Click(object sender, EventArgs e)
        {
            Editor editorForm = new Editor(DiagramModel.GetPredefinedFigures(), EditorMode.Modeling);
            editorForm.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            _metamodels = FileExtractor.GetModelFiles();
            SetListViewItems(metamodelsListView, _metamodels);
            
            IdSetter.Init();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            IdSetter.Save();
        }
    }
}
