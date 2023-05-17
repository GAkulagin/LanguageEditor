using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public class Relation : IAttributedElement
    {
        public long Key { get; set; }
        public string Name { get; set; }
        public Pole SourcePole { get; set; }
        public Pole TargetPole { get; set; }
        public List<Entity> SourceEntities { get; set; } = new List<Entity>();
        public List<Entity> TargetEntities { get; set; } = new List<Entity>();
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();


        public Relation()
        {
            IdSetter.SetId(this);
        }
    }
}
