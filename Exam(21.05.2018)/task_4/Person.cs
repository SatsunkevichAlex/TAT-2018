using System;

namespace task_3
{
    /// <summary>
    /// Person.
    /// </summary>
    class Person
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid age input!");
                }
            }
        }
        public Person()
        {
            this.FirstName = Console.ReadLine();
            this.SecondName = Console.ReadLine();
            try
            {
                this.Age = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                throw new Exception("Invalid age input!");
            }
        }
    }
}
