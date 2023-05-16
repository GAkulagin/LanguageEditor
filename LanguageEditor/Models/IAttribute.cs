using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public interface IAttribute : IDeepClonable<IAttribute>
    {
        long Key { get; set; }
        string Name { get; set; }
        bool IsValueUnique { get; set; }
        Type Type { get; }
        string TypeName { get; }
    }
}
