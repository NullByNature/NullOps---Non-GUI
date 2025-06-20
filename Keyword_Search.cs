using System;
using System.IO;

namespace Null_Ops
{
    internal class Keyword_Search
    {
        List<string> keyword_files = new List<string>();
        public void Desktop_Search()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Console.WriteLine("Enter the keyword you are searching for and each file that contains the word will be listed");
            string keyword = Console.ReadLine();
            // null check
            while (string.IsNullOrEmpty(keyword))
            {
                Console.WriteLine("Keyword can not be empty");
                keyword = Console.ReadLine();
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            string[] allfiles = Directory.GetFiles(path);
            foreach (string file in allfiles)
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string content = reader.ReadToEnd();
                    if (content.Contains(keyword))
                    {
                        keyword_files.Add(file);
                    }
                }
                
            }
            // List all files found if any were found
           
            if (keyword_files.Count == 0)
            {
                Console.WriteLine("There were no files found with that word in them");
            }
            else
            {
                Console.WriteLine("Heres a list of all files found with your keyword");
                foreach (string file in keyword_files)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}
