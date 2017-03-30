using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFOefenmap
{
    [Serializable]
    public class Tweet
    {
        public string Naam { get; set; }
        public DateTime Tijdstip { get; set; }
        private string berichtValue;
        public string Bericht
        {
            get
            {
                return berichtValue;
            }
            set
            {
                if (value.Length <= 140)
                {
                    berichtValue = value;
                }
            }
        }

        public override string ToString()
        {
            string datum;
            var verschil = DateTime.Now - Tijdstip;
            if (Tijdstip.AddDays(1) <= DateTime.Now)
            { // een dag of meer geleden 
                datum = Tijdstip.ToString("dd-MM-YYYY");
            }
            else if (Tijdstip.AddHours(1) <= DateTime.Now)
            { // een uur of langer
                datum = string.Format("{0} uur geleden", verschil.Hours);
            }
            else if (Tijdstip.AddMinutes(1) <= DateTime.Now)
            { // een minuut of langer
                datum = string.Format("{0} {1} geleden", verschil.Minutes, verschil.Minutes == 1 ? "minuut" : "minuten");
            }
            else
            { // minder dan een minuut
                datum = Tijdstip.ToShortTimeString();
            }
            return String.Format("{0}: {1} ({2})", Naam, Bericht, datum);
        }
    }
}
