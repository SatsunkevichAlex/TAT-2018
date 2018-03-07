using System;
using System.Text;

namespace task_DEV_3
{
    /// <summary>
    /// This is a class for convert integer numbers to a new scale of notation
    /// </summary>
    class Converter
    {
        /// <summary>
        /// This method convert integer numbers to a new scale of notation
        /// </summary>
        /// <param name="NumberToChange">Initial arguments.</param>
        /// <param name="SystemBase">Initial arguments.</param>
        public string ToNewNumberSystem(int NumberToChange, int SystemBase)
        {
            const int BeginOFAlphabetASCII = 55;
            StringBuilder NewNumber = new StringBuilder();
            while (NumberToChange > 0)
            {
                int remainder = NumberToChange % SystemBase;
                if (remainder >= 10)
                {
                    char letter = (char)(BeginOFAlphabetASCII + remainder);
                    NewNumber.Insert(0, letter);
                }
                else
                {
                    NewNumber.Insert(0, remainder);
                }

                NumberToChange /= SystemBase;
            }
            return NewNumber.ToString();
        }
    }
}
