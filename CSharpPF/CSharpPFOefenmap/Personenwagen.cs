using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Personenwagen : Voertuig, IVervuiler
    {
        private int aantalDeurenValue;
        public int AantalDeuren
        {
            get
            {
                return aantalDeurenValue;
            }
            set
            {
                if (value >= 0)
                    aantalDeurenValue = value;
            }
        }

        private int aantalPassagiersValue;
        public int AantalPassagiers
        {
            set
            {
                if (value >= 0)
                    aantalPassagiersValue = value;
            }
            get
            {
                return aantalPassagiersValue;
            }
        }

        public Personenwagen()
            : base()
        {
            AantalDeuren = 4;
            AantalPassagiers = 5;
        }

        public Personenwagen(string polisHouder, decimal kostprijs, int pk,
                             float gemiddeldVerbruik, string nummerplaat, int aantalDeuren,
                             int aantalPassagiers)
            : base(polisHouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            AantalDeuren = aantalDeuren;
            AantalPassagiers = aantalPassagiers;
        }

        public override void Afbeelden()
        {
            Console.WriteLine("Personenwagen");
            base.Afbeelden();
            Console.WriteLine("Aantal deuren: {0}", AantalDeuren);
            Console.WriteLine("Aantal passagiers: {0}", AantalPassagiers);
        }

        public override double GetKyotoScore()
        {
            double KyotoScore = 0.0;
            if (AantalPassagiers != 0)
                KyotoScore = GemiddeldVerbruik *Pk / AantalPassagiers;
            return KyotoScore;
        }

        public double GeefVervuiling()
        {
            return GetKyotoScore() * 5;
        }
    }
}
