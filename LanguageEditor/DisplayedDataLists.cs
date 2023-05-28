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

        private static List<string> _fromArrows = new List<string>
        {
            "",
            "BackwardOpenTriangle",
            "Backward",
            "StretchedDiamond",
            "Line",
            "DoubleLine",
            "BackSlash",
            "X",
            "OpenTriangle",
            "OpenTriangleLine",
            "ForwardSemiCircle",
            "PlusCircle"
        };
        private static List<string> _toArrows = new List<string>
        {
            "",
            "OpenTriangle",
            "Standard",
            "StretchedDiamond",
            "DoubleTriangle",
            "Line",
            "DoubleLine",
            "BackSlash",
            "X",
            "BackwardOpenTriangle",
            "BackwardOpenTriangleLine",
            "BackwardSemiCircle",
            "PlusCircle"
        };
        private static List<string> _strokeTypes = new List<string>
        {
            "solid",
            "dashed",
            "dotted",
            "dotdashed"
        };
        
        public static List<string> ShortTypenames => _typenames;
        public static Dictionary<string, string> FullTypenames => _types;
        public static Dictionary<string, string> Figures => _figures;
        public static List<string> FromArrows => _fromArrows;
        public static List<string> ToArrows => _toArrows;
        public static List<string> StrokeTypes => _strokeTypes;
    }
}
