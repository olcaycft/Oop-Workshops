using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[] {
                new Customer{ FirstName="Olcay", City="İzmir"}, new Person{ FirstName="Alican"},new Student{ FirstName="Nejla",Department="EEE"}
            };

            foreach (var item in persons)
            {
                Console.WriteLine(item.FirstName);
            }

        }

        class Person2
        {

        }
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer:Person
        {
            public string City { get; set; }
        }

        class Student : Person
        {
            public string Department { get; set; }
        }
    }
}
