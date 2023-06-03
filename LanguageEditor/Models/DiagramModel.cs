using Northwoods.Go.Models;

namespace LanguageEditor.Models
{
    // Связует объект ModelData с представлением диаграммы northwoods
    public class DiagramModel : GraphLinksModel<Entity, long, object, Relation, long, Pole>
    {
        public ModelData Data { get; }
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
            NodeDataSource = data.Entities;
            LinkDataSource = data.Relations;
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

            return dmodel;
        }

        public static DiagramModel GetPredefinedFigures()
        {
            ModelData model = new ModelData();
            model.Name = "predefined figures";

            foreach (var kvp in DisplayedDataLists.Figures)
                model.Entities.Add(new Entity() { Figure = kvp.Key });

            DiagramModel dmodel = new DiagramModel(model);

            return dmodel;
        }
    }
}
