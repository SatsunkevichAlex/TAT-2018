using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork4_12._04._2018_
{
    /// <summary>
    /// Struct vehicle
    /// </summary>
    public struct Vehicle
    {
        public Car car;
        public Driver driver;
        public Vehicle(Car _car, Driver _driver)
        {
            car = _car;
            driver = _driver;
        }

    }
}
