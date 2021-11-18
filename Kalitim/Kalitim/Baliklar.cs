using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Baliklar: Hayvanlar
    {
        public override void Keko()
        {
            Console.WriteLine("Balıklar keko değildir.");
        }
        public void Yuzmek()
        {
            Console.WriteLine("Balıklar Yüzer.");
        }
    }
}
