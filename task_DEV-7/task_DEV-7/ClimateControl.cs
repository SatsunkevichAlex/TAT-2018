using System;

namespace task_DEV_7
{
    /// <summary>
    /// Climate control of a car
    /// </summary>
    class ClimateControl
    {
        private string typeClimateControl;
        public string TypeClimateControl { get; set; }

        public ClimateControl (string climateControlType)
        {
            typeClimateControl = climateControlType;
        }
    }
}
