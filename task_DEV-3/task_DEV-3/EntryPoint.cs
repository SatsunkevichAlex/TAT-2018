using System;

namespace task_DEV_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (Convert.ToInt16(args[1]) < 2 && Convert.ToInt16(args[1]) > 20)
                {
                    Console.WriteLine("Invalid input!");
                }
                int InputNumber;
                int BaseOfNewSystem;
                InputNumber = Int32.Parse(args[0]);
                BaseOfNewSystem = Int32.Parse(args[1]);
                Converter Converter = new Converter();
                Console.WriteLine(Converter.ToNewNumberSystem(InputNumber, BaseOfNewSystem));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
        }
    }
}
