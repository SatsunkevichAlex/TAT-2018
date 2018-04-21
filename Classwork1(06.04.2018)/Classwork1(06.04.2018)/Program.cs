using System;

namespace Classwork1_06._04._2018_
{
    class Program
    {
        static void Main(string[] args)
        {
            Autohouse autohous = new Autohouse();

            foreach (Car b in autohous)
            {
                Console.WriteLine(b.Model);
            }
        }
    }
}
