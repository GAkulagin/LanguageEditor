using Northwoods.Go;

namespace LanguageEditor.ElementTemplates
{
    public class PictureTemplate : ITemplate
    {
        public Part GetTemplate()
        {
            return new Node("Vertical")
            {
                Resizable = true,
                Rotatable = true,
                ResizeElementName = "Shape",
                SelectionElementName = "Shape",
                LocationSpot = Spot.Center,
                RotateAdornmentTemplate = new Adornment { LocationSpot = Spot.Center }
                    .Add(
                        new Shape("BpmnActivityLoop")
                        {
                            Width = 12,
                            Height = 12,
                            Cursor = "pointer",
                            Background = "transparent",
                            Stroke = "dodgerblue",
                            StrokeWidth = 2
                        }
                    )
            }
                .Add(
                    new Panel("Auto")
                        {
                            Name = "Shape",
                            MinSize = new Size(20,20),
                            MaxSize = new Size(256,256),
                        }
                        .Add(
                            new Picture().Bind("Source", "Image")
                        ),
                    new TextBlock().Bind("Text", "Name")
                ).Bind("Category");
        }
    }
}