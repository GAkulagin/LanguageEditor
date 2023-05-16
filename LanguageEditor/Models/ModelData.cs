using Northwoods.Go.Models;
using System;
using System.Collections.Generic;


namespace LanguageEditor.Models
{
    public class ModelData : GraphLinksModel<Entity, long, object, Hyperedge, long, Pole>
    {
        public long Key { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public ModelData Metamodel { get; set; }
        public List<Entity> Entities { get; set; } = new List<Entity>();
        public List<Hyperedge> Hyperedges { get; set; } = new List<Hyperedge>();


        public ModelData()
        {
            IdSetter.SetId(this);
            CreatedBy = "User01";
            CreationDate = DateTime.Now;
        }


        public static ModelData GetFooModel()
        {
            ModelData model = new ModelData();
            model.Name = "model sample";

            Entity entity1 = new Entity();
            entity1.Name = "human";
            entity1.MaxCount = 100;
            entity1.IsAbstract = false;
            entity1.Attributes.Add(new Attribute(typeof(string))
            {
                Name = "Name",
                IsValueUnique = false,
                Value = "Bill Clinton",
            });
            entity1.Attributes.Add(new Attribute(typeof(int))
            {
                Name = "Age",
                IsValueUnique = false,
                Value = 50,
            });
            model.Entities.Add(entity1);

            model.NodeDataSource = model.Entities;

            return model;
        }
    }
}
