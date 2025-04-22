using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödeme_Sistemi_Ödevi
{
    internal interface IOdemeYontemi
    {
        string Ode(decimal tutar);
    }
}
