using LanguageEditor.ElementTemplates.ContextMenuCommands;
using Northwoods.Go;
using Northwoods.Go.Models;

namespace LanguageEditor.ElementTemplates
{
    public class MetamodelEntityTemplate : ITemplate
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
                    RotateAdornmentTemplate = new RotationSymbolTemplate().GetAdornment(),
                    ContextMenu = new ContextMenuAdornment(
                        new EditNodeCommand(), 
                        new RemoveNodeCommand()
                    ).GetAdornment()
                }
                .Add(
                    new Shape()
                        {
                            Name = "Shape",
                            MinSize = new Size(20, 20),
                            Figure = "RoundedRectangle",
                            Fill = "lightgray",
                        }
                        .Bind(new Binding("Height").MakeTwoWay())
                        .Bind(new Binding("Width").MakeTwoWay()),
                    new TextBlock()
                        .Bind("Text", "Name")
                )
                .Bind(new Binding("Angle").MakeTwoWay())
                .Bind(new Binding("Location").MakeTwoWay());
        }
    }
}