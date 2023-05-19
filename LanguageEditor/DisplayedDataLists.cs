using System;
using System.Collections.Generic;

namespace LanguageEditor
{
    // предоставляет коллекции данных для отображения на формах: допустимые значения, отображаемые имена и т.д.
    internal static class DisplayedDataLists
    {
        private static List<string> _typenames = new List<string>
        {
            "строка",
            "целое число",
            "вещественное число",
            "дата"
        };
        private static Dictionary<string, string> _types = new Dictionary<string, string>
        {
            { "строка",  typeof(string).FullName },
            { "целое число", typeof(int).FullName },
            { "вещественное число", typeof(double).FullName },
            { "дата", typeof(DateTime).FullName }
        };
        private static List<string> _figures = new List<string>
        {
            "Rectangle",
            "RoundedRectangle",
            "FramedRectangle",
            "Parallelogram",
            "Trapezoid",
            "Square",
            "Circle",
            "Ellipse",
            "Triangle",
            "TriangleRight",
            "TriangleLeft",
            "TriangleDown",
            "Diamond",
            "Pentagon",
            "Hexagon",
            "Heptagon",
            "Octagon",
            "Procedure",
            "Cloud"
        };

        public static List<string> ShortTypenames
        {
            get { return _typenames; }
        }

        public static Dictionary<string, string> FullTypenames
        {
            get { return _types; }
        }

        public static List<string> Figures
        {
            get { return _figures; }
        }
    }
}
