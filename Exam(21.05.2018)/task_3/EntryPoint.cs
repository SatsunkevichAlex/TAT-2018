using System;

namespace task_3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 2)
                {
                    throw new Exception("Incorrect numbers of parameters");
                }
                FileFinder searcher = new FileFinder(args[0], args[1]);
                string[] files = searcher.AllFilesInFolder();
                foreach (string nextFile in files)
                {
                    Console.WriteLine(nextFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
