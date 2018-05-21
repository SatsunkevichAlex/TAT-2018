using System;
using System.Collections.Generic;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            List<Person> persons = person.AddPerson(person);
            person.OutputPersons(persons);
            Console.WriteLine("Minimal age: " + person.MinAge(persons) + " Maximal age: " + person.MaxAge(persons) + " Average age: " + person.AverageAge(persons));
        }
    }
}
