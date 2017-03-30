using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling
{
    public class Overuren
    {
        private int[] overurenValue = new int[12];

        public int this[int maand]
        {
            get
            {
                return overurenValue[maand];
            }
            set
            {
                overurenValue[maand] = value;
            }
        }

        
    }
}
