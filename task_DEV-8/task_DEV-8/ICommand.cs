using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_8
{
    /// <summary>
    /// Interface which provides command
    /// </summary>
    interface ICommand
    {
        /// <summary>
        /// Execute command
        /// </summary>
        void Execute();
    }
}
