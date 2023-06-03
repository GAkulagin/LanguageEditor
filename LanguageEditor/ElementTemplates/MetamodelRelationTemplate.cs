using Northwoods.Go;

namespace LanguageEditor.ElementTemplates
{
    public class MetamodelRelationTemplate : ITemplate
    {
        public Part GetTemplate()
        {
            return new Link()
                .Add(
                    new Shape() { Width = 2 },
                    new Shape() { ToArrow = "OpenTriangle" },
                    new TextBlock() { SegmentOffset = new Point(0, -10) }
                        .Bind("Text", "Name")
                );
        }
    }
}