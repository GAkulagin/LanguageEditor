using Northwoods.Go;

namespace LanguageEditor
{
    public static class FontManager
    {
        public static Font GetNorthwoodsFont(string fontname, float size, bool isBold, bool isItalic)
        {
            var style = isItalic ? FontStyle.Italic : FontStyle.Regular;
            var weight = isBold ? FontWeight.Bold : FontWeight.Regular;
            
            return new Font(fontname, size, style, weight);
        }
        public static Font GetNorthwoodsFont(System.Drawing.Font sysFont)
        {
            var style = sysFont.Italic ? FontStyle.Italic : FontStyle.Regular;
            var weight = sysFont.Bold ? FontWeight.Bold : FontWeight.Regular;

            return new Font(sysFont.Name, sysFont.Size, style, weight);
        }
    }
}