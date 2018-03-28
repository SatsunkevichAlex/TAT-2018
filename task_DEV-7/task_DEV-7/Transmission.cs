using System;

namespace task_DEV_7
{
    /// <summary>
    /// Transmission of a car
    /// </summary>
    class Transmission
    {
        private string type;
        public string Type { get; set; }

        public Transmission(string transmissionType)
        {
            type = transmissionType;
        }
    }
}
