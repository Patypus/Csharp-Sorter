using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetSorter
{
    /// <summary>
    /// A small utility to sort the contents of a file alphabtically, with the sorted conent
    /// being written to a second file with the same name as the file being sorted appended 
    /// with "Sorted". This class is the entry point to the program.
    /// </summary>
    public class AlphabetSorter
    {
        /// <summary>
        /// Main entry to the program. Checks the contents of the supplied command line
        /// arguments to ensure that there is a single path to an file existing file
        /// </summary>
        /// <param name="args">string array supplied by the command line</param>
        public static void Main(string[] args)
        {
            if (args.Count() != 1)
            {
                PrintUsageMessage();
            }
            else
            {
                if (File.Exists(args[0]))
                {
                    SortFilesContents(args[0]);
                }
                else
                {
                    PrintUsageMessage();
                }
            }
        }

        /// <summary>
        /// Print message to command line explaining program usuage 
        /// </summary>
        private static void PrintUsageMessage()
        {
            Console.WriteLine("Please supply a single parameter: a path to a file whose contents you wish to sort alphaetically");
        }

        /// <summary>
        /// Sorts the contents of the file at the path supplied by the parameter path
        /// </summary>
        /// <param name="path">path to the file to sort</param>
        private static void SortFilesContents(string path)
        {
            var sorter = new Sorter();
            sorter.SortFileContentsAlphabetically(path);
        }
    }
}
