using System;
using System.ComponentModel;
using System.Windows.Forms;
using LanguageEditor.Models;

namespace LanguageEditor.Views
{
    public partial class EntityEdit : Form
    {
        private Entity _entity;
        

        public EntityEdit(Entity e)
        {
            InitializeComponent();

            _entity = e;

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
            dataGridView.DataSource = new BindingList<Models.Attribute>(_entity.Attributes);
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoResizeColumns();

            if (dataGridView.Columns["Name"] != null) dataGridView.Columns["Name"].HeaderText = "Имя";
            if (dataGridView.Columns["TypeName"] != null) dataGridView.Columns["TypeName"].HeaderText = "Тип";
            if (dataGridView.Columns["IsValueUnique"] != null) dataGridView.Columns["IsValueUnique"].HeaderText = "Уникальный";

            if (dataGridView.Columns["Key"] != null) dataGridView.Columns["Key"].Visible = false;
            if (dataGridView.Columns["Value"] != null) dataGridView.Columns["Value"].Visible = false;

            if (dataGridView.Columns["Name"] != null) dataGridView.Columns["Name"].DisplayIndex = 0;
            if (dataGridView.Columns["TypeName"] != null) dataGridView.Columns["TypeName"].DisplayIndex = 1;
            if (dataGridView.Columns["IsValueUnique"] != null) dataGridView.Columns["IsValueUnique"].DisplayIndex = 2;
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
            _entity.Name = textBoxName.Text;
            _entity.MaxCount = (int)numericUpDownMaxCount.Value;
            _entity.IsAbstract = checkBoxIsAbstract.Checked;
            _entity.CanSetMaxCount = checkBoxCanSetMaxCount.Checked;

            Close();

            Entity.kjojjojoj(_entity);
        }

        private void buttonAddAttribute_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;
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
                _entity.Attributes.RemoveAt(dataGridView.CurrentRow.Index);
            }
        }
    }
}
