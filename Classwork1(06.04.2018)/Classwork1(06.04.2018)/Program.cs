﻿using System;

<<<<<<< HEAD
namespace Classwork1_06._04._2018_
=======
namespace ConsoleApplication1
>>>>>>> 9fa8514317cd7b11b51fd2bd98a049fc8557a0a7
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Autohouse autohous = new Autohouse();

            foreach (Car b in autohous)
            {
                Console.WriteLine(b.Model);
            }
        }
    }
}
=======
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;
            c.ThresholdReached2 += u_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine();
        }
        static void u_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("User 2 added");
            Console.WriteLine("15 reached");
        }
    }

    class Counter
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total == 10)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            }
            if (total >= 15)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached2(args);
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
        protected virtual void OnThresholdReached2(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached2;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached2;
    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
>>>>>>> 9fa8514317cd7b11b51fd2bd98a049fc8557a0a7
