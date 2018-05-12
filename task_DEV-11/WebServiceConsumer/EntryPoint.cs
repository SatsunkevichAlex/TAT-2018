using System;
using WebServiceConsumer.DateConverter;

namespace task_DEV_11
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            var service = new DateConverter();
            int year = 0;
            int month = 0;
            int day = 0;

            try
            {
                Console.Write("Enter year ");
                string yearText = Console.ReadLine();
                if (yearText == "")
                {
                    yearText = "0";
                }
                year = Convert.ToInt16(yearText);

                Console.Write("Enter month ");
                string monthText = Console.ReadLine();
                if (monthText == "")
                {
                    monthText = "0";
                }
                month = Convert.ToInt16(monthText);

                Console.Write("Enter day ");
                string daytText = Console.ReadLine();
                if (daytText == "")
                {
                    daytText = "0";
                }
                day = Convert.ToInt16(daytText);

                if (year < 0 || day < 0 || month < 0 || month > 12)
                {
                    throw new Exception("Incorrect date entered!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine("Days from Jesus birth : {0}", service.ConvertDateIntoDays(year, month, day));
        }
    }
}
