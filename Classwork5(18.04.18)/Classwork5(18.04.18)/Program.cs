using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Start computation.
            Example();
            // Handle user input.
            string result = Console.ReadLine();
            Console.WriteLine("You typed: " + result);
        }
    }

    static async void Example()
    {
        // This method runs asynchronously.
        Console.WriteLine("Inter integer number for exponentiation");
        double number1 = Convert.ToDouble(Console.ReadLine());
        double number2 = Convert.ToDouble(Console.ReadLine());
        double t = await Task.Run(() => Exponentiation(number1, number2));
        Console.WriteLine("Compute: " + t);
        Task.Delay(2000);
    }

    //Raising to the power of one number to the power of another
    static double Exponentiation(double number1, double number2)
    {
        //Console.WriteLine("Inter integer number for exponentiation");
        //double number1 = Convert.ToDouble(Console.ReadLine());
        //double number2 = Convert.ToDouble(Console.ReadLine()); 
        return Math.Pow(number1, number2);
    }
}

///Домашнее задание. Написать качатель файлов. на вход список ссылок URLs