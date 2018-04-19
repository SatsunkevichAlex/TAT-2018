using System;

namespace task_DEV_7
{
    /// <summary>
    /// Realisation of a class Ferrari
    /// </summary>
    public class Ferrari : Car
    {
        public override string Mark { get; set; } = "Ferrari";
        public override string Model { get; set; } = "California";
        public override string Power { get; set; } = "460";
        public override string Capacity { get; set; } = "4.3";
        public override string BodyType { get; set; } = "Coupe";
        public override string Engine { get; set; } = "Disel";
        public override string Interior { get; set; } = "Leather";
        public override string Transmission { get; set; } = "Manual";
        public override string ClimateControl { get; set; } = "Conditioner";

        public Ferrari(string mark)
        {
            Mark = mark;
        }
    }
}
