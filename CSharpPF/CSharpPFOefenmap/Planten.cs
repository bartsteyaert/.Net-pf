using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public static class Planten
    {
        public static List<Plant> GetPlanten()
        {
            return new List<Plant>
            {
            new Plant { PlantId = 1, PlantenNaam = "Tulp", Kleur = "rood", Prijs = 0.50m, Soort = "bol" },
            new Plant { PlantId = 2, PlantenNaam = "Krokus", Kleur = "wit", Prijs = 0.20m, Soort = "bol" },
            new Plant { PlantId = 3, PlantenNaam = "Narcis", Kleur = "geel", Prijs = 0.30m, Soort = "bol" },
            new Plant { PlantId = 4, PlantenNaam = "Blauw druifje", Kleur = "blauw", Prijs = 0.20m, Soort = "bol" },
            new Plant { PlantId = 5, PlantenNaam = "Azalea", Kleur = "rood", Prijs = 3.00m, Soort = "heester" },
            new Plant { PlantId = 6, PlantenNaam = "Forsythia", Kleur = "geel", Prijs = 2.00m, Soort = "heester" },
            new Plant { PlantId = 7, PlantenNaam = "Magnolia", Kleur = "wit", Prijs = 4.00m, Soort = "heester" },
            new Plant { PlantId = 8, PlantenNaam = "Waterlelie", Kleur = "wit", Prijs = 2.00m, Soort = "water" },
            new Plant { PlantId = 9, PlantenNaam = "Lisdodde", Kleur = "geel", Prijs = 3.00m, Soort = "water" },
            new Plant { PlantId = 10, PlantenNaam = "Kalmoes", Kleur = "geel", Prijs = 2.50m, Soort = "water" },
            new Plant { PlantId = 11, PlantenNaam = "Bieslook", Kleur = "paars", Prijs = 1.50m, Soort = "kruid" },
            new Plant { PlantId = 12, PlantenNaam = "Rozemarijn", Kleur = "blauw", Prijs = 1.25m, Soort = "kruid" },
            new Plant { PlantId = 13, PlantenNaam = "Munt", Kleur = "wit", Prijs = 1.10m, Soort = "kruid" },
            new Plant { PlantId = 14, PlantenNaam = "Dragon", Kleur = "wit", Prijs = 1.30m, Soort = "kruid" },
            new Plant { PlantId = 15, PlantenNaam = "Basilicum", Kleur = "wit", Prijs = 1.50m, Soort = "kruid" }
            };
        }
    }
}

