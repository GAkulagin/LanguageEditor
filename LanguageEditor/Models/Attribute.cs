using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LanguageEditor.Models
{
    public class Attribute
    {
        private dynamic _value;
        private Type _type;
        
        public long Key { get; set; }
        public string Name { get; set; }
        public bool IsValueUnique { get; set; }
        public string TypeName
        {
            get { return _type.FullName; }
            set
            {
                try
                {
                    _type = Type.GetType(value);

                    if (_type.IsValueType) _value = Activator.CreateInstance(_type);
                    else if (_type == typeof(string)) _value = "";
                    else _value = null;
                }
                catch(Exception e)
                {
                    _type = typeof(object);
                    _value = null;
                }
            }
        }
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
        
        
        public Attribute(){}

        public Attribute(Type type)
        {
            IdSetter.SetId(this);

            Name = "Attribute" + Key;
            IsValueUnique = false;
            TypeName = type.FullName;
        }
    }
}
