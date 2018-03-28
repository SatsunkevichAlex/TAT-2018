using System;

namespace task_DEV_7
{
    class Tesla : Car
    {
        public override string Mark { get; set; } = "Tesla";
        public override string Model { get; set; } = "Model S";
        public override int Power { get; set; } = 322;
        public override double Capacity { get; set; } = 85;
        Engine engine = new Engine("Electric");
        BodyType bodyType = new BodyType("Station wagon");
        Transmission transmission = new Transmission("Automatic");
        Interior interior = new Interior("Textile");
        ClimateControl climateControl = new ClimateControl("Climate control");
        public Tesla(string mark)
        {
            Mark = mark;
        }
    }
}
