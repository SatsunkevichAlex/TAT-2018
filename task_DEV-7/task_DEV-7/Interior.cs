using System;

namespace task_DEV_7
{
    /// <summary>
    /// Interior of a car
    /// </summary>
    class Interior
    {
        private string interiorType;
        public string InteriorType { get; set; }

        public Interior(string typeInterior)
        {
            interiorType = typeInterior;
        }
    }
}
