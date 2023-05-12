using LanguageEditor.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageEditor.Views
{
    public partial class AttributeTypeSelect : Form
    {
        private List<IAttribute> _attributes;

        public AttributeTypeSelect(List<IAttribute> attributes)
        {
            InitializeComponent();

            _attributes = attributes;

            foreach(var kvp in AllowedTypes.Types)
            {
                comboBoxType.Items.Add(kvp.Key);
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            int selected = comboBoxType.SelectedIndex;
            if (selected != -1)
            {
                Type type = AllowedTypes.Types[(string)comboBoxType.Items[selected]];
            }
        }
    }
}
