using Northwoods.Go;

namespace LanguageEditor.ElementTemplates
{
    public class RotationSymbolTemplate
    {
        public Adornment GetAdornment()
        {
            return new Adornment { LocationSpot = Spot.Center }
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
                );
        }
    }
}