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

        // order must be equal to EntityEdit.listViewShape.LargeImageList items
        private static Dictionary<string, string> _figures = new Dictionary<string, string>
        {
            { "Rectangle",  "Прямоугольник" },
            { "RoundedRectangle", "Прямоугольник с закругленными краями" },
            { "FramedRectangle", "Рамка" },
            { "Parallelogram",  "Параллелограм" },
            { "Trapezoid", "Трапеция" },
            { "Square", "Квадрат" },
            { "Circle",  "Круг" },
            { "Ellipse", "Эллипс" },
            { "Triangle", "Треугольник" },
            { "TriangleRight",  "Треугольник, вправо" },
            { "TriangleLeft", "Треугольник, влево" },
            { "TriangleDown", "Треугольник, вниз" },
            { "Diamond",  "Ромб" },
            { "Pentagon", "Пятиугольник" },
            { "Hexagon", "Шестиугольник" },
            { "Heptagon",  "Семиугольник" },
            { "Octagon", "Восьмиугольник" },
            { "Procedure", "Подпроцесс" },
            { "Cloud", "Облако" },
        };

        public static List<string> ShortTypenames
        {
            get { return _typenames; }
        }

        public static Dictionary<string, string> FullTypenames
        {
            get { return _types; }
        }

        public static Dictionary<string, string> Figures
        {
            get { return _figures; }
        }
    }
}
