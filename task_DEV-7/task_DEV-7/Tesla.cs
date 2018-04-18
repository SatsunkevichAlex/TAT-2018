using System;

namespace task_DEV_7
{
    class Tesla : Car
    {
        public override string Mark { get; set; } = "Tesla";
        public override string Model { get; set; } = "Model S";
        public override string Power { get; set; } = "322";
        public override string Capacity { get; set; } = "85";
        public override string BodyType { get; set; } = "Station wagon";
        public override string Engine { get; set; } = "Electric";
        public override string Interior { get; set; } = "Textile";
        public override string Transmission { get; set; } = "Automatic";
        public override string ClimateControl { get; set; } = "Climate control";
        public Tesla(string mark)
        {
            Mark = mark;
        }
    }
}
