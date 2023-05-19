using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageEditor.Models;

namespace LanguageEditor.Views
{
    public partial class EntityEdit : Form
    {
        private Entity _entity;
        private BindingList<Models.Attribute> _bindingList;

        public EntityEdit(Entity e)
        {
            InitializeComponent();

            _entity = e;
            _bindingList = new BindingList<Models.Attribute>(_entity.Attributes);
            _bindingList.AllowNew = false;

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

        private void SaveEntity()
        {
            _entity.Name = textBoxName.Text;
            _entity.MaxCount = (int)numericUpDownMaxCount.Value;
            _entity.IsAbstract = checkBoxIsAbstract.Checked;
            _entity.CanSetMaxCount = checkBoxCanSetMaxCount.Checked;

            Entity.kjojjojoj(_entity);
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
            if (dataGridView.CurrentRow == null) return;

            Models.Attribute attr = new Models.Attribute(typeof(string));
            _bindingList.Add(attr);

            Form form = new AttributeTypeSelect(attr);
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
    }
}
