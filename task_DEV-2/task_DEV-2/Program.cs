using System;

namespace task_DEV_2
{
    /// <summary>
    /// Entry point in programm
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            StringCreater sequence = new StringCreater();
<<<<<<< HEAD:task_DEV-2/task_DEV-2/EntryPoint.cs
            Console.WriteLine(sequence.EvenNumberSequance(sequence.InputSequence()));
=======
            Console.WriteLine(sequence.EvenNumberSequance(sequence.GetSequence()));
>>>>>>> task_DEV-2:task_DEV-2/task_DEV-2/Program.cs
        }
    }
}