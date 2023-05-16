using System;

namespace LanguageEditor.Models
{
    public class Attribute
    {
        private dynamic _value;

        private Type _type;

        public long Key { get; set; }

        public string Name { get; set; }

        public bool IsValueUnique { get; set; }

        public dynamic Value
        {
            get { return _value; }
            set
            {
                if (value == null) _value = null;
                else if (_type == value.GetType()) _value = value;
                else throw new WrongTypeException(
                    $"Value does not match the attribute's type: type is {_type}, value is {value.GetType()}"
                    );
            }
        }

        public Type Type
        {
            get { return _type; }
            set
            {
                _type = value;

                if (value.IsValueType) _value = Activator.CreateInstance(value);
                else if (value.GetType() == typeof(string)) _value = "";
                else _value = null;
            }
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


        public Attribute(Type type)
        {
            IdSetter.SetId(this);

            Name = "Attribute" + Key;
            IsValueUnique = false;
            Type = type;
        }
    }
}
