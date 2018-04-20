using System;
using System.Collections.Generic;

namespace Classwork2_09._04._2018_
{
    class Program
    {
        /// <summary>
        /// Method for sorting by model
        /// </summary>
        /// <param name="Car1"></param>
        /// <param name="Car2"></param>
        /// <returns>Result of comparing</returns>
        static int MySortMethodByModel(Car x, Car y)
        {
            return x.Model.CompareTo(y.Model);
        }
        /// <summary>
        /// Method for sorting by company
        /// </summary>
        /// <param name="Car1"></param>
        /// <param name="Car2"></param>
        /// <returns>Result of comparing</returns>
        static int MySortMethodByCompany(Car x, Car y)
        {
            return x.Company.CompareTo(y.Company);
        }
        /// <summary>
        /// Method for sorting by copacity
        /// </summary>
        /// <param name="Car1"></param>
        /// <param name="Car2"></param>
        /// <returns>Result of comparing</returns>
        static int MySortMethodByCapacity(Car x, Car y)
        {
            return x.Capacity.CompareTo(y.Capacity);
        }
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>{new Car("Audi", "N", 12.2f), new Car("Tt", "BB", 30),
                                       new Car("BMW", "FF", 20), new Car("P", "RE", 12),
                                       new Car("sdgh", "TT", 120), new Car("O", "PP", 110),
                                       new Car("G", "CC", 80), new Car("T", "LL", 90),
                                       new Car("Model 9", "MM", 120), new Car("R", "VV", 80)};

            Comparison<Car> SortByModel = MySortMethodByModel;
            Comparison<Car> SortByCompany = MySortMethodByCompany;
            Comparison<Car> SortByCapacity = MySortMethodByCapacity;

            cars.Sort(SortByModel);
            Console.WriteLine("Sort by Model:");
            foreach (Car b in cars)
            {
                Console.WriteLine(b.Model);
            }

            cars.Sort(SortByCompany);
            Console.WriteLine("\nSort by Company:");
            foreach (Car b in cars)
            {
                Console.WriteLine(b.Company);
            }

            cars.Sort(SortByCapacity);
            Console.WriteLine("\nSort by Capacity:");
            foreach (Car b in cars)
            {
                Console.WriteLine(b.Capacity);
            }
        }
    }
}
