using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public class Entity : ModelData.NodeData, IAttributedElement, IPoledElement
    {
        public string Name { get; set; }
        public bool IsAbstract { get; set; }
        public bool CanSetMaxCount { get; set; }
        public int MaxCount { get; set; }
        public Entity Ancestor { get; set; }

        public List<Pole> Poles { get; }

        public List<IAttribute> Attributes { get; }


        public Entity()
        {
            IdSetter.SetId(this);

            Name = "Entity" + Key;
            IsAbstract = false;
            CanSetMaxCount = false;
            MaxCount = 0;
            Ancestor = null;
            Poles = new List<Pole>();
            Attributes = new List<IAttribute>();
        }
    }
}
