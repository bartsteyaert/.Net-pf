using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling
{
    [Serializable]
    public class Tweet
    {
        public string Naam { get; set; }
        public string Bericht { get; set; }
        public DateTime Tijdstip { get; } = DateTime.Now;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(Naam + ": " + Bericht + "\n(");
            var verschil = DateTime.Now - Tijdstip;
            if (verschil.Days > 1)
                sb.Append(Tijdstip.ToShortDateString());
            else if (verschil.Hours > 1)
                sb.Append(verschil.Hours + verschil.Hours > 1 ? "uren" : "uur" + " geleden");
            else if (verschil.Minutes > 1)
                sb.Append(verschil.Minutes + " minuten geleden");
            else
                sb.Append(Tijdstip.ToShortTimeString());
            sb.Append(")");
            return sb.ToString();
        }
            public Tweet(string naam, string bericht)
        {
            Naam = naam;
            Bericht = bericht;
        }
        
    }
}
