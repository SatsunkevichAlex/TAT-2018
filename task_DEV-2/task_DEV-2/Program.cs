﻿using System;

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
            Console.WriteLine(sequence.EvenNumberSequance(sequence.GetSequence()));
        }
    }
}