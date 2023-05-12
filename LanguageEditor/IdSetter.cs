using LanguageEditor.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor
{
    internal static class IdSetter
    {
        private static long attributeIdCounter;
        private static long poleIdCounter;
        private static long relationIdCounter;
        private static long hyperedgeIdCounter;
        private static long entityIdCounter;
        private static long modelIdCounter;

        private static string configPath = @"G:\Users\User\source\repos\LanguageEditor\config.txt";

        public static void SetId(IAttribute attribute)
        {
            attribute.Id = attributeIdCounter;
            attributeIdCounter++;
        }

        public static void SetId(Pole pole)
        {
            pole.Id = poleIdCounter;
            poleIdCounter++;
        }

        public static void SetId(Relation relation)
        {
            relation.Id = relationIdCounter;
            relationIdCounter++;
        }

        public static void SetId(Entity entity)
        {
            entity.Key = entityIdCounter;
            entityIdCounter++;
        }

        public static void SetId(Hyperedge hyperedge)
        {
            hyperedge.Id = hyperedgeIdCounter;
            hyperedgeIdCounter++;
        }

        public static void SetId(ModelData model)
        {
            model.Id = modelIdCounter;
            modelIdCounter++;
        }


        public static void Init()
        {
            string[] lines = File.ReadAllLines(configPath);
            var dict = new Dictionary<string, long>();

            foreach(string line in lines)
            {
                string[] kvp = line.Split('=');

                dict.Add(kvp[0], Int64.Parse(kvp[1]));
            }

            attributeIdCounter = dict["attributeIdCounter"];
            poleIdCounter = dict["poleIdCounter"];
            relationIdCounter = dict["relationIdCounter"];
            hyperedgeIdCounter = dict["hyperedgeIdCounter"];
            entityIdCounter = dict["entityIdCounter"];
            modelIdCounter = dict["modelIdCounter"];
        }

        public static void Save()
        {
            string[] lines =
            {
                $"attributeIdCounter={attributeIdCounter}",
                $"poleIdCounter={poleIdCounter}",
                $"relationIdCounter={relationIdCounter}",
                $"hyperedgeIdCounter={hyperedgeIdCounter}",
                $"entityIdCounter={entityIdCounter}",
                $"modelIdCounter={modelIdCounter}"
            };

            File.WriteAllLines(configPath, lines);
        }
    }
}
