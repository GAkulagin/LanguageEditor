using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageEditor.Models;
using System.Windows.Forms;

namespace LanguageEditor.Views
{
    public partial class AttributeTypeSelect : Form
    {
        private IEditingForm _editor;
        
        public AttributeTypeSelect(IEditingForm form)
        {
            InitializeComponent();

            _editor = form;

            foreach (string name in DisplayedDataLists.ShortTypenames)
                comboBoxType.Items.Add(name);

            comboBoxType.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var typename = DisplayedDataLists.FullTypenames[comboBoxType.SelectedItem.ToString()];
            var attr = new Models.Attribute(Type.GetType((typename)));
            _editor.Attributes.Add(attr);

            Close();
        }
    }
}
