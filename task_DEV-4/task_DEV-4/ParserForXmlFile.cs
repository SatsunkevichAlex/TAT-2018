using System;
using System.Text;

namespace task_DEV_4
{
    /// <summary>
    /// This class reads information from the XML file and outputs it to the console.
    /// </summary>
    class ParserForXmlFile
    {
        private string pathToFile;

        public ParserForXmlFile(string fileLication)
        {
            pathToFile = fileLication;
        }

        /// <summary>
        /// Method outputs generated information. 
        /// </summary>
        public void OutputingDataToconsole()
        {
            foreach(string nextstring in CreatingArrayOfData())
            {
                Console.WriteLine(nextstring);
            }
        }

        /// <summary>
        /// Method processes information from a file.
        /// </summary>
        /// <returns>Array of generated information.</returns>
        private string[] CreatingArrayOfData()
        {
            string[] informationFromFile = System.IO.File.ReadAllLines(pathToFile);
            string[] arrayOfData = new string[informationFromFile.Length];
            int counter = 0;
            StringBuilder way = new StringBuilder();
            StringBuilder value = new StringBuilder();
            foreach(string readString in informationFromFile)
            {
                string stringForWork = BringingTheString(readString);
                if (stringForWork.StartsWith("<?xml") || stringForWork == String.Empty)
                {
                    continue;
                }
                if (stringForWork.StartsWith("</"))
                {
                    int begin = 0;
                    int end = 0;
                    for (int i = 0; i < stringForWork.Length; i++)
                    {
                        if (stringForWork[i] == '/')
                        {
                            begin = i;
                        }
                        if (stringForWork[i] == '>')
                        {
                            end = i;
                        }
                    }
                    way.Remove(way.Length - (end - begin), (end - begin));
                    continue;
                }
                if (stringForWork.StartsWith("<") && stringForWork.Contains("="))
                {
                    int i = 1;
                    while (stringForWork[i] != ' ')
                    {
                        way.Append(stringForWork[i]);
                        i++;
                    }
                    i++;
                    way.Append('-');
                    value.Append(way);
                    while (stringForWork[i] != '>')
                    {
                        value.Append(stringForWork[i]);
                        i++;
                    }
                    arrayOfData[counter] = value.ToString();
                    value.Remove(0, value.Length);
                    counter++;
                    continue;
                }
                if (stringForWork.StartsWith("<") && stringForWork.Contains("</"))
                {
                    int i = 1;
                    while (stringForWork[i] != '>')
                    {
                        way.Append(stringForWork[i]);
                        i++;
                    }
                    way.Append('-');
                    i++;
                    value.Append(way);
                    while (stringForWork[i] != '<')
                    {
                        value.Append(stringForWork[i]);
                        i++;
                    }
                    arrayOfData[counter] = value.ToString();
                    value.Remove(0, value.Length);
                    int begin = 0;
                    int end = 0;
                    for (int j = 0; j < stringForWork.Length; j++)
                    {
                        if (stringForWork[j] == '/')
                        {
                            begin = j;
                        }
                        if (stringForWork[j] == '>')
                        {
                            end = j;
                        }
                    }
                    way.Remove(way.Length - (end - begin), (end - begin));
                    counter++;
                    continue;
                }
                if (stringForWork.StartsWith("<"))
                {
                    int i = 1;
                    while (stringForWork[i] != '>')
                    {
                        way.Append(stringForWork[i]);
                        i++;
                    }
                    way.Append('-');
                    continue;
                }
            }
            return Sorting(arrayOfData);
        }

        /// <summary>
        /// Bringing the string.
        /// </summary>
        /// <param name="stringForChange"></param>
        /// <returns>Reduced stringForChange.</returns>
        private string BringingTheString(string stringForChange)
        {
            StringBuilder stringForWork = new StringBuilder();
            stringForWork.Append(stringForChange);
            int numberOfItemsToDelete = 0;
            for (int i = 0; i < stringForWork.Length; i++)
            {
                if (stringForWork[i] == ' ')
                {
                    numberOfItemsToDelete++;
                }
                else
                {
                    break;
                }
            }
            stringForWork.Remove(0, numberOfItemsToDelete);
            return stringForWork.ToString();
        }

        /// <summary>
        /// Sort array. Ignores which string == null.
        /// </summary>
        /// <param name="arrayForSorting"></param>
        /// <returns>Sorted array.</returns>
        private string[] Sorting(string[] arrayForSorting)
        {
            int sizeSortedArray = 0;
            foreach (string nextString in arrayForSorting)
            {
                if (nextString != null)
                {
                    sizeSortedArray++;
                }
            }
            string[] sortedArray = new string[sizeSortedArray];
            for (int i = 0; i < sizeSortedArray; i++)
            {
                sortedArray[i] = arrayForSorting[i];
            }
            return sortedArray;
        }
    }
}
