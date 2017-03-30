using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    class ZichtRekening : Rekening
    {
        private decimal maxKredietValue;
        public decimal MaxKrediet
        {
            get
            {
                return maxKredietValue;
            }
            set
            {
                if (value <= 0)
                    maxKredietValue = value;
                else
                    throw new MaxKredietException("De maximum kredietwaarde moet negatief zijn. Foute waarde: ", value);
            }
        }

        public override void Afbeelden()
        {
            base.Afbeelden();
            Console.WriteLine($"Max krediet: {MaxKrediet}");
        }

        public ZichtRekening(string rekeningnummer, decimal beginSaldo, DateTime creatieDatum, decimal maxKrediet, Klant eigenaar)
            :base(rekeningnummer, beginSaldo, creatieDatum, eigenaar)
        {
            MaxKrediet = maxKrediet;
        }

        //inner classes
        public class MaxKredietException :Exception
        {
            private decimal verkeerdeMaxKredietValue;
            public decimal VerkeerdeMaxKrediet
            {
                get
                {
                    return verkeerdeMaxKredietValue;
                }
                set
                {
                    verkeerdeMaxKredietValue = value;
                }
            }

            public MaxKredietException(string message, decimal verkeerdeMaxKrediet)
                :base(message)
            {
                VerkeerdeMaxKrediet = verkeerdeMaxKrediet;
            }
        }
    }
}
