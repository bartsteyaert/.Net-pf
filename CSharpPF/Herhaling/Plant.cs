﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling
{
    public class Plant
    {
        public int PlantId { get; set; }
        public string PlantenNaam { get; set; }
        public string Kleur { get; set; }
        public decimal Prijs { get; set; }
        public string Soort { get; set; }

        public override string ToString()
        {
            return PlantenNaam;
        }
    }
}
