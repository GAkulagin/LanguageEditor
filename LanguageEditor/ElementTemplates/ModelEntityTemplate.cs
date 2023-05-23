using Northwoods.Go;
using System;
using Northwoods.Go.Models;


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
                RotateAdornmentTemplate = new RotationSymbolTemplate().GetAdornment()
            }
                .Add(
                    new Shape()
                    {
                        Name = "Shape",
                        MinSize = new Size(20, 20)
                    }
                    .Bind("Figure")
                    .Bind("Fill", "FillColor")
                    .Bind("Stroke", "BorderColor")
                    .Bind(new Binding("Height").MakeTwoWay())
                    .Bind(new Binding("Width").MakeTwoWay()),
                    new TextBlock()
                        .Bind("Text", "Name")
                )
                .Bind("Category")
                .Bind(new Binding("Angle").MakeTwoWay());
        }
    }
}
