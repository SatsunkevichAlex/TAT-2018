using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_8
{
    /// <summary>
    /// User
    /// </summary>
    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string sex;
        public string Sex
        {
            set
            {
                try
                {
                    if (value != "Male" && value != "Female")
                    {
                        throw new Exception("Invalid sex input. Use 'Male' or 'Female'");
                    }
                    else
                    {
                        sex = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e.Message);
                }
            }
            get { return sex; }
        }
        private int age;
        public int Age
        {
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("Invalid age input. Age can not be < 0");
                    }
                    else
                    {
                        age = value;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error : " + e.Message);
                }
            }
            get { return age; }
        }
        /// <summary>
        /// Input information about user
        /// </summary>
        public void InformationInput()
        {
            Console.WriteLine("Input information about user:");

            Console.Write("First name : ");
            FirstName = Console.ReadLine();

            Console.Write("Last name : ");
            LastName = Console.ReadLine();

            Console.Write("Sex : ");
            Sex = Console.ReadLine();

            Console.Write("Age : ");
            Age = Convert.ToInt16(Console.ReadLine());
        }
    }
}