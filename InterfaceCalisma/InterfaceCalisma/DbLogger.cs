using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCalisma
{
    class DbLogger :ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Db Loglandı");
        }
    }
}
