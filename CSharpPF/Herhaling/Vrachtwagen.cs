using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling
{
    public class Vrachtwagen : Voertuig, IVervuiler
    {
        private float maximumLadingValue;

        public float MaximumLading
        {
            get { return maximumLadingValue; }
            set { if(value>=0) maximumLadingValue = value; }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine("(Max lading: {0})", MaximumLading);
        }

        public Vrachtwagen()
            :base()
        {
            MaximumLading = 10000f;            
        }
        public Vrachtwagen(string polishouder, decimal kostprijs, int pk, float gemiddeldVerbruik, string nummerplaat, float maxLading)
            :base(polishouder, kostprijs, pk, gemiddeldVerbruik, nummerplaat)
        {
            MaximumLading = maxLading;
        }

        public override double GetKyotoScore()
        {
            if(MaximumLading!=0)
            return GemiddeldVerbruik*Pk/MaximumLading;
            return 0;
        }

        public double GeefVervuiling()
        {
            return GetKyotoScore() * 20;
        }
    }
}
