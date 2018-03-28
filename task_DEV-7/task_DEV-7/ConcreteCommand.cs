using System;

namespace task_DEV_7
{
    /// <summary>
    /// Concrete command
    /// </summary>
    class ConcreteCommand : ICommand 
    {
        CommandReceiver commandReceiver;
        public ConcreteCommand (CommandReceiver r)
        {
            commandReceiver = r;
        }
        public void Execute()
        {
            commandReceiver.Operation();
        }
    }
}
