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
        private IPackager _packager = XmlPackager.CreateInstance();

        public MainMenu()
        {
            InitializeComponent();
            Figures.DefineExtraFigures();
        }
        
        private void SetListViewItems(ListView view, List<ModelFile> models)
        {
            view.Clear();
            
            foreach(var model in models)
            {
                AddListViewItem(view, model);
            }
        }

        private void AddListViewItem(ListView view, ModelFile model)
        {
            var item = new ListViewItem();
            item.Text = model.Name;
            item.ImageIndex = 0;

            view.Items.Add(item);
        }

        private void metamodelsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentMetamodel = _metamodels[metamodelsListView.SelectedIndices[0]];
            
            SetListViewItems(modelsListView, currentMetamodel.Models);
        }

        // event of metamodelListview
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var idx = metamodelsListView.SelectedIndices[0];
            var model = _packager.Unpack(_metamodels[idx].Path);

            if (model == null)
                MessageBox.Show(
                    $"Не удалось открыть файл {_metamodels[idx].Name}. Возможно, файл не является представлением модели.",
                    "Ошибка при чтении файла", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                var editor = new Editor(model, EditorMode.Metamodeling, _packager);
                editor.Show();
            }
        }

        // event of metamodelListview
        private void создатьМодельНаОсновеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // event of metamodelListview
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                $"Вы действительно хотите удалить проект {metamodelsListView.SelectedItems[0].Text} и все связанные модели?",
                "Удаление проекта", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var idx = metamodelsListView.SelectedIndices[0];
                FileExtractor.DeleteProject(_metamodels[idx]);
                metamodelsListView.Items.RemoveAt(idx);
                _metamodels.RemoveAt(idx);
            }
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
            var model = new DiagramModel(new ModelData());
            FileExtractor.CreateProject(model, _packager);
            var editor = new Editor(model, EditorMode.Metamodeling, _packager);

            _metamodels = FileExtractor.GetModelFiles();
            SetListViewItems(metamodelsListView, _metamodels);
            
            editor.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (!FileExtractor.EnsureDataDirExists())
            {
                MessageBox.Show(
                    $"Не удалось обнаружить данные приложения; директория {FileExtractor.GetMainDirPath()} не найдена.",
                    "Ошибка запуска", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
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
