using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{

    public class Kasbon : ISpaarmiddel
    {
        //properties
        private readonly DateTime eersteDatum = new DateTime(1900, 1, 1);


        private DateTime aankoopDatumValue;
        public DateTime AankoopDatum
        {
            get
            {
                return aankoopDatumValue;
            }
            set
            {
                if (value >= eersteDatum)
                {
                    aankoopDatumValue = value;
                }
            }
        }


        private decimal bedragValue;
        public decimal Bedrag
        {
            get
            {
                return bedragValue;
            }
            set
            {
                if (value < 0m)
                    throw new Exception("Bedrag moet positief zijn");
                    bedragValue = value;
            }
        }


        private int looptijdValue;
        public int Looptijd
        {
            get
            {
                return looptijdValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Looptijd moet positief zijn");
                looptijdValue = value;
            }
        }


        private decimal intrestValue;
        public decimal Intrest
        {
            get
            {
                return intrestValue;
            }
            set
            {
                if (value <= 0m)
                    throw new Exception("Intrestwaarde moet positief zijn");
                intrestValue = value;

            }
        }


        private Klant eigenaarValue;
        public Klant Eigenaar
        {
            get
            {
                return eigenaarValue;
            }
            set
            {
                if (value != null)
                    eigenaarValue = value;
            }
        }

        //constructor
        public Kasbon(DateTime aankoopDatum, decimal bedrag, int looptijd, decimal intrest, Klant eigenaar)
        {
            AankoopDatum = aankoopDatum;
            Bedrag = bedrag;
            Looptijd = looptijd;
            Intrest = intrest;
            Eigenaar = eigenaar;
        }

        //methods

        public void Afbeelden()
        {
            if (Eigenaar != null)
            {
                Console.Write("Eigenaar: ");
                Eigenaar.Afbeelden();
            }
            Console.WriteLine("Aankoopdatum: {0:dd-MM-yyyy}", AankoopDatum);
            Console.WriteLine("Bedrag: {0}", Bedrag);
            Console.WriteLine("Looptijd: {0}", Looptijd);
            Console.WriteLine("Intrest: {0}", Intrest);
        }
    }
}
