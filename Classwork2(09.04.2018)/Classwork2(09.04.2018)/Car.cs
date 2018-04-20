using System;

namespace Classwork2_09._04._2018_
{
    /// <summary>
    /// Class car
    /// </summary>
    public class Car
    {
        public string Model { get; set; }
        public string Company { get; set; }
        public float Capacity { get; set; }
        public Car(string _Model, string _Company, float _Capacity)
        {
            Model = _Model;
            Company = _Company;
            Capacity = _Capacity;
        }
    }
}

