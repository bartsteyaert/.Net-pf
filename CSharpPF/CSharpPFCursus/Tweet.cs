using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPFCursus
{
    [Serializable]
    public class Tweet
    {
        public Tweet()
        {
            this.Tijdstip = DateTime.Now;
        }

        public string Naam { get; set; }
        public DateTime Tijdstip { get; private set; }

        private string berichtenValue;
        public string Bericht
        {
            get
            {
                return berichtenValue;
            }
            set
            {
                berichtenValue = value.Length <= 140 ? value : value.Substring(0, 140);
            }

        }
        public override string ToString()
        {
            //naam + bericht+ tijdstip
            StringBuilder tweet = new StringBuilder(this.Naam + ": " + this.Bericht + ": ");
            TimeSpan verschil = DateTime.Now - this.Tijdstip;
            if (verschil.Days > 0)
                tweet.Append(this.Tijdstip.ToShortDateString());
            else if (verschil.Hours > 0)
                tweet.Append(verschil.Hours + " uur geleden");
            else if (verschil.Minutes > 0)
                tweet.Append(verschil.Minutes +
                    (verschil.Minutes == 1 ? " minuut" : " minuten") + " geleden");
            else
                tweet.Append(this.Tijdstip.ToShortTimeString());
            return tweet.ToString();
        }
    }
}
