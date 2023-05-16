using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public class Pole : IEquatable<Pole>, IDeepClonable<Pole>
    {
        public long Key { get; set; }
        public bool IsExternal { get; set; }

        
        public Pole()
        {
            IdSetter.SetId(this);
        }


        public bool Equals(Pole other)
        {
            return (this.Key == other.Key);
        }

        public Pole DeepCopy()
        {
            if (this == null) return null;

            return new Pole
            {
                Key = this.Key,
                IsExternal = this.IsExternal
            };
        }
    }
}
