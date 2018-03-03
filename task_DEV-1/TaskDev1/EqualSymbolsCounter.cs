using System;

namespace TaskDev1
{
    /// <summary>
    /// This class works with string and
    /// count max lenght of equal symbols.
    /// </summary>
    class EqualSymbolsCounter
    {
        public EqualSymbolsCounter (string ourString)
        {
            currentString = ourString;
        }
        private string currentString;
        /// <summary>
        /// This method finds max lenght of idential symbols.
        /// </summary>
        /// <returns>Returns the maximom number of dublicate succsessive symbols.</returns>
        public int FindSimilarSimbolsSequanceLength()
        {
            int maxSameStringLenght = 1;
            int currentSequenceLength = 1;
            for (int i = 0; i < currentString.Length - 1; i++)
            {
                if (currentString[i] == currentString[i + 1])
                {
                    currentSequenceLength++;
                }
                else
                {
                    currentSequenceLength = 1;
                }
                if (maxSameStringLenght < currentSequenceLength)
                {
                    maxSameStringLenght = currentSequenceLength;
                }
            }
            return maxSameStringLenght;
        }
    }
}
