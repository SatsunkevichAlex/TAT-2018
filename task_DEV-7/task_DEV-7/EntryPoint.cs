using System;
using System.Web.Script.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace task_DEV_7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();

            FilterParameters filterParameters = new FilterParameters();
            GetFilterParameters getFilterParameteres = new GetFilterParameters(filterParameters);
            invoker.SetCommand(getFilterParameteres);
            invoker.Run();

            CarsCatalog carsCatalog = new CarsCatalog();
            CreateCarsCatalog createCarsCatalog = new CreateCarsCatalog(carsCatalog);
            invoker.SetCommand(createCarsCatalog);
            invoker.Run();

            JavaScriptSerializer ser = new JavaScriptSerializer();
            string catalog = ser.Serialize(carsCatalog.Catalog());
            File.WriteAllText("Cars catalog.json", catalog);
        }
    }
}
