using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor
{
    internal static class AllowedTypes
    {
        private static Dictionary<Type, string> _typenames = new Dictionary<Type, string>
        {
            { typeof(string), "строка" },
            { typeof(int), "целое число" },
            { typeof(double), "вещественное число" },
            { typeof(DateTime), "дата" }
        };
        private static Dictionary<string, Type> _types = new Dictionary<string, Type>
        {
            { "строка",  typeof(string) },
            { "целое число", typeof(int) },
            { "вещественное число", typeof(double) },
            { "дата", typeof(DateTime) }
        };


        public static Dictionary<Type, string> TypeNames
        {
            get { return _typenames; }
        }

        public static Dictionary<string, Type> Types
        {
            get { return _types; }
        }
    }
}
