using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public class Hyperedge : IAttributedElement, IPoledElement
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Relation> Relations { get; set; } = new List<Relation>();
        public List<Pole> Poles { get; } = new List<Pole>();


        public List<IAttribute> Attributes { get; } = new List<IAttribute>();


        public Hyperedge()
        {
            IdSetter.SetId(this);
        }
    }
}
