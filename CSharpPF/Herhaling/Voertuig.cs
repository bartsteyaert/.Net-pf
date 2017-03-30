using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling
{
    public abstract class Voertuig
    {
        public string Polishouder { get; set; }
        private decimal kostprijsValue;
        public decimal Kostprijs
        {
            get
            {
                return kostprijsValue;
            }
            set
            {
                if (value >= 0)
                    kostprijsValue = value;
            }
        }

        private int pKValue;
        public int Pk
        {
            get
            {
                return pKValue;
            }
            set
            {
                if (value >= 0)
                    pKValue = value;
            }
        }
        private float gemiddeldVerbruikValue;
        public float GemiddeldVerbruik
        {
            get
            {
                return gemiddeldVerbruikValue;
            }
            set
            {
                if (value >= 0)
                    gemiddeldVerbruikValue = value;
            }
        }
        public string Nummerplaat { get; set; }

        public Voertuig()
            :this("Onbekend", 0.0m, 0, 0.0f, "Onbekend")
        {
        }

        public Voertuig(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat)
        {
            Polishouder = polishouder;
            Kostprijs = kostprijs;
            Pk = pk;
            GemiddeldVerbruik = gemiddeldVerbruik;
            Nummerplaat = nummerplaat;
        }

        public virtual void Afbeelden()
        {
            Console.WriteLine("Polishouder: {0}, nummerplaat: {1}", Polishouder, Nummerplaat);
        }

        public override string ToString()
        {
            return Nummerplaat;
        }

        public abstract double GetKyotoScore();
    }
}
