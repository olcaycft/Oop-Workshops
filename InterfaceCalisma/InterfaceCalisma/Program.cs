using System;

namespace InterfaceCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger fl = new FileLogger();
            DbLogger db = new DbLogger();

            fl.writeLog();
            db.writeLog();

            LogManager lm = new LogManager(new FileLogger());
            lm.writeLog();
            
        }
    }
}
