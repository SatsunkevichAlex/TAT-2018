using System;

namespace task_DEV_7
{
    /// <summary>
    /// The object you want to create
    /// </summary>
    public class Car
    {
        public virtual string Mark { get; set; }

        public virtual string Model { get; set; }

        public virtual int Power { get; set; }

        public virtual double Capacity { get; set; }

        Engine engine;

        BodyType bodyType;

        Transmission transmission;

        Interior interior;

        ClimateControl climateControl;
    }
}
