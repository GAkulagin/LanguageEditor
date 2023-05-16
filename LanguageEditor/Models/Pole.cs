using System;


namespace LanguageEditor.Models
{
    public class Pole : IEquatable<Pole>
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
    }
}
