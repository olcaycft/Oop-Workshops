using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlDb = new SqlServer();
            sqlDb.Add();
            sqlDb.Delete();
        }

        abstract class DataBase
        {
            public void Add() //tamamlanmış metod
            {
                Console.WriteLine("Added by Default");
            }

            public abstract void Delete();//tamamlanmamış metod
        }

        class SqlServer : DataBase
        {
            public override void Delete()
            {
                Console.WriteLine("Deleted by Sql");
            }
        }
    }
}
