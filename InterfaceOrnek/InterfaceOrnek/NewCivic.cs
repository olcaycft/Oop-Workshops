using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    class NewCivic : Otomobil
    {
        public override Sabitler.Marka Marka()
        {
            return Sabitler.Marka.Honda;
        }
    }
}
