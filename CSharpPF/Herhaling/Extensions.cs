using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhaling
{
    public static class Extensions
    {
        public static int MyStringExtension(this string naam)
        {
            return naam.Length;
        }
    }
}
