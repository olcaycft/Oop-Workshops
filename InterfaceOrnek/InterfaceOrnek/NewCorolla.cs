using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    class NewCorolla : Otomobil
    {
        public override Sabitler.Marka Marka()
        {
            return Sabitler.Marka.Toyota;
        }

        public override Sabitler.Renk Renk()
        {
            return Sabitler.Renk.Gri;
        }
    }
}
