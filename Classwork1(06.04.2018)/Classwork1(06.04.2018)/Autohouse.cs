using System;
using System.Collections;

namespace Classwork1_06._04._2018_
{
    /// <summary>
    /// Class autohouse
    /// </summary>
    public class Autohouse : IEnumerable
    {
        public Car[] cars;
        public Autohouse()
        {
            cars = new Car[]{new Car("Model 1", "Company 1"), new Car("Model 2", "Company 2"),
                             new Car("Model 3", "Company 3")};
        }
        public int Length
        {
            get { return cars.Length; }
        }
        /// <summary>
        /// Get Enumerator method
        /// </summary>
        /// <returns>Returns an enumerator that iterates through a collection</returns>
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)cars.GetEnumerator();
        }
    }
}
