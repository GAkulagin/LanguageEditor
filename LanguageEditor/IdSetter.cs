using LanguageEditor.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageEditor.RepositoryClasses;

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
        
        public static void SetId(Models.Attribute attribute)
        {
            attribute.Key = attributeIdCounter;
            attributeIdCounter++;
        }

        public static void SetId(Pole pole)
        {
            pole.Key = poleIdCounter;
            poleIdCounter++;
        }

        public static void SetId(Relation relation)
        {
            relation.Key = relationIdCounter;
            relationIdCounter++;
        }

        public static void SetId(Entity entity)
        {
            entity.Key = entityIdCounter;
            entityIdCounter++;
        }

        public static void SetId(Hyperedge hyperedge)
        {
            hyperedge.Key = hyperedgeIdCounter;
            hyperedgeIdCounter++;
        }

        public static void SetId(ModelData model)
        {
            model.Key = modelIdCounter;
            modelIdCounter++;
        }


        public static void Init()
        {
            var idList = FileExtractor.GetObjectIdCounters();

            attributeIdCounter = idList[0];
            poleIdCounter = idList[1];
            relationIdCounter = idList[2];
            hyperedgeIdCounter = idList[3];
            entityIdCounter = idList[4];
            modelIdCounter = idList[5];
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

            FileExtractor.WriteObjectIdCounters(lines);
        }
    }
}
