using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_Dictionar_Traduceri
{
    internal interface ICautare
    {
        List<CarteTipDictionar> CautareDePeSite(string site);
    }
}
