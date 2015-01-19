using System;
using System.Collections.Generic;
using System.Linq;

namespace CS6Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            var caseyPerson = new Person { Age = 34, FirstName = "Casey", LastName = "Watson" };
            var emilyPerson = new Person { Age = 32, FirstName = "Emily", LastName = "Watson" };
            var katiePerson = new Person { Age = 11, FirstName = "Katie", LastName = "Watson" };

            people.Add(caseyPerson);
            people.Add(emilyPerson);
            people.Add(katiePerson);

            foreach (var person in people)
                PrintPersonInformation(person);
        }

        private static void PrintPersonInformation(Person person)
        {
            if (person == null)
                throw new ArgumentNullException("person");

            Console.WriteLine("{0} {1} is {2} years old.", person.FirstName, person.LastName, person.Age);

            if (person.EmailAddresses.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine("You can e-mail {0} at...", person.FirstName);
                Console.WriteLine();

                foreach (var emailAddress in person.EmailAddresses)
                    Console.WriteLine(emailAddress);
            }

            Console.ReadKey();
        }
    }
}
