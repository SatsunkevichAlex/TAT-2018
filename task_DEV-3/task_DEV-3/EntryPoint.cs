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
            int InputNumber;
            int BaseOfNewSystem;
            bool CheckNumber = Int32.TryParse(args[0], out InputNumber);
            bool CheckFormatBase = Int32.TryParse(args[1], out BaseOfNewSystem);
            bool CheckIntervalBase = BaseOfNewSystem >= 2 && BaseOfNewSystem <= 20;
            if (CheckNumber && CheckFormatBase && CheckIntervalBase)
            {
                ConverterNewNumberSystem converter = new ConverterNewNumberSystem();
                converter.ConverterToNewNumberSystem(InputNumber, BaseOfNewSystem);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
