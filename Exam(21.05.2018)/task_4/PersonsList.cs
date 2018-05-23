using System;
using System.Linq;
using System.Collections.Generic;

namespace task_3
{
    /// <summary>
    /// List of persons.
    /// </summary>
    class PersonsList
    {
        List<Person> persons = new List<Person>();
        /// <summary>
        /// Add perons to list.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="persons"></param>
        /// <returns>List of persons.</returns>
        public List<Person> AddPerson()
        {
            //List<Person> persons = new List<Person>();
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
        public void OutputPersons()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.SecondName + " " + person.FirstName + " " + person.Age);
            }
        }
        /// <summary>
        /// Find minimal age in persons list.
        /// </summary>
        /// <returns>Minimal age.</returns>
        public int MinAge()
        {
            int minAge = persons.Min(p => p.Age);
            return minAge;
        }
        /// <summary>
        /// Find maximal age in persons list.
        /// </summary>
        /// <returns>Maximal age.</returns>
        public int MaxAge()
        {
            return persons.Max(p => p.Age);
        }
        /// <summary>
        /// Calculate average age in persons list within hundredths.
        /// </summary>
        /// <returns>Average age in persons list within hundredths.</returns>
        public double AverageAge()
        {
            return Math.Round(persons.Average(p => p.Age), 2);
        }
    }
}
