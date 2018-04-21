using System;

namespace Classwork1_06._04._2018_
{
    /// <summary>
    /// Class Car
    /// </summary>
    public class Car
    {
        public string Model { get; set; }
        public string Company { get; set; }
        public Car(string _Model, string _Company)
        {
            Model = _Model;
            Company = _Company;
        }
    }
}
