using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public class Entity : ModelData.NodeData, IAttributedElement, IPoledElement, IDeepClonable<Entity>
    {
        public string Name { get; set; }
        public bool IsAbstract { get; set; }
        public bool CanSetMaxCount { get; set; }
        public int MaxCount { get; set; }
        public Entity Ancestor { get; set; }

        public List<Pole> Poles { get; }
        public List<IAttribute> Attributes { get; }

        public delegate void ChangeHandler(long key);
        public static event ChangeHandler EntityChanged;

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


        public Entity DeepCopy()
        {
            if (this == null) return null;

            Entity e = new Entity();
            e.Key = Key;
            e.Name = Name;
            e.IsAbstract = IsAbstract;
            e.CanSetMaxCount = CanSetMaxCount;
            e.MaxCount = MaxCount;
            e.Ancestor = Ancestor;

            foreach (Pole pole in Poles) e.Poles.Add(pole.DeepCopy());
            foreach (IAttribute attribute in Attributes) e.Attributes.Add(attribute.DeepCopy());

            return e;
        }

        public void DeepCopy(Entity e)
        {
            if (e == null) return;

            Key = e.Key;
            Name = e.Name;
            IsAbstract = e.IsAbstract;
            CanSetMaxCount = e.CanSetMaxCount;
            MaxCount = e.MaxCount;
            Ancestor = e.Ancestor;

            Poles.Clear();
            Attributes.Clear();

            foreach (Pole p in e.Poles) Poles.Add(p);
            foreach (IAttribute attr in e.Attributes) Attributes.Add(attr);
        }

        public static void kjojjojoj(Entity e)
        {
            Entity.EntityChanged?.Invoke(e.Key);
        }
    }
}
