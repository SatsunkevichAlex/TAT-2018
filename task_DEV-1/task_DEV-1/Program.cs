using System;

namespace task_DEV_1
{
    class MaximumNuber                                       // Class which find maximum number of identical consecutive characters in a string
    {
        static void Main(string[] character_sequence)
        {
            int count = 0;
            for (int i = 0; i < character_sequence.Length; i++)
            {
                int cur_count = 1;
                for (int j = i + 1; j < character_sequence.Length; j++)
                {
                    if (character_sequence[i] != character_sequence[j])
                    {
                        break;
                    }
                    cur_count++;
                    if (cur_count > count)
                    {
                        count = cur_count;
                    }
                }
            }
            Console.WriteLine($"The maximum number of identical consecutive characters in a string = {count}");
            Console.ReadKey();
        }
    }
}
