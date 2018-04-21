using System;

namespace HomewworkFromClasswork3_11._04._2018_
{
    /// <summary>
    /// Abstract class Car
    /// </summary>
    public class Car
    {
        public string Model { get; set; }
        public string Company { get; set; }
        public Car(string _Model, string _Company)
        {
            Company = _Company;
            Model = _Model;
        }
    }
}
