using System;

namespace task_DEV_7
{
    /// <summary>
    /// Engine of a car
    /// </summary>
    public class Engine
    {
        public string Type { get; set; }
        public Engine(string typeOfEngine)
        {
            Type = typeOfEngine;
        }
    }
}
