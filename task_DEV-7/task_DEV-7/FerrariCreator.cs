using System;

namespace task_DEV_7
{
    /// <summary>
    /// Ferrari creator
    /// </summary>
    public class FerrariCreator : CarCreator
    {
        public FerrariCreator(string n) : base(n)
        { }
        /// <summary>
        /// Realisation factory method 
        /// </summary>
        /// <returns>Car Ferrari</returns>
        public override Car Create()
        {
            return new Ferrari("Ferrari");
        }
    }
}
