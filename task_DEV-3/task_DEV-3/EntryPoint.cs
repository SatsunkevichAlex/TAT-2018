using System;

namespace task_DEV_3
{
    /// <summary>
    /// Entry point in programm
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int inputNumber;
            int baseOfNewSystem;
            bool CheckNumber = Int32.TryParse(args[0], out inputNumber);
            bool CheckFormatBase = Int32.TryParse(args[1], out baseOfNewSystem);
            bool CheckIntervalBase = baseOfNewSystem >= 2 && baseOfNewSystem <= 20;
            if (CheckNumber && CheckFormatBase && CheckIntervalBase)
            {
                ConverterNewNumberSystem converter = new ConverterNewNumberSystem();
                converter.ConverterToNewNumberSystem(inputNumber, baseOfNewSystem);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
