using System;

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
        /// <param name="NumberToChange"></param>
        /// <param name="SystemBase"></param>
        public void ConverterToNewNumberSystem(int NumberToChange, int SystemBase)
        {
            string ReversedNewNumber = "";
            int NumberOfNewNumeral;
            while (NumberToChange != 0)
            {
                NumberOfNewNumeral = NumberToChange % SystemBase;
                NumberToChange /= SystemBase;
                ReversedNewNumber += Convert.ToString(NumberOfNewNumeral);
            }
            for (int i = ReversedNewNumber.Length - 1; i >= 0; i--)
            {
                Console.Write($"{ReversedNewNumber[i]}");
            }
            
        }
    }
}
