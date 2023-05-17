using System.Collections.Generic;


namespace LanguageEditor.Models
{
    public class Entity : DiagramModel.NodeData, IAttributedElement, IPoledElement
    {
        public string Name { get; set; }
        public bool IsAbstract { get; set; }
        public bool CanSetMaxCount { get; set; }
        public int MaxCount { get; set; }
        public Entity Ancestor { get; set; }

        public List<Pole> Poles { get; set; }
        public List<Attribute> Attributes { get; set; }

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
            Attributes = new List<Attribute>();
        }

        public static void kjojjojoj(Entity e)
        {
            Entity.EntityChanged?.Invoke(e.Key);
        }
    }
}
