using System;
using System.IO;

namespace task_3
{
    /// <summary>
    /// File finder.
    /// </summary>
    class FileFinder
    {
        string pathToFolder { get; set; }
        string fileExtension { get; set; }
        public FileFinder(string pathToFolder, string fileExteinsion)
        {
            if (pathToFolder != string.Empty && fileExtension != string.Empty)
            {
                this.fileExtension = fileExtension;
                this.pathToFolder = pathToFolder;
            }
            else
            {
                throw new Exception("Incorrect folder or file extension");
            }
        }
        /// <summary>
        /// Find all files in directory and subdirectories.
        /// </summary>
        /// <returns>Names of files(including their paths) in directory and subdirectories.</returns>
        public string[] AllFilesInFolder()
        {
            return Directory.GetFiles(pathToFolder, fileExtension, SearchOption.AllDirectories);
        }
    }
}
