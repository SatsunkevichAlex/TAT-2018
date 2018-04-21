using System;
using System.Collections.Generic;

namespace HomeworkFromClasswork2_09._04._2018_
{
    /// <summary>
    /// Cars comparer
    /// </summary>
    public class CarsComparer : IComparer<Car>
    {
        /// <summary>
        /// Method which ompare Car1 with Car2
        /// </summary>
        /// <param name="Car1"></param>
        /// <param name="Car2"></param>
        /// <returns>?????????? ask a teacher!!! </returns>
        public int Compare(Car x, Car y)
        {
            if (x.Model == null)
            {
                if (y.Model == null)
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y.Model == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // lengths of the two strings.
                    //
                    int retval = x.Model.Length.CompareTo(y.Model.Length);

                    if (retval != 0)
                    {
                        // If the strings are not of equal length,
                        // the longer string is greater.
                        //
                        return retval;
                    }
                    else
                    {
                        // If the strings are of equal length,
                        // sort them with ordinary string comparison.
                        //
                        return x.Model.CompareTo(y.Model);
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>{new Car("Audi", "N", 12.2f), new Car("Tt", "BB", 30),
                                       new Car("BMW", "FF", 20), new Car("P", "RE", 12),
                                       new Car("sdgh", "TT", 120), new Car("O", "PP", 110),
                                       new Car("G", "CC", 80), new Car("T", "LL", 90),
                                       new Car("Model 9", "MM", 120), new Car("R", "VV", 80)};

            CarsComparer cc = new CarsComparer();
            Console.WriteLine("Sort with alternate comparer:");
            cars.Sort(cc);
            Display(cars);
        }
        private static void Display(List<Car> list)
        {
            foreach (Car c in list)
            {
                Console.WriteLine(c.Model);
            }
        }
    }
}
