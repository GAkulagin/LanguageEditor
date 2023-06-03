namespace LanguageEditor
{
    public static class StrokeType
    {
        public static string Solid => "solid";
        public static string Dashed => "dashed";
        public static string Dotted => "dotted";
        public static string DotsAndDashes => "dotdashed";

        public static float[] GetPatternArray(string patternName)
        {
            switch (patternName)
            {
                case "solid":
                    return null;
                case "dashed":
                    return new[] { 4f, 2f };
                case "dotted":
                    return new[] { 2f, 2f };
                case "dotdashed":
                    return new[] { 6f, 6f, 2f, 2f };
                default:
                    return null;
            }
        }
    }
}