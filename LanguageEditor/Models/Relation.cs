using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public class Relation : IAttributedElement
    {
        public long Id { get; set; }
        public string Name
        {
            get { return Name; }
            set { Name = value == null ? "" : value; }
        }
        public Pole SourcePole { get; set; }
        public Pole TargetPole { get; set; }
        public List<Entity> SourceEntities { get; set; } = new List<Entity>();
        public List<Entity> TargetEntities { get; set; } = new List<Entity>();


        public List<IAttribute> Attributes { get; } = new List<IAttribute>();


        public Relation()
        {
            IdSetter.SetId(this);
        }
    }
}
