using LanguageEditor.ElementTemplates.ContextMenuCommands;
using Northwoods.Go;

namespace LanguageEditor.ElementTemplates
{
    public class ModelRelationTemplate : ITemplate
    {
        public Part GetTemplate()
        {
            return new Link()
                {
                    ContextMenu = new ContextMenuAdornment(
                        new EditLinkCommand(), 
                        new RemoveLinkCommand(),
                        new ViewRelationCommand()
                    ).GetAdornment()
                }
                .Add(
                    new Shape(){ Width = 2 }
                        .Bind("StrokeDashArray", "StrokePattern")
                        .Bind("Stroke", "Color"),
                    new Shape()
                        .Bind("FromArrow")
                        .Bind("Stroke", "Color"),
                    new Shape()
                        .Bind("ToArrow")
                        .Bind("Stroke", "Color"),
                    new TextBlock() { SegmentOffset = new Point(0, -10) }
                        .Bind("Text")
                        .Bind("Font")
                        .Bind("Stroke", "FontColor")
                        .Bind("IsStrikethrough")
                        .Bind("IsUnderline")
                );
        }

    }
}