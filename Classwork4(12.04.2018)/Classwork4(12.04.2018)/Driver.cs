using System;

namespace Classwork4_12._04._2018_
{
    /// <summary>
    /// Struct driver
    /// </summary>
    public struct Driver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public int Age { get; set; }
        public Driver (string _FirtsName, string _LastName, int _Number, int _Age)
        {
            FirstName = _FirtsName;
            LastName = _LastName;
            Number = _Number;
            Age = _Age;
        }
    }
}
