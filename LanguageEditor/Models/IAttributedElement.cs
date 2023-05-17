using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public interface IAttributedElement
    {
        List<Attribute> Attributes { get; set; }
    }
}
