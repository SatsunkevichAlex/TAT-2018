using System;

namespace task_DEV_7
{
    /// <summary>
    /// Lamborghini creator
    /// </summary>
    public class LamborghiniCreator : CarCreator
    {
        public LamborghiniCreator(string n) : base(n)
        { }
        /// <summary>
        /// Realisation factory method 
        /// </summary>
        /// <returns>Car Lamborghini</returns>
        public override Car Create()
        {
            return new Lamborghini("Lamborghini");
        }
    }
}
