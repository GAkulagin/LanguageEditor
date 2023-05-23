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

        public string Figure { get; set; }
        public string FillColor { get; set; }
        public string BorderColor { get; set; }
        public string Image { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Angle { get; set; }

        public List<Pole> Poles { get; set; }
        public List<Attribute> Attributes { get; set; }

        public delegate void ChangeHandler(Entity e, Changelog changelog);
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
            Figure = "Rectangle";
            FillColor = "#D3D3D3";
            BorderColor = "#000000";
            Category = TemplateCategories.Default;
            Height = 64.0;
            Width = 64.0;
            Angle = 0.0;
        }

        public static void UpdateEntityView(Entity e, Changelog changelog)
        {
            Entity.EntityChanged?.Invoke(e, changelog);
        }
    }
}
