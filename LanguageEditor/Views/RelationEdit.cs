using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LanguageEditor.Models;
using Attribute = LanguageEditor.Models.Attribute;

namespace LanguageEditor.Views
{
    public partial class RelationEdit : Form, IEditingForm
    {
        private Relation _relation;
        private BindingList<Attribute> _bindingList;
        private Changelog _changelog;
        
        public BindingList<Attribute> Attributes => _bindingList;
        
        public RelationEdit(Relation relation)
        {
            InitializeComponent();

            _relation = relation;
            _bindingList = new BindingList<Attribute>(_relation.Attributes)
            {
                AllowNew = false
            };
            _changelog = new Changelog();
            
            ControlsSetup();
        }


        private void ControlsSetup()
        {
            textBoxName.Text = _relation.Name;
            tbRelationText.Text = _relation.Text;
            fontDialog.ShowEffects = true;
            fontDialog.ShowColor = true;
            fontDialog.Color = ColorTranslator.FromHtml(_relation.FontColor);
            colorDialog.Color = ColorTranslator.FromHtml(_relation.Color);
            panelColor.BackColor = colorDialog.Color;
            labelFontInfo.Text = $"{_relation.FontName} {_relation.FontSize} pt";

            ListViewSetup(lvFromArrow, DisplayedDataLists.FromArrows, _relation.FromArrow);
            ListViewSetup(lvToArrow, DisplayedDataLists.ToArrows, _relation.ToArrow);
            ListViewSetup(lvStroke, DisplayedDataLists.StrokeTypes, _relation.Stroke);
            ComboBoxSetup(cboxSource, _relation.SourceEntities);
            ComboBoxSetup(cboxTarget, _relation.TargetEntities);
            DataGridSetup();
        }
        private void DataGridSetup()
        {
            dgvAttrs.DataSource = _bindingList;
            dgvAttrs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAttrs.Columns["Name"].HeaderText = "Имя";
            dgvAttrs.Columns["IsValueUnique"].HeaderText = "Уникальный";

            dgvAttrs.Columns["Key"].Visible = false;
            dgvAttrs.Columns["Value"].Visible = false;

            dgvAttrs.Columns["Name"].DisplayIndex = 0;
            dgvAttrs.Columns["TypeName"].DisplayIndex = 1;
            dgvAttrs.Columns["IsValueUnique"].DisplayIndex = 2;

            dgvAttrs.Columns["TypeName"].ReadOnly = true;
        }
        private void ListViewSetup(ListView lv, IEnumerable<string> data, string current)
        {
            var imageIndex = 0;
            foreach (var elem in data)
            {
                lv.Items.Add(new ListViewItem()
                {
                    Tag = elem,
                    ImageIndex = imageIndex,
                    Selected = elem == current
                });
                imageIndex++;
            }
        }

        private void ComboBoxSetup(ComboBox cbox, IEnumerable<Entity> entities)
        {
            foreach (var entity in entities)
            {
                cbox.Items.Add(entity.Name);
            }
        }

        private void SaveRelation()
        {
            _relation.Name = textBoxName.Text;
            
            _changelog.Add("FromArrow", "");
            _changelog.Add("ToArrow", "OpenTriangle");
            _changelog.Add("StrokePattern", null);
            _changelog.Add("Text", tbRelationText.Text);
            
            if (lvFromArrow.SelectedItems.Count > 0) 
                _changelog.Add("FromArrow", lvFromArrow.SelectedItems[0].Tag.ToString());
            if (lvStroke.SelectedItems.Count > 0)
                //TODO rewrite this line, won't work now
                _changelog.Add("StrokePattern", lvStroke.SelectedItems[0].Tag as float[]);
            if (lvToArrow.SelectedItems.Count > 0)
                _changelog.Add("ToArrow", lvToArrow.SelectedItems[0].Tag.ToString());
                        
            //TODO: add source & target nodes update

            Relation.UpdateEntityView(_relation, _changelog);
        }

        
        private void btnAddAttr_Click(object sender, EventArgs e)
        {
            var form = new AttributeTypeSelect(this);
            form.Show();
        }

        private void btnDelAttr_Click(object sender, EventArgs e)
        {
            if (dgvAttrs.CurrentRow == null) return;

            var dlg = MessageBox.Show(
                $"Вы действительно хотите удалить атрибут {dgvAttrs.CurrentRow.Cells["Name"].Value}?", 
                "Подтверждение удаления", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(dlg == DialogResult.OK)
            {
                _bindingList.RemoveAt(dgvAttrs.CurrentRow.Index);
            }
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = panelColor.BackColor;

            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            panelColor.BackColor = colorDialog.Color;
            _changelog.Add("Color", ColorTranslator.ToHtml(colorDialog.Color));
        }

        private void btnSetFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            _changelog.Add("Font", FontManager.GetNorthwoodsFont(fontDialog.Font));
            _changelog.Add("FontColor", ColorTranslator.ToHtml(fontDialog.Color));
            _changelog.Add("IsStrikethrough", fontDialog.Font.Strikeout);
            _changelog.Add("IsUnderline", fontDialog.Font.Underline);
            labelFontInfo.Text = $"{fontDialog.Font.Name} {fontDialog.Font.Size} pt";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //SaveRelation();
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text))
            {
                btnSave.Enabled = false;
                labelNameInvalidMsg.Visible = true;
            }
            else
            {
                btnSave.Enabled = true;
                labelNameInvalidMsg.Visible = false;
            }
        }
    }
}