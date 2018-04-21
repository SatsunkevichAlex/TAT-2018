using System;
using System.Collections.Generic;

namespace Classwork6_19._04._18_
{
    /// <summary>
    /// Coordinates of the point
    /// </summary>
    /// 
    public class Coordinates
    {
        public delegate double GetDistanceDelegate(List<double> vector1, List<double> vector2);

        public List<double> vector1 = new List<double>();
        public List<double> vector2 = new List<double>();

        public GetDistanceDelegate del;

        public Coordinates(List<double> v1, List<double> v2)
        {
            if (v1.Count != v2.Count)
            {
                throw new Exception("The vectors must be the same length");
            }
            else
            {
                vector1 = v1;
                vector2 = v2;
            }
        }
        /// <summary>
        /// Get distance method
        /// </summary>
        /// <returns></returns>
        public double GetDistance()
        {
            return del(vector1, vector2);
        }
    }
}
