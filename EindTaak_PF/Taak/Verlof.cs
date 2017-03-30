using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taak
{
    public class Verlof
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
                    throw new Exception("Het verlof moet een naam hebben");
                naamValue = value;
            }
        }
        public DateTime BeginDatum { get; set; }
        public DateTime Einddatum { get; set; }


        // constructor
        public Verlof(string naam, DateTime begindatum, DateTime einddatum)
        {
            Naam = naam;
            BeginDatum = begindatum;
            Einddatum = einddatum;
        }
    }
}
