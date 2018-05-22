using System;

namespace task_DEV_7
{
    public class Invoker
    {
        ICommand command;
        public void SetCommand(ICommand c)
        {
            command = c;
        }
        /// <summary>
        /// Method which execute command
        /// </summary>
        public void Run()
        {
            command.Execute();
        }
    }
}
