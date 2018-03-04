namespace task_DEV_2
{
    /// <summary>
    /// Entry point in programm
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            EvenCharacters sequence = new EvenCharacters();
            sequence.EnterSequance();
            sequence.WriteEvenCharachters();
        }
    }
}
