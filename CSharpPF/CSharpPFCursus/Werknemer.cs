using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Personeel
{
    public abstract partial class Werknemer : IKost
    {
        private string naamValue;
        private DateTime inDienstValue;
        private Geslacht geslachtValue;
        private int salarisValue;
        private static DateTime personeelsfeestValue;

        public static DateTime Personeelfeest
        {
            get
            {
                return personeelsfeestValue;
            }
            set
            {
                personeelsfeestValue = value;
            }
        }

        public int Salaris
        {
            get { return salarisValue; }
            private set
            {
                if (value >= 0m)
                    salarisValue = value;
            }
        }

        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (value != string.Empty)
                    naamValue = value;
            }
        }

        public DateTime InDienst
        {
            get
            {
                return inDienstValue.Date;
            }

            set
            {
                inDienstValue = value;
            }
        }

        public Geslacht Geslacht
        {
            get
            {
                return geslachtValue;
            }

            set
            {
                geslachtValue = value;
            }
        }

        public bool VerjaarAncien
        {
            get
            {
                return inDienstValue.Month == DateTime.Today.Month &&
                    inDienstValue.Day == DateTime.Today.Day;
            }

        }

        public virtual void Afbeelden()
        {
            Console.WriteLine("Naam: {0}", Naam);
            Console.WriteLine($"Geslacht: {Geslacht}");
            Console.WriteLine($"In dienst: {InDienst}");
            Console.WriteLine($"Personeelsfeest: {Personeelfeest}");
            if (Afdeling != null)
                Console.WriteLine(Afdeling);
        }

        public Werknemer() : this("Onbekend", DateTime.Today, Geslacht.Man)
        {
        }

        public Werknemer(string naam, DateTime inDienst, Geslacht geslacht)
        {
            Naam = naam;
            InDienst = inDienst;
            Geslacht = geslacht;
        }

        static Werknemer()
        {
            Personeelfeest = new DateTime(DateTime.Today.Year, 2, 1);
            while (Personeelfeest.DayOfWeek != DayOfWeek.Friday)
                Personeelfeest = Personeelfeest.AddDays(1);
        }

        public override string ToString()
        {
            return Naam + ' ' + Geslacht;
        }

        public override bool Equals(object obj)
        {
            if (obj is Werknemer)
            {
                Werknemer deAndere = (Werknemer)obj;
                return this.Naam == deAndere.Naam;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Naam.GetHashCode();
        }

        public abstract decimal Premie
        {
            get;
        }

        private Afdeling afdelingValue;
        public Afdeling Afdeling
        {
            get
            {
                return afdelingValue;
            }
            set
            {
                afdelingValue = value;
            }
        }

        private WerkRegime regimeValue;
        public WerkRegime Regime
        {
            get
            {
                return regimeValue;
            }
            set
            {
                regimeValue = value;
            }
        }

        public abstract decimal Bedrag
        {
            get;
        }

        public bool Menselijk
        {
            get
            {
                return true;
            }
        }

        public static void UitgebreideWerknemersLijst(Werknemer[] werknemers)
        {
            Console.WriteLine("Uitgebruide werknemerslijst:");
            foreach (Werknemer werknemer in werknemers)
                werknemer.Afbeelden();
        }

        public static void KorteWerknemersLijst(Werknemer[] werknemers)
        {
            Console.WriteLine("Korte werknemerslijst:");
            foreach (Werknemer werknemer in werknemers)
            {
                Console.WriteLine(werknemer.ToString());
            }
        }
    }
}
