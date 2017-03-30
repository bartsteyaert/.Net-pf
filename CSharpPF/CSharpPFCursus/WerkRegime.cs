using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Personeel
{
    public abstract partial class Werknemer
    {
        public class WerkRegime
        {
            public enum RegimeType
            {
                Voltijds,
                Viervijfde,
                Halftijds
            }
            private RegimeType typeValue;
            public RegimeType Type
            {
                get
                {
                    return typeValue;
                }
                set
                {
                    typeValue = value;
                }
            }

            public int Vakantie
            {
                get
                {
                    switch (Type)
                    {
                        case RegimeType.Voltijds:
                            return 25;
                        case RegimeType.Viervijfde:
                            return 20;
                        case RegimeType.Halftijds:
                            return 12;
                        default:
                            return 0;
                    }
                }
            }

            public WerkRegime(RegimeType type)
            {
                Type = type;
            }
            public override string ToString()
            {
                return Type.ToString();
            }
        }
    }
}
