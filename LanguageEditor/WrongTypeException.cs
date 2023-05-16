using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor
{
    class WrongTypeException : Exception
    {
        public WrongTypeException(string message) : base(message) { }
    }
}
