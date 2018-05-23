using System;

namespace task_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                PersonsList personList = new PersonsList();
                personList.AddPerson();
                personList.OutputPersons();
                Console.WriteLine("Minimal age: " + personList.MinAge() + " Maximal age: " + personList.MaxAge() + " Average age: " + personList.AverageAge());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
