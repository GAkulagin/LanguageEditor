﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageEditor.Models
{
    public class Hyperedge : ModelData.LinkData, IAttributedElement, IPoledElement
    {
        public string Name { get; set; }
        public List<Relation> Relations { get; set; } = new List<Relation>();
        public List<Pole> Poles { get; } = new List<Pole>();


        public List<Attribute> Attributes { get; } = new List<Attribute>();


        public Hyperedge()
        {
            IdSetter.SetId(this);
        }
    }
}
