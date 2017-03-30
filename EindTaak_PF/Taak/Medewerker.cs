using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taak
{
    public class Medewerker : Personeelslid
    {
        //properties
        private int aantalCursistenValue;
        public int AantalCursisten
        {
            get
            {
                return aantalCursistenValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Het aantal cursisten mag niet negatief zijn!");
                aantalCursistenValue = value;
            }
        }
        // constructor
        public Medewerker(int personeelsNummer, string familienaam, string voornaam, decimal brutoLoon, int aantalCursisten) 
            : base(personeelsNummer, familienaam, voornaam, brutoLoon)
        {
            AantalCursisten = aantalCursisten;
        }

        //override
        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine("Aantal cursisten: {0}", AantalCursisten);
        }
    }
}
