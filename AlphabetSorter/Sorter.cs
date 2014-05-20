using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetSorter
{
    /// <summary>
    /// Class for sorting file contents alphabetically which is outputted to a second
    /// file with "Sorted" appended to the name.
    /// </summary>
    public class Sorter
    {
        /// <summary>
        /// Sorts the contents of a file alphaebtically into a second file with the same name
        /// as the file the path param points to, with "Sorted" appended to the file name
        /// </summary>
        /// <param name="path">path to the file to sort.</param>
        public void SortFileContentsAlphabetically(string path)
        {
            var content = File.ReadAllLines(path).ToList();
            var sortedContent = content.OrderBy(element => element);
            var sortedFileLocation = GetAbsolutePathToSortedFile(path);
            WriteStringsToFile(sortedContent, sortedFileLocation);
        }

        /// <summary>
        /// Write the elements of a collection of strings to a file, the absolute path to which
        /// is specified as the second parameter.
        /// </summary>
        /// <param name="content">Collection of strings, each item a line to write as content to the new file</param>
        /// <param name="filepath">Absolute path to the file to write to</param>
        private void WriteStringsToFile(IEnumerable<string> content, string filepath)
        {
            File.WriteAllLines(filepath, content);
        }

        /// <summary>
        /// Creates the absolute path to the file to contain the sorted content from the
        /// path to the file to sort.
        /// </summary>
        /// <param name="path">path to the file to sort</param>
        /// <returns>string path to file to receive sorted content</returns>
        private string GetAbsolutePathToSortedFile(string path)
        {
            var fileName = Path.GetFileNameWithoutExtension(path);
            var location = Path.GetFullPath(path).Substring(0, path.LastIndexOf('\\'));
            return location + "\\" + fileName + "Sorted.txt"; 
        }
        
    }
}
