using Northwoods.Go;

namespace LanguageEditor
{
    public static class FontTransformer
    {
        public static Northwoods.Go.Font Transform(System.Drawing.Font sysFont)
        {
            var style = sysFont.Italic ? FontStyle.Italic : FontStyle.Regular;
            var weight = sysFont.Bold ? FontWeight.Bold : FontWeight.Regular;

            return new Font(sysFont.Name, sysFont.Size, style, weight);
        }
    }
}