using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCalisma
{
    class LogManager:ILogger
    {
        private ILogger _logger;
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void writeLog()
        {
            _logger.writeLog();
        }

    }
}
