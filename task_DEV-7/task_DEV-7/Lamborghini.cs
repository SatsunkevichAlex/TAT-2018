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
        public override int Power { get; set; } = 700;
        public override double Capacity { get; set; } = 6.5;
        Engine engine = new Engine("Petrol");
        BodyType bodyType = new BodyType("Sedan");
        Transmission transmission = new Transmission("Automatic");
        Interior interior = new Interior("Combined");
        ClimateControl climateControl = new ClimateControl("Absent");
        public Lamborghini(string mark)
        {
            Mark = mark;
        }
    }
}
