using System;

namespace task_DEV_7
{
    /// <summary>
    /// Realisation of a class Lamborghini
    /// </summary>
    public class Lamborghini : Car
    {
        public override string Mark { get; set; } = "Lamborghini";
        public override string Model { get; set; } = "Aventador";
        public override string Power { get; set; } = "700";
        public override string Capacity { get; set; } = "6.5";
        public override string BodyType { get; set; } = "Sedan";
        public override string Engine { get; set; } = "Petrol";
        public override string Interior { get; set; } = "Combined";
        public override string Transmission { get; set; } = "Automatic";
        public override string ClimateControl { get; set; } = "Absent";
        public Lamborghini(string mark)
        {
            Mark = mark;
        }
    }
}
