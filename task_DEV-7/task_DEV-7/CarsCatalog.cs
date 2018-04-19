using System;
using System.Collections.Generic;

namespace task_DEV_7
{
    /// <summary>
    /// Realisation of car catalog. Also it is a receiver of command in command pattern
    /// </summary>
    public class CarsCatalog 
    {
        /// <summary>
        /// Creat a catalog of cars
        /// </summary>
        /// <returns>Cars catalog</returns>
        public List<Car> Catalog()
        {
            CarCreator creator = new LamborghiniCreator("Car Lamborghini");
            Car lamborghini = creator.Create();

            creator = new FerrariCreator("Car Ferrari");
            Car ferrari = creator.Create();

            creator = new TeslaCreator("Car Tesla");
            Car tesla = creator.Create();
            List<Car> carsCatalog = new List<Car>() { lamborghini, ferrari, tesla };

            return carsCatalog;
        }
    }
}
