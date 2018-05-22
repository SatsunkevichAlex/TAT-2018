using System;
using System.Text;

namespace task_DEV_2
{
    /// <summary>
    /// This class for work with sequance
    /// </summary>
    public class StringCreater
    {
        public string CurrentString { get; set; }

        /// <summary>
        /// Get sequence
        /// </summary>
        /// <returns>sequence</returns>
        public StringBuilder GetSequence()
        {
            CurrentString = Console.ReadLine();
            StringBuilder sequence = new StringBuilder(CurrentString);
            return sequence;
        }

        /// <summary>
        /// Create even numbered sequence
        /// </summary>
        /// <param name="sequance"></param>
        /// <returns>even numbered sequence</returns>
        public string EvenNumberSequance(StringBuilder sequance)
        {
            string newSequence = sequance.ToString();
            string evenNumberedSequence = null;
            for (int i = 1; i < newSequence.Length; i = i + 2)
            {
                evenNumberedSequence += newSequence[i];
            }
            return evenNumberedSequence;
        }
    }
}