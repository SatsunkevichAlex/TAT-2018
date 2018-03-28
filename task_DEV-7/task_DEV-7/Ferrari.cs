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
        public override int Power { get; set; } = 460;
        public override double Capacity { get; set; } = 4.3;
        Engine engine = new Engine("Disel");
        BodyType bodyType = new BodyType("Coupe");
        Transmission transmission = new Transmission("Manual");
        Interior interior = new Interior("Leather");
        ClimateControl climateControl = new ClimateControl("Conditioner");

        public Ferrari(string mark)
        {
            Mark = mark;
        }
    }
}
