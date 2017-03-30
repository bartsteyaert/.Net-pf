using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taak
{
    interface IKost
    {
        decimal Maandkost { get; }
        void GegevensTonen();
    }
}
