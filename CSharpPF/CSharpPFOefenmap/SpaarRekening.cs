using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class SpaarRekening : Rekening
    {
        private static decimal intrestValue;
        public static decimal Intrest
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Waarde moet positief zijn");
                intrestValue = value;
            }
        }

        public SpaarRekening(string rekeningnummer, decimal beginSaldo, DateTime creatieDatum, Klant eigenaar)
            : base(rekeningnummer, beginSaldo, creatieDatum, eigenaar)
        {
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Intrest: {Intrest}");
        }

        static SpaarRekening()
        {
            Intrest = 0.6m;
        }
    }
}
