using System;

namespace task_2
{
    /// <summary>
    /// Square calculator.
    /// </summary>
    public class SquareCalculator
    {
        /// <summary>
        /// Calculate square (S = a*b).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Square.</returns>
        public double GetSquare(double a, double b)
        {
            if (a < 0 || b < 0)
            {
                throw new Exception("Invalid input!");
            }
            return a * b;
        }
    }
}
