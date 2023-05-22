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
            DataGridSetup();
        }


        private void ControlsSetup()
        {
            textBoxName.Text = _entity.Name;
            checkBoxIsAbstract.Checked = _entity.IsAbstract;
            checkBoxCanSetMaxCount.Checked = _entity.CanSetMaxCount;
            numericUpDownMaxCount.Value = _entity.MaxCount;
            if (!_entity.CanSetMaxCount)
                numericUpDownMaxCount.Enabled = false;
            
            ShapesImageListSetup();

            panelFillColor.BackColor = Color.LightGray;
            panelStrokeColor.BackColor = Color.Black;
            colorDialog.Color = Color.LightGray;
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
            if (listViewShape.SelectedItems.Count > 0) newfigure = listViewShape.SelectedItems[0].Tag.ToString();

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
    }
}
