using System;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace task_DEV_7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            CarCreator creator = new LamborghiniCreator("Car Lamborghini");
            Car lamborghini = creator.Create();

            creator = new FerrariCreator("Car Ferrari");
            Car ferrari = creator.Create();

            creator = new TeslaCreator("Car Tesla");
            Car tesla = creator.Create();

            JavaScriptSerializer ser = new JavaScriptSerializer();
            string car1 = ser.Serialize(lamborghini);
            File.WriteAllText("Car catalog", car1);
        }
    }
}
