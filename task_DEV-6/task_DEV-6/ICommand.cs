using System;
using System.Collections.Generic;

namespace task_DEV_6
{
    /// <summary>
    /// ICommand.
    /// </summary>
    interface ICommand
    {
        /// <summary>
        /// Execute.
        /// </summary>
        /// <param name="products"></param>
        /// <returns>Result of Execute.</returns>
        void Execute(List<Product> products);
    }
}
