using System;
using System.Collections.Generic;

namespace Classwork6_19._04._18_
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<double> vector1 = new List<double>() { 2, 3 };
            List<double> vector2 = new List<double>() { 2, 3 };
            Coordinates coordinates = new Coordinates(vector1, vector2);
            Calculator calculator = new Calculator();
            coordinates.del = calculator.GetDistanceEuclidean;
            coordinates.GetDistance();
            Console.WriteLine("Distance between two vectors = " + coordinates.GetDistance());
        }
    }
}
