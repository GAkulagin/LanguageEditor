using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public class Pole : IEquatable<Pole>
    {
        public long Id { get; set; }
        public bool IsExternal { get; set; }

        
        public Pole()
        {
            IdSetter.SetId(this);
        }

        public bool Equals(Pole other)
        {
            return (this.Id == other.Id);
        }
    }
}
