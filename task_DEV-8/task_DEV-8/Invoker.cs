using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_8
{
    /// <summary>
    /// Command invoker
    /// </summary>
    class Invoker
    {
        ICommand command;
        /// <summary>
        /// Set commnad 
        /// </summary>
        /// <param name="c"></param>
        public void SetCommand(ICommand c)
        {
            command = c;
        }
        /// <summary>
        /// Execute command 
        /// </summary>
        public void Run()
        {
            command.Execute();
        }
    }
}
