using System;
using System.Collections.Generic;
using LanguageEditor.RepositoryClasses;


namespace LanguageEditor.Models
{
    // представляет только данные модели. Сериализуется в xml
    public class ModelData
    {
        public long Key { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string FilePath { get; set; }
        public ModelData Metamodel { get; set; }
        public List<Entity> Entities { get; set; } = new List<Entity>();
        public List<Relation> Relations { get; set; } = new List<Relation>();


        public ModelData()
        {
            IdSetter.SetId(this);
            Name = $"model{Key}";
            CreatedBy = "User01";
            CreationDate = DateTime.Now;
        }
    }
}