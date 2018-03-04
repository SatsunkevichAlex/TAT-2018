using System;
using System.Text;

namespace task_DEV_2
{
    /// <summary>
    /// This class for work with sequances
    /// </summary>
    class StringCreater
    {
        /// <summary>
        /// Enter Sequance
        /// </summary>
        public void EnterSequance ()
        {
            currentString = Console.ReadLine();
            StringBuilder CharacterSequence = new StringBuilder(currentString);
        }
        private string currentString;
        /// <summary>
        /// This method displays even-numbered charachters
        /// </summary>
        public void WriteEvenCharacters()
        {
            for (int i = 1; i < currentString.Length; i = i + 2)
            {
                Console.Write(currentString[i]);
            }
        }
    }
}
