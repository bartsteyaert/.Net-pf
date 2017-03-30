using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taak
{
    public abstract class Personeelslid : IKost
    {
        // properties
        private int? personeelsNummerValue;
        public int? PersoneelsNummer
        {
            get
            {
                return personeelsNummerValue;
            }
            set
            {
                if (personeelsNummerValue.HasValue)
                    throw new Exception("Het personeelsnummer kan niet gewijzigd worden!");
                if (value < 0)
                    throw new Exception("Het personeelsnummer moet positief zijn!");
                personeelsNummerValue = value;
            }
        }
        private decimal brutoLoonValue;
        public decimal BrutoLoon
        {
            get
            {
                return brutoLoonValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Loon mag niet negatief zijn!");
                brutoLoonValue = value;
            }
        }

        private string familienaamValue;
        public string Familienaam
        {
            get
            {
                return familienaamValue;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Familienaam moet een waarde bevatten!");
                familienaamValue = value;
            }
        }

        private string voornaamValue;
        public string Voornaam
        {
            get
            {
                return voornaamValue;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Voornaam moet een waarde bevatten!");
                voornaamValue = value;
            }
        }

        public static Verlof[] VerlofPeriodes { get; set; }


        // constructor
        public Personeelslid(int personeelsNummer, string familienaam, string voornaam, decimal brutoLoon)
        {
            PersoneelsNummer = personeelsNummer;
            Familienaam = familienaam;
            Voornaam = voornaam;
            BrutoLoon = brutoLoon;
        }
        // interface implementation
        public decimal Maandkost
        {
            get
            {
                return (BrutoLoon * 60 / 100);
            }
        }

        public virtual void GegevensTonen()
        {
            Console.WriteLine("Personeelsnummer: {0}", PersoneelsNummer);
            Console.WriteLine("Naam: {0} {1}", Voornaam, Familienaam);
            Console.WriteLine("Brutoloon: {0:0.00} euro", BrutoLoon);
            Console.WriteLine("MaandKost: {0:0.00} euro", Maandkost);
            Console.WriteLine("Verlofperiodes: ");
            if (VerlofPeriodes != null)
            {
                foreach(Verlof verlof in VerlofPeriodes)
                {
                    Console.WriteLine("\t{0}: begin {1}, eind {2}", verlof.Naam, verlof.BeginDatum.ToShortDateString(), verlof.Einddatum.ToShortDateString());
                }
            }
            else
                Console.WriteLine("\tOnbekend");
        }

        //override
        public override string ToString()
        {
            return Voornaam + " " + Familienaam; 
        }
    }
}
