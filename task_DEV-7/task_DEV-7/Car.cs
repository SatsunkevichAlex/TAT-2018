using System;
using System.Collections.Generic;

namespace task_DEV_7
{
    /// <summary>
    /// The object we want to create
    /// </summary>
    public class Car
    {
        public virtual string Mark { get; set; }
        public virtual string Model { get; set; }
        public virtual string Power { get; set; }
        public virtual string Capacity { get; set; }
        public virtual string Engine { get; set; }
        public virtual string BodyType { get; set; }
        public virtual string Transmission { get; set; }
        public virtual string Interior { get; set; }
        public virtual string ClimateControl { get; set; }
    }
}
