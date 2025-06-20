using System;
using System.IO;

namespace Null_Ops
{
    internal class DeleteFile
    {
        public void Delete_Desktop_File()
        {
            string file_path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Console.WriteLine("Enter the name of the file you wish to delete");
            string file_name = Console.ReadLine();
            // null check 
            while (string.IsNullOrEmpty(file_name))
            {
                Console.WriteLine("File name can not be empty");
                file_name = Console.ReadLine();
            }
            string path_combined = Path.Combine(file_path, file_name + ".txt");
            // Check if file exist or not 
            if (File.Exists(path_combined))
            {
                File.Delete(path_combined);
                Console.WriteLine("File deleted");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
