using System;

namespace TaskDev1
{
    class EntryPoint
    {
        /// <summary>
        /// It is an entey point in the prigram.
        /// </summary>
        static void Main(string[] symbolsString)
        {
            if (symbolsString.Length == 1)
            {
                EqualSymbolsCounter counter = new EqualSymbolsCounter(symbolsString[0]);
                Console.WriteLine(counter.FindSimilarSimbolsSequanceLength());
            }
            else
            {
                Console.WriteLine("Wrong number of arguments.");
            }
        }
    }
}
