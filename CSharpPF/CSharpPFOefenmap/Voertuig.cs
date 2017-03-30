using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public abstract class Voertuig : IPrivaat, IMilieu
    {
        private string polishouderValue;
        private decimal kostprijsValue;
        private int pkValue;
        private float gemiddeldVerbruikValue;
        private string nummerplaatValue;

        public string Polishouder
        {
            get
            {
                return polishouderValue;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    polishouderValue = value;
            }
        }

        public decimal Kostprijs
        {
            get
            {
                return kostprijsValue;
            }

            set
            {
                if (value >= 0m)
                    kostprijsValue = value;
            }
        }

        public int Pk
        {
            get
            {
                return pkValue;
            }

            set
            {
                if (value >= 0)
                    pkValue = value;
            }
        }

        public float GemiddeldVerbruik
        {
            get
            {
                return gemiddeldVerbruikValue;
            }
            set
            {
                if (value >= 0f)
                    gemiddeldVerbruikValue = value;
            }
        }

        public string Nummerplaat
        {
            get
            {
                return nummerplaatValue;
            }

            set
            {
                nummerplaatValue = value;
            }
        }

        public Voertuig() : this("onbepaald", 0m, 0, 0f, "onbepaald")
        {
        }

        public Voertuig(string polisHouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat)
        {
            Polishouder = polisHouder;
            Kostprijs = kostprijs;
            Pk = pk;
            GemiddeldVerbruik = gemiddeldVerbruik;
            Nummerplaat = nummerplaat;
        }

        public virtual void Afbeelden()
        {
            Console.WriteLine($"polishouder: {Polishouder}");
            Console.WriteLine($"kostprijs: {Kostprijs}");
            Console.WriteLine($"pk: {Pk}");
            Console.WriteLine($"gemiddeld verbruik: {GemiddeldVerbruik}");
            Console.WriteLine($"nummerplaat: {Nummerplaat}");
            Console.WriteLine($"Kyoto score: {GetKyotoScore()}");
        }

        public abstract double GetKyotoScore();

        public string GeefPrivateData()
        {
            return string.Format("Polishouder: {0}, nummerplaat: {1}", Polishouder, Nummerplaat);
        }

        public string GeefMilieuData()
        {
            return string.Format("Pk: {0}, kostprijs: {1}, verbruik: {2}", Pk, Kostprijs, GemiddeldVerbruik);
        }
    }
}
