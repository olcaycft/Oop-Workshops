
using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo2();
            ICostumerDal[] customerDals = new ICostumerDal[2] { 
                new xCostumerDal(),
                new yCostumerDal()
            };

            foreach (var customerdall in customerDals)
            {
                customerdall.Add();
                customerdall.Delete();
            }
            
        }

        private static void Demo2()
        {
            CustomerManeger customermanager = new CustomerManeger();
            customermanager.Add(new yCostumerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer Olcay = new Customer { Id = 1, FirstName = "Olcay", LastName = "ÇİFTÇİ", Adress = "2712 Sok." };

            Student Alican = new Student { Id = 1, FirstName = "Alican", LastName = "ÇİFTÇİ", Department = "EEE" };

            manager.Add2(Alican);

            manager.Add(Olcay);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
       public int Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string Adress { get; set; }
    }
    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName +" "+customer.LastName);
        }
        public void Add2(IPerson person)
        {
            Console.WriteLine(person.FirstName+" "+person.LastName);
        }
    }
}
