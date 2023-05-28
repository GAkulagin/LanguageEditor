using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwoods.Go;

namespace LanguageEditor.Models
{
    public class Relation : DiagramModel.LinkData, IAttributedElement
    {
        private Font _font;

        public string Name { get; set; }
        public Pole SourcePole { get; set; }
        public Pole TargetPole { get; set; }
        public string FromArrow { get; set; }
        public string ToArrow { get; set; }
        public string Color { get; set; }
        public string Stroke { get; set; }
        public float[] StrokePattern { get; set; }
        public Font Font
        {
            get => _font;
            set
            {
                _font = value;
                FontName = _font.Family;
                FontSize = _font.Size;
                IsItalic = _font.IsItalic;
                IsBold = _font.Weight == FontWeight.Bold;
            }
        }
        public string FontName { get; set; }
        public float FontSize { get; set; }
        public string FontColor { get; set; }
        public bool IsItalic { get; set; }
        public bool IsBold { get; set; }
        public bool IsStrikethrough { get; set; }
        public bool IsUnderline { get; set; }
        public List<Entity> SourceEntities { get; set; } = new List<Entity>();
        public List<Entity> TargetEntities { get; set; } = new List<Entity>();
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
        
        public delegate void UpdateHandler(Relation r, Changelog changelog);
        public static event UpdateHandler RelationUpdated;


        public Relation()
        {
            IdSetter.SetId(this);
            FontName = "Arial";
            FontSize = 12.0f;
            FontColor = "#000000";
            IsBold = false;
            IsItalic = false;
            IsStrikethrough = false;
            IsUnderline = false;
            Font = FontManager.GetNorthwoodsFont(FontName, FontSize, IsBold, IsItalic);
            FromArrow = "";
            ToArrow = "OpenTriangle";
            Color = "#000000";
            StrokePattern = null;
            Stroke = StrokeType.Solid;
            Text = Name;
        }
        
        public static void UpdateEntityView(Relation rel, Changelog changelog)
        {
            RelationUpdated?.Invoke(rel, changelog);
        }
    }
}
