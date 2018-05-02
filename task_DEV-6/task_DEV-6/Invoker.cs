using System.Collections.Generic;

namespace task_DEV_6
{
    /// <summary>
    /// Command invoker.
    /// </summary>
    class Invoker
    {
        ICommand command;
        /// <summary>
        /// Set command.
        /// </summary>
        /// <param name="c"></param>
        public void SetCommand(ICommand c)
        {
            command = c;
        }
        /// <summary>
        /// Run Execute.
        /// </summary>
        /// <param name="products"></param>
        public void Run(List<Product> products)
        {
            command.Execute(products);
        }
    }
}
