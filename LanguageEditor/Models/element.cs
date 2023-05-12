using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public class Element
    {
        public long Id { get; set; }
        public string Name
        {
            get { return Name; }
            set { Name = value == null ? "" : value; }
        }
        public List<IAttribute> Attributes { get; } = new List<IAttribute>();
    }
}
