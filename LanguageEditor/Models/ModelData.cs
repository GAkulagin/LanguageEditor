using System;
using System.Collections.Generic;


namespace LanguageEditor.Models
{
    // представляет только данные модели. Сериализуется в xml
    public class ModelData
    {
        public long Key { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public ModelData Metamodel { get; set; }
        public List<Entity> Entities { get; set; } = new List<Entity>();
        public List<Hyperedge> Hyperedges { get; set; } = new List<Hyperedge>();


        public ModelData()
        {
            IdSetter.SetId(this);
            Name = $"model{Key}";
            CreatedBy = "User01";
            CreationDate = DateTime.Now;
        }
    }
}