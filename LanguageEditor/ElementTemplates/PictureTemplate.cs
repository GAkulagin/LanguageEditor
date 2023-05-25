using LanguageEditor.ElementTemplates.ContextMenuCommands;
using Northwoods.Go;
using Northwoods.Go.Models;

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
                ResizeElementName = "Panel",
                SelectionElementName = "Panel",
                LocationSpot = Spot.Center,
                RotateAdornmentTemplate = new RotationSymbolTemplate().GetAdornment(),
                ContextMenu = new ContextMenuAdornment(
                    new EditNodeCommand(), 
                    new RemoveNodeCommand()
                ).GetAdornment()
            }
                .Add(
                    new Panel("Auto")
                        {
                            Name = "Panel",
                            MinSize = new Size(20,20),
                            MaxSize = new Size(256,256),
                        }
                        .Add(
                            new Picture().Bind("Source", "Image")
                        )
                        .Bind(new Binding("Height").MakeTwoWay())
                        .Bind(new Binding("Width").MakeTwoWay()),
                    new TextBlock()
                        .Bind("Text")
                        .Bind("Font")
                        .Bind("Stroke", "FontColor")
                        .Bind("IsStrikethrough")
                        .Bind("IsUnderline")
                )
                .Bind("Category")
                .Bind(new Binding("Angle").MakeTwoWay())
                .Bind(new Binding("Location").MakeTwoWay());
        }
    }
}