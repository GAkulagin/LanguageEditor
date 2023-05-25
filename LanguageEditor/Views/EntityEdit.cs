using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageEditor.Models;
using System.Drawing;
using Attribute = LanguageEditor.Models.Attribute;

namespace LanguageEditor.Views
{
    public partial class EntityEdit : Form
    {
        private Entity _entity;
        private BindingList<Attribute> _bindingList;
        private Changelog _changelog;

        public BindingList<Attribute> Attributes => _bindingList;

        public EntityEdit(Entity e)
        {
            InitializeComponent();

            _entity = e;
            _bindingList = new BindingList<Attribute>(_entity.Attributes)
            {
                AllowNew = false
            };
            _changelog = new Changelog();

            ControlsSetup();
        }


        private void ControlsSetup()
        {
            textBoxName.Text = _entity.Name;
            checkBoxIsAbstract.Checked = _entity.IsAbstract;
            checkBoxCanSetMaxCount.Checked = _entity.CanSetMaxCount;
            checkBoxImage.Checked = !string.IsNullOrEmpty(_entity.Image);
            numericUpDownMaxCount.Value = _entity.MaxCount;
            numericUpDownMaxCount.Enabled = _entity.CanSetMaxCount;
            toolTip1.SetToolTip(labelImgPath, _entity.Image);
            buttonSetImage.Enabled = !string.IsNullOrEmpty(_entity.Image);
            openFileDialog.Filter = "Images (*.bmp;*.jpg;*.gif;*.png;*.jpeg)|*.bmp;*.jpg;*.gif;*.png;*.jpeg";
            openFileDialog.RestoreDirectory = true;
            fontDialog.ShowEffects = true;
            panelFillColor.BackColor = Color.LightGray;
            panelStrokeColor.BackColor = Color.Black;
            colorDialog.Color = Color.LightGray;
            labelFontInfo.Text = $"{_entity.FontName} {_entity.FontSize} pt";

            ShapesImageListSetup();
            DataGridSetup();
        }

        private void DataGridSetup()
        {
            dataGridView.DataSource = _bindingList;
            dataGridView.AutoResizeColumns();

            dataGridView.Columns["Name"].HeaderText = "Имя";
            dataGridView.Columns["IsValueUnique"].HeaderText = "Уникальный";

            dataGridView.Columns["Key"].Visible = false;
            dataGridView.Columns["Value"].Visible = false;

            dataGridView.Columns["Name"].DisplayIndex = 0;
            dataGridView.Columns["TypeName"].DisplayIndex = 1;
            dataGridView.Columns["IsValueUnique"].DisplayIndex = 2;

            dataGridView.Columns["TypeName"].ReadOnly = true;
        }

        private void ShapesImageListSetup()
        {
            int imageIndex = 0;
            foreach (var kvp in DisplayedDataLists.Figures)
            {
                listViewShape.Items.Add(new ListViewItem()
                {
                    Tag = kvp.Key,
                    Text = kvp.Value,
                    ImageIndex = imageIndex
                });
                imageIndex++;
            }
        }
        private void SaveEntity()
        {
            _entity.Name = textBoxName.Text;
            _entity.MaxCount = (int)numericUpDownMaxCount.Value;
            _entity.IsAbstract = checkBoxIsAbstract.Checked;
            _entity.CanSetMaxCount = checkBoxCanSetMaxCount.Checked;

            var newfigure = listViewShape.Items[0].Tag.ToString();
            if (listViewShape.SelectedItems.Count > 0) 
                newfigure = listViewShape.SelectedItems[0].Tag.ToString();
            _changelog.Add("Figure", newfigure);

            Entity.UpdateEntityView(_entity, _changelog);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                buttonSave.Enabled = false;
                labelNameInvalidMsg.Visible = true;
            }
            else
            {
                buttonSave.Enabled = true;
                labelNameInvalidMsg.Visible = false;
            }
        }

        private void checkBoxIsAbstract_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsAbstract.Checked)
            {
                checkBoxCanSetMaxCount.Checked = true;
                checkBoxCanSetMaxCount.Enabled = false;
                numericUpDownMaxCount.Value = 0;
                numericUpDownMaxCount.Enabled = false;
            }
            else
            {
                checkBoxCanSetMaxCount.Enabled = true;
                checkBoxCanSetMaxCount.Checked = false;
            }
        }

        private void checkBoxCanSetMaxCount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCanSetMaxCount.Checked)
            {
                numericUpDownMaxCount.Enabled = true;
            }
            else
            {
                numericUpDownMaxCount.Enabled = false;
                numericUpDownMaxCount.Value = 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveEntity();
            Close();
        }

        private void buttonAddAttribute_Click(object sender, EventArgs e)
        {
            var form = new AttributeTypeSelect(this);
            form.Show();
        }

        private void buttonDeleteAttribute_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            var dlg = MessageBox.Show(
                $"Вы действительно хотите удалить атрибут {dataGridView.CurrentRow.Cells["Name"].Value}?", 
                "Подтверждение удаления", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(dlg == DialogResult.OK)
            {
                _bindingList.RemoveAt(dataGridView.CurrentRow.Index);
            }
        }

        private void buttonFillColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog.Color = panelFillColor.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            panelFillColor.BackColor = colorDialog.Color;
            _changelog.Add("FillColor", ColorTranslator.ToHtml(colorDialog.Color));
        }

        private void buttonBorderColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog.Color = panelStrokeColor.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            panelStrokeColor.BackColor = colorDialog.Color;
            _changelog.Add("BorderColor", ColorTranslator.ToHtml(colorDialog.Color));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxImage.Checked)
            {
                listViewShape.Enabled = false;
                buttonFillColorDialog.Enabled = false;
                buttonBorderColorDialog.Enabled = false;
                buttonSetImage.Enabled = true;
                labelImgPath.Text = _entity.Image;
                labelImgPath.Visible = true;
                buttonSave.Enabled = !string.IsNullOrEmpty(_entity.Image);
                _changelog.Add("Category", TemplateCategories.Picture);
            }
            else
            {
                listViewShape.Enabled = true;
                buttonFillColorDialog.Enabled = true;
                buttonBorderColorDialog.Enabled = true;
                buttonSetImage.Enabled = false;
                labelImgPath.Text = "";
                labelImgPath.Visible = false;
                buttonSave.Enabled = true;
                _entity.Image = null;
                _changelog.Add("Category", TemplateCategories.Default);
            }
        }

        private void buttonSetImage_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            _changelog.Add("Image", openFileDialog.FileName);
            labelImgPath.Text = openFileDialog.FileName;
            buttonSave.Enabled = true;
            toolTip1.SetToolTip(labelImgPath, openFileDialog.FileName);
        }

        private void buttonSetFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            _changelog.Add("Font", FontManager.GetNorthwoodsFont(fontDialog.Font));
            _changelog.Add("FontColor", ColorTranslator.ToHtml(fontDialog.Color));
            _changelog.Add("IsStrikethrough", fontDialog.Font.Strikeout);
            _changelog.Add("IsUnderline", fontDialog.Font.Underline);
            labelFontInfo.Text = $"{fontDialog.Font.Name} {fontDialog.Font.Size} pt";
        }
    }
}
