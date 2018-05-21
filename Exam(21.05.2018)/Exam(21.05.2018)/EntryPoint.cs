using System;

namespace Exam_21._05._2018_
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("And hi again!");
            Random rnd = new Random();
            int charsCount = rnd.Next(5, 50);
            for (int i = 0; i < charsCount; i++)
            {
                Console.Write("!");
            }
        }
    }
}
