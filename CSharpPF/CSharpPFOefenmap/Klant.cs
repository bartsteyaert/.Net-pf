using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    public class Klant
    {
        private string voornaamValue;
        public string Voornaam
        {
            set
            {
                if (value != null)
                    voornaamValue = value;
            }
            get
            {
                return voornaamValue;
            }
        }
        private string achternaamValue;
        public string Achternaam
        {
            get
            {
                return achternaamValue;
            }
            set
            {
                if (value != null)
                    achternaamValue = value;
            }
        }

        public void Afbeelden()
        {
            Console.WriteLine("{0} {1}", Voornaam, Achternaam);
        }

        public Klant(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }
    }
}
