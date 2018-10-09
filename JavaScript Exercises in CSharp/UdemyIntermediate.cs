using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScript_Exercises_in_CSharp
{
    class UdemyIntermediate
    {
        class Program
        {

            public class Person
            {
                public string Name;

                public void Introduce(string to)
                {
                    Console.WriteLine("Hi {0}, I am {1}", to, Name);

                    Console.ReadKey();

                }

                public static Person Parse(string str)
                {
                    var person = new Person();
                    person.Name = str;

                    return person;

                }
            }

            public class Customer
            {
                public int Id;
                public string Name;
            }



          
            static void Main(string[] args)
            {
                //var person = new Person(); can remove this Person object wen we add static to Parse method above!
                var person = Person.Parse("John");
               
                person.Introduce("Mosh");


                var customer = new Customer();
                customer.Id = 1;
                customer.Name = "Cliff";

                var order = new Order();
               
                customer.Orders.Add(order); //


                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);

                Console.ReadKey();

            }
        }



        
    }
}
