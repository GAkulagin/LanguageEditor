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
        private Models.Attribute _attribute;

        public AttributeTypeSelect(Models.Attribute attr)
        {
            InitializeComponent();

            _attribute = attr;

            foreach (string name in DisplayedDataLists.ShortTypenames)
                comboBoxType.Items.Add(name);

            comboBoxType.SelectedIndex = 0;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            _attribute.TypeName = DisplayedDataLists.FullTypenames[comboBoxType.SelectedItem.ToString()];

            Close();
        }
    }
}
