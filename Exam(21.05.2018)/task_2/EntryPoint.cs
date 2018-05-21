using System;

namespace task_2
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2 || args.Length > 2)
                {
                    throw new Exception("Wrong number of arguments!");
                }
                SquareCalculator squareCalculator = new SquareCalculator();
                double a = double.Parse(args[0]);
                double b = double.Parse(args[1]);
                Console.WriteLine(squareCalculator.GetSquare(a, b));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
