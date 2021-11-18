using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqsl mySql = new MySqsl();
            mySql.Add();

        }
        class Database
        {
            public virtual void Add() { Console.WriteLine("Added by default"); }
            public virtual void Delete() { Console.WriteLine("Deleted by default"); }
        }
        class SqlServer : Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by Sql Server");
                //base.Add();
            }
        }
        class MySqsl : Database
        { 
            
        }
    }
}
