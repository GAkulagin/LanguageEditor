using Northwoods.Go;
using System;


namespace LanguageEditor.ElementTemplates
{
    class ModelEntityTemplate : ITemplate
    {
        public Part GetTemplate()
        {
            return new Node("Auto")
            {
                Resizable = true,
                ResizeElementName = "Shape",
                SelectionElementName = "Shape",
                Rotatable = true,
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
                    new Shape()
                    {
                        Fill = "lightgray",
                        Name = "Shape",
                        MinSize = new Size(20, 20)
                    }
                    .Bind("Figure")
                    );
        }
    }
}
