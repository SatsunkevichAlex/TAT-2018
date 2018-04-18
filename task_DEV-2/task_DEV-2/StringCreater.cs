using System;
using System.Text;

namespace task_DEV_2
{
    /// <summary>
    /// This class for work with sequances
    /// </summary>
    public class StringCreater
    {
        /// <summary>
        /// Input sequance
        /// </summary>
        /// <returns>sequance</returns>
        public string InputSequence()
        {
            string sequence = Console.ReadLine();
            return sequence;
        }
        /// <summary>
        /// This method creates a string of even-number characters of sequance
        /// </summary>
        /// <param name="sequance"></param>
        /// <returns>String of even-number characters</returns>
        public string EvenNumberSequance (string sequance)
        {
            StringBuilder CharacterSequence = new StringBuilder(sequance);
            for (int i = 1; i < CharacterSequence.Length; i = i + 2)
            {
                currentString += CharacterSequence[i];
            }
            return currentString;
        }
        private string currentString;
    }
}
