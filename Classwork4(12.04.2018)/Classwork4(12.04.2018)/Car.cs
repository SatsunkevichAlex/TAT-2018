using System;

namespace Classwork4_12._04._2018_
{
    /// <summary>
    /// Struct car
    /// </summary>
    public struct Car
    {
        public string Company{ get; set; }
        public string Model { get; set;}
        public Car(string _Company, string _Mark)
        {
            Company = _Company;
            Model = _Mark;
        }
    }
}
