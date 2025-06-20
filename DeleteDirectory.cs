using System;
using System.IO;
namespace Null_Ops
{
    internal class DeleteDirectory
    {
        public void Delete_DirectoryC()
        {
            string c_path = "";
            Console.WriteLine("Enter the name of the directory that you want to delete:");
            string dir_name = Console.ReadLine();
            // null check
            while (string.IsNullOrEmpty(dir_name))
            {
                Console.WriteLine("Name can not be blank!");
                dir_name = Console.ReadLine();
            }
            c_path = @$"c:\{dir_name}";
            // Check if directory exist
            if (!Directory.Exists(c_path))
            {
                Console.WriteLine("Directory does not exist");
            }
            else
            {
                Directory.Delete(c_path);
                Console.WriteLine("Directory deleted");
            }
        }

        public void Delete_DirectoryD()
        {
            string d_path = "";
            Console.WriteLine("Enter the name of the directory that you want to delete:");
            string dir_name = Console.ReadLine();
            // null check
            while (string.IsNullOrEmpty(dir_name))
            {
                Console.WriteLine("Name can not be blank!");
                dir_name = Console.ReadLine();
            }
            d_path = @$"d:\{dir_name}";
            if (!Directory.Exists(d_path))
            {
                Console.WriteLine("Directory does not exist");
            }
            else
            {
                Directory.Delete(d_path);
                Console.WriteLine("Directory deleted");
            }
        }

        public void Delete_Directory_Other()
        {
            string other_path = "";
            string other_drive = "";
            Console.WriteLine("Enter the name of the drive that you want to operate on:");
            // Null check
            other_drive = Console.ReadLine();
            while (string.IsNullOrEmpty(other_drive))
            {
                Console.WriteLine("Drive can not be blank");
                other_drive = Console.ReadLine();
            }
            Console.WriteLine("Enter the name of the directory that you want to delete:");
            string dir_name = Console.ReadLine();
            // Null check
            while (string.IsNullOrEmpty(dir_name))
            {
                Console.WriteLine("Name can not be blank!");
                dir_name = Console.ReadLine();
            }
            other_path = @$"{other_drive}:\{dir_name}";
            if (!Directory.Exists(other_path))
            {
                Console.WriteLine("Directory does not exist");
            }
            else
            {
                Directory.Delete(other_path);
                Console.WriteLine("Directory deleted");
            }
        }
    }
}
