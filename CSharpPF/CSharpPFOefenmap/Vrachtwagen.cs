using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Vrachtwagen : Voertuig, IVervuiler
    {
        private float maxLadingValue;
        public float MaxLading
        {
            get
            {
                return maxLadingValue;
            }
            set
            {
                if (value >= 0f)
                    maxLadingValue = value;
            }
        }
        public Vrachtwagen()
            : base()
        {
            MaxLading = 10000f;
        }
        public Vrachtwagen(string polisHouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat, float maxLading)
            : base(polisHouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            MaxLading = maxLading;
        }

        public override void Afbeelden()
        {
            Console.WriteLine("Vrachtwagen");
            base.Afbeelden();
            Console.WriteLine("Maximum lading: {0}", MaxLading);
        }

        public override double GetKyotoScore()
        {
            double kyotoScore = 0.0;
            if (MaxLading != 0)
                kyotoScore = GemiddeldVerbruik * Pk / MaxLading / 1000.0;
            return kyotoScore;
        }

        public double GeefVervuiling()
        {
            return GetKyotoScore() * 20;
        }
    }
}
