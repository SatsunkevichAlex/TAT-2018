using System;

namespace task_DEV_7
{
    /// <summary>
    /// Tesla creator
    /// </summary>
    class TeslaCreator : CarCreator
    {
        public TeslaCreator(string n) : base(n)
        { }
        /// <summary>
        /// Realisation factory method 
        /// </summary>
        /// <returns>Car Tesla</returns>
        public override Car Create()
        {
            return new Tesla("Tesla");
        }
    }
}
