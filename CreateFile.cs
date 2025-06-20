using System;
using System.IO;

namespace Null_Ops
{
    internal class CreateFile
    {
        public void Desktop_file()
        {
            string file_path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Console.WriteLine("Enter the name of the file you wish to create, if you enter nothing the file will be named NullOps_blank");
            string file_name = Console.ReadLine();
            if (string.IsNullOrEmpty(file_name))
            {
                file_name = "NullOps_blank.txt";
            }
            string combined = Path.Combine(file_path, file_name + ".txt");
            // Check if file already exist 
            if (File.Exists(combined))
            {
                Console.WriteLine("File already exist!!");
            }
            else
            {
                File.Create(combined).Close();
            }
        }
    }
}
