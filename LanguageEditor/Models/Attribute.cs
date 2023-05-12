using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public class Attribute<T> : IAttribute
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsValueUnique { get; set; }

        public T Value { get; set; }

        public Type Type
        {
            get { return typeof(T); }
        }

        // отображение типа данных в таблицах
        public string TypeName
        {
            get
            {
                if (AllowedTypes.TypeNames.ContainsKey(Type))
                    return AllowedTypes.TypeNames[Type];
                else
                    return "";
            }
        }


        public Attribute()
        {
            IdSetter.SetId(this);

            Name = "Attribute" + Id;
            IsValueUnique = false;
        }
    }
}
