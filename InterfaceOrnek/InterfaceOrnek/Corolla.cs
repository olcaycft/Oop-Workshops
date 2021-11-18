using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    class Corolla : IOtomobil
    {
        public Sabitler.Marka Marka()
        {
            return Sabitler.Marka.Toyota;
        }

        public Sabitler.Renk Renk()
        {
            return Sabitler.Renk.Gri;
        }

        public int TekerlerSayisi()
        {
            return 4;
        }
    }
}
