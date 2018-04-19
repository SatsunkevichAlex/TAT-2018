using System;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();

            User user1 = new User();
            InformationInput informationinputUser1 = new InformationInput(user1);
            invoker.SetCommand(informationinputUser1);
            invoker.Run();

            User user2 = new User();
            InformationInput informationinputUser2 = new InformationInput(user2);
            invoker.SetCommand(informationinputUser2);
            invoker.Run();

            User user3 = new User();
            InformationInput informationinputUser3 = new InformationInput(user3);
            invoker.SetCommand(informationinputUser3);
            invoker.Run();
            User use4 = new User();

            List<User> users = new List<User>() { user1, user2, user3 };

            // Average user's age
            double averageAge = users.Average(user => user.Age);
            Console.WriteLine("\nAverage age of a user: " + averageAge);

            // Oldest user
            var oldestUser = users.OrderBy(u => u.Age).Last();
            Console.WriteLine("Oldest user is: " + oldestUser.FirstName + " " + oldestUser.LastName);

            // Most popular feamle name 
            if (users.Any(u => u.Sex == "Female"))
            {
                var mostPopularFemaleName = users.Where(u => u.Sex == "Female")
                                                 .GroupBy(u => u.FirstName)
                                                 .OrderByDescending(grp => grp.Count())
                                                 .Select(grp => grp.Key)
                                                 .First();
                Console.WriteLine("Most popular female name: " + mostPopularFemaleName);
            }
            else
            {
                Console.WriteLine("There is no female user");
            }

            SameLastNameFinded += c_SameLastNameFinded; // Here is an error;
        }
       
        static void c_SameLastNameFinded(User user, FindSameLastNameEventArgs e)
        {
            Console.WriteLine(user.LastName);
        }
       
        public void FindSameLastNames(List<User> users)
        {
            foreach (User user in users)
            {
                if (users.Any(u => u.LastName == user.LastName))
                {
                    FindSameLastNameEventArgs args = new FindSameLastNameEventArgs();
                    OnSameLastNameFinded(args);
                }
            }
        }
        protected virtual void OnSameLastNameFinded(FindSameLastNameEventArgs e)
        {
            EventHandler<FindSameLastNameEventArgs> handler = SameLastNameFinded;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        public event EventHandler<FindSameLastNameEventArgs> SameLastNameFinded;
    }
    public class FindSameLastNameEventArgs : EventArgs
    {
    }
}
