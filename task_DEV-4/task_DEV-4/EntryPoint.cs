using System;

namespace task_DEV_4
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Alex\source\repos\TAT-2018\task_DEV-4\task_DEV-4\Persons.xml";
            try
            {
                ParserForXmlFile str = new ParserForXmlFile(path);
                str.OutputingDataToconsole();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
