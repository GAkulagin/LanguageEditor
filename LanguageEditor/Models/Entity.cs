using System.Collections.Generic;
using Northwoods.Go;


namespace LanguageEditor.Models
{
    public class Entity : DiagramModel.NodeData, IAttributedElement, IPoledElement
    {
        public string Name { get; set; }
        public bool IsAbstract { get; set; }
        public bool CanSetMaxCount { get; set; }
        public int MaxCount { get; set; }
        public Entity Ancestor { get; set; }

        public string Text { get; set; }
        public string Figure { get; set; }
        public string FillColor { get; set; }
        public string BorderColor { get; set; }
        public string Image { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Angle { get; set; }
        public Font Font { get; set; }
        public string FontColor { get; set; }
        public bool IsStrikethrough { get; set; }
        public bool IsUnderline { get; set; }

        public List<Pole> Poles { get; set; }
        public List<Attribute> Attributes { get; set; }

        public delegate void UpdateHandler(Entity e, Changelog changelog);
        public static event UpdateHandler EntityUpdated;

        public delegate void EditFormHandler(Entity e);
        public static event EditFormHandler CallEntityEditForm;

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
            Font = new Font("Arial", 12, FontStyle.Regular, FontWeight.Regular);
            FontColor = "#000000";
            IsStrikethrough = false;
            IsUnderline = false;
            Text = Name;
        }

        public static void UpdateEntityView(Entity e, Changelog changelog)
        {
            EntityUpdated?.Invoke(e, changelog);
        }

        public static void OpenEntityEditor(Entity e)
        {
            CallEntityEditForm?.Invoke(e);
        }
    }
}
