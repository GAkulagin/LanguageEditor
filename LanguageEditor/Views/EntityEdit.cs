using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LanguageEditor.Models;

namespace LanguageEditor.Views
{
    public partial class EntityEdit : Form
    {
        private Entity _entity;
        private BindingList<IAttribute> _attributes;
        

        public EntityEdit(Entity e)
        {
            InitializeComponent();

            _entity = e;
            _attributes = new BindingList<IAttribute>(_entity.Attributes);

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
            dataGridView.DataSource = _attributes;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoResizeColumns();

            if (dataGridView.Columns["Name"] != null) dataGridView.Columns["Name"].HeaderText = "Имя";
            if (dataGridView.Columns["TypeName"] != null) dataGridView.Columns["TypeName"].HeaderText = "Тип";
            if (dataGridView.Columns["IsValueUnique"] != null) dataGridView.Columns["IsValueUnique"].HeaderText = "Уникальный";
            if (dataGridView.Columns["Id"] != null) dataGridView.Columns["Id"].Visible = false;
            if (dataGridView.Columns["Type"] != null) dataGridView.Columns["Type"].Visible = false;
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
            Close();
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
                _attributes.RemoveAt(dataGridView.CurrentRow.Index);
            }
        }
    }
}
