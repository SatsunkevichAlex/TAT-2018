using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classwork6_19._04._18_
{
    /// <summary>
    /// Class which calculate distance between two vectors
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// Calculate distance between two vectors
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns>Distance between vectors</returns>
        public double GetDistanceEuclidean(List<double> v1, List<double> v2)
        {
            double distance = 0;
            for (int i = 0; i < v1.Count; i++)
            {
                distance += Math.Pow((v1[i] - v2[i]), 2);
            }
            return Math.Sqrt(distance);
        }
    }
}
