using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor
{
    // содержит данные об изменениях элементов модели,
    // которые нужно отразить на диаграмме
    public class Changelog
    {
        private Dictionary<string, object> _changelog = new Dictionary<string, object>();

        public IReadOnlyDictionary<string, object> Log => _changelog;

        
        public void Add(string property, object value)
        {
            if (_changelog.ContainsKey(property))
                _changelog[property] = value;

            else _changelog.Add(property, value);
        }
    }
}
