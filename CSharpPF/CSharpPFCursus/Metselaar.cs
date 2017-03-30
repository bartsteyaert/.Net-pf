using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firma.Personeel;

namespace CSharpPFCursus
{
    public class Metselaar : Firma.Personeel.Arbeider
    {
        public Metselaar(string naam, DateTime inDienst, Geslacht geslacht, decimal uurloon, byte ploegenstelsel) 
            : base(naam, inDienst, geslacht, uurloon, ploegenstelsel)
        {
        }
        public Metselaar()
            :this("jos", DateTime.Today, Geslacht.Man, 3m, 1)
        {

        }
        
    }
}
