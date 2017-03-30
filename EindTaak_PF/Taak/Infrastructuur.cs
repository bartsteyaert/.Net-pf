using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taak
{
    public class Infrastructuur : IKost
    {
        //properties
        private string naamValue;
        public string Naam
        {
            get
            {
                return naamValue;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("De infrastructuur moet een naam hebben!");
                naamValue = value;
            }
        }

        private decimal maandHuurValue;
        public decimal MaandHuur
        {
            get
            {
                return maandHuurValue;
            }
            set
            {
                if (value < 0)
                    throw new Exception("De maandhuur mag niet negatief zijn!");
                maandHuurValue = value;
            }
        }

        //constructor
        public Infrastructuur(string naam, decimal maandhuur)
        {
            Naam = naam;
            MaandHuur = maandhuur;
        }

        //override
        public override string ToString()
        {
            return Naam;
        }

        //interface implementation
        public decimal Maandkost
        {
            get
            {
                return MaandHuur;
            }
        }

        public void GegevensTonen()
        {
            Console.WriteLine("Naam: {0}", Naam);
            Console.WriteLine("Maandhuur: {0} euro", MaandHuur);
            Console.WriteLine("Maandkost: {0} euro", Maandkost);
        }
    }
}
