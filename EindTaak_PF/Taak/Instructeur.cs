using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taak
{
    public class Instructeur : Personeelslid
    {
        //properties
        public Vakgebied VakGebied { get; set; }

        private string emailAdresvalue;
        public string EmailAdres
        {
            get
            {
                return emailAdresvalue;
            }
            set
            {
                if (!value.Contains("@"))
                    throw new OngeldigEmailadresException("Ongeldig email-adres!", value);
                emailAdresvalue = value;
            }
        }

        //constructor
        public Instructeur(int personeelsNummer, string familienaam, string voornaam, decimal brutoLoon, Vakgebied vakgebied, string emailAdres)
            : base(personeelsNummer, familienaam, voornaam, brutoLoon)
        {
            VakGebied = vakgebied;
            EmailAdres = emailAdres;
        }

        //enum
        public enum Vakgebied
        {
            Ontwikkeling,
            Netwerken
        }

        // override
        public override void GegevensTonen()
        {
            base.GegevensTonen();
            Console.WriteLine("Vakgebied: {0}", VakGebied);
            Console.WriteLine("Emailadres: {0}", EmailAdres);
        }

        // inner class
        public class OngeldigEmailadresException : Exception
        {
            public string Email { get; set; }

            public OngeldigEmailadresException(string message, string email)
                : base(message)
            {
                Email = email;
            }
        }
    }
}
