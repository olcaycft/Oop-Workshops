using System;

namespace InterfacesDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] { 
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var item in workers)
            {
                item.Work();
            }

            IEat[] eaters = new IEat[] { new Manager(), new Worker(),};
            foreach (var itemss in eaters)
            {
                itemss.Eat();
            }
        }
    }



    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager Eat");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Manager");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker Eat");
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Worker");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot");
        }
    }
}
