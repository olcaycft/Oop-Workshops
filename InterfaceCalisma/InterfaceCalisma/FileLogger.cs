using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCalisma
{
    class FileLogger:ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("File loglandı");
        }
    }
}
