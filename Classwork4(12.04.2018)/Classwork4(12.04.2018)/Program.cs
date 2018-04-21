using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork4_12._04._2018_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Vehicle(new Car("BMW", "Model1"),      new Driver("a", "lastname", 123456, 26)));
            vehicles.Add(new Vehicle(new Car("Company2", "Model2"), new Driver("as", "lastnam", 987654, 20)));
            vehicles.Add(new Vehicle(new Car("Company3", "Model3"), new Driver("saf", "lastna", 45654, 20)));
            vehicles.Add(new Vehicle(new Car("Company4", "Model4"), new Driver("asdg", "lastn", 135, 20)));
            vehicles.Add(new Vehicle(new Car("BMW", "Model5"),      new Driver("asdfg", "las", 2, 22)));
            vehicles.Add(new Vehicle(new Car("Company6", "Model6"), new Driver("asdfdg", "la", 654564, 2)));
            vehicles.Add(new Vehicle(new Car("Company7", "Model7"), new Driver("asdfasd", "lastnameasdfasdf", 1, 20)));
            vehicles.Add(new Vehicle(new Car("Company8", "Model8"), new Driver("qerqwerr", "lastnameasdfad", 12, 40)));
            vehicles.Add(new Vehicle(new Car("Company9", "Model9"), new Driver("qwerqwerr", "lastnameasdfasd", 123, 20)));
            vehicles.Add(new Vehicle(new Car("Company", "Model10"), new Driver("qwerqwerqwe", "lastnameasdfads", 123, 20)));


            var selectedVehicles1 = from vehicle in vehicles
                                    where vehicle.driver.Age > 25
                                    where vehicle.car.Company == "BMW"
                                    where vehicle.driver.Number % 10 > 5
                                    select vehicle;
            Console.WriteLine("Vehicles with driver's age > 25, Company 'BMW', last number of driver's license > 5 :");
            foreach (Vehicle v in selectedVehicles1)
            {
                Console.WriteLine(v.car.Company + " " + v.car.Model + " " + v.driver.FirstName + " " + v.driver.LastName + " " + v.driver.Number + " " + v.driver.Age);
            }

            //Display cars with model 'model7', lenght of firstname > 5.
            var selectedVehicles2 = vehicles.SelectMany(vehicle => vehicle.car)
                                            .Where(vehicle => vehicle.car.Model = "Model7" && vehicle.driver.Age > 10)
                                            .Select(vehicle => vehicle);
        }
    }
}
