using System;
using System.Collections.Generic;

namespace task_DEV_7
{
    /// <summary>
    /// Class which contains filter parameters. Also it is a receiver of command in command pattern
    /// </summary>
    public class FilterParameters
    {
        /// <summary>
        /// Creat a list of filter parameters
        /// </summary>
        /// <returns>Filter parameters</returns>
        public List<string> Parameters()
        {
            Console.WriteLine(
                "For exit type 'Exit'\n\n" +
                "Enter parameters for filter: \n" +
                "Mark, \n" +
                "Model, \n" +
                "Power, \n" +
                "Capacity, \n" +
                "Engine (Petrol/Electric/Disel), \n" +
                "Body  type (Coupe/Sedan/Station wagon/Miniven)\n" +
                "Iterior (Leather/Combined/Textile)\n" +
                "ClimateControl (Conditioner/Absent/Climate control)\n" +
                "Transmission (Manual/Automatic)");

            List<string> filterParameters = new List<string>();

            bool flag = true;
            while (flag == true)
            {
                string newParameter = Console.ReadLine();
                if (newParameter == "Exit") { break; }
                filterParameters.Add(newParameter);

            }

            foreach (string i in filterParameters)
            {
                Console.WriteLine(i);
            }
            return filterParameters;
        }
    }
}
