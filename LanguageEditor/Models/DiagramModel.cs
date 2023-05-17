﻿using Northwoods.Go.Models;

namespace LanguageEditor.Models
{
    // Связует объект ModelData с представлением диаграммы northwoods
    public class DiagramModel : GraphLinksModel<Entity, long, object, Hyperedge, long, Pole>
    {
        public ModelData Data { get; set; }
        public long Key
        {
            get { return Data.Key; }
        }
        public new string Name
        {
            get { return Data.Name; }
            set { Data.Name = value; }
        }

        public DiagramModel(ModelData data)
        {
            Data = data;
        }


        public static DiagramModel GetFooModel()
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

            DiagramModel dmodel = new DiagramModel(model);
            dmodel.NodeDataSource = model.Entities;

            return dmodel;
        }
    }
}