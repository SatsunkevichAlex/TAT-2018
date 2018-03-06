using System;
using System.Text;

namespace task_DEV_3
{
    /// <summary>
    /// This is a class for convert integer numbers to a new scale of notation
    /// </summary>
    class ConverterNewNumberSystem
    {
        /// <summary>
        /// This method convert convert integer numbers to a new scale of notation
        /// and display it
        /// </summary>
        /// <param name="NumberToChange">Initial arguments.</param>
        /// <param name="SystemBase">Initial arguments.</param>
        public void ConverterToNewNumberSystem(int NumberToChange, int SystemBase)
        {
            StringBuilder NewNumber = new StringBuilder();
            while (NumberToChange > 0)
            {
                int remainder = NumberToChange % SystemBase;
                if (remainder >= 10)
                {
                    char letter = (char)(55 + remainder);
                    NewNumber.Insert(0, letter);
                }
                else
                {
                    NewNumber.Insert(0, remainder);
                }

                NumberToChange /= SystemBase;
            }
            Console.Write(NewNumber.ToString());
        }
    }
}
