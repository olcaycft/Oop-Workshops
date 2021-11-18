using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICostumerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class xCostumerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("x ADD");
        }

        public void Delete()
        {
            Console.WriteLine("x Deleted");
        }

        public void Update()
        {
            Console.WriteLine("x Updated");
        }
    }
    class yCostumerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("y ADD");
        }

        public void Delete()
        {
            Console.WriteLine("y Deleted");
        }

        public void Update()
        {
            Console.WriteLine("y Updated");
        }
    }

    class CustomerManeger
    {
        public void Add(ICostumerDal customerdal)
        {
            customerdal.Add();
        }
    }
}
