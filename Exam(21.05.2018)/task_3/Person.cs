using System;
using System.Collections.Generic;
using System.Linq;

namespace task_3
{
    /// <summary>
    /// Person.
    /// </summary>
    class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public Person()
        {
            this.FirstName = Console.ReadLine();
            this.SecondName = Console.ReadLine();
            try
            {
                this.Age = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                throw new Exception("Invalid age input!");
            }
        }
        /// <summary>
        /// Add perons to list.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="persons"></param>
        /// <returns>List of persons.</returns>
        public List<Person> AddPerson(Person person)
        {
            List<Person> persons = new List<Person>();
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                persons.Add(new Person());
            }
            return persons;
        }
        /// <summary>
        /// Output Persons.
        /// </summary>
        /// <param name="persons"></param>
        public void OutputPersons(List<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.SecondName + " " + person.FirstName + " " + person.Age);
            }
        }
        /// <summary>
        /// Find minimal age in persons list.
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Minimal age.</returns>
        public int MinAge(List<Person> persons)
        {
            int minAge = persons.Min(p => p.Age);
            return minAge;
        }
        /// <summary>
        /// Find maximal age in persons list.
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Maximal age.</returns>
        public int MaxAge(List<Person> persons)
        {
            return persons.Max(p => p.Age);
        }
        /// <summary>
        /// Calculate average age in persons list within hundredths.
        /// </summary>
        /// <param name="persons"></param>
        /// <returns>Average age in persons list within hundredths.</returns>
        public double AverageAge(List<Person> persons)
        {
            return Math.Round(persons.Average(p => p.Age), 2);
        }
    }
}
