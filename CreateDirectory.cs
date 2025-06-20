using System;
using System.IO;

namespace Null_Ops
{
    internal class CreateDirectory
    {
        public void Create_DirectoryC()
        {
            string c_drive = "";
            Console.WriteLine("Enter the name of the folder that you want to create");
            string folder_name = Console.ReadLine();
            // null check
            while(string.IsNullOrEmpty(folder_name))
            {
                Console.WriteLine("Folder name can not be empty");
                folder_name = Console.ReadLine();
            }
            c_drive = @$"c:\{folder_name}";
            if (Directory.Exists(c_drive))
            {
                Console.WriteLine("Folder already exist");
            }
            else
            {
                Directory.CreateDirectory(c_drive);
                Console.WriteLine("Directory created");
            }
        }

        public void Create_DirectoryD()
        {
            string d_drive = "";
            Console.WriteLine("Enter the name of the folder that you want to create");
            string folder_name = Console.ReadLine();
            // null check
            while (string.IsNullOrEmpty(folder_name))
            {
                Console.WriteLine("Folder name can not be empty");
                folder_name = Console.ReadLine();
            }
            d_drive = @$"d:\{folder_name}";
            if (Directory.Exists(d_drive))
            {
                Console.WriteLine("Folder already exist");
            }
            else
            {
                Directory.CreateDirectory(d_drive);
                Console.WriteLine("Directory created");
            }
        }

        public void Create_OtherDirectory()
        {
            Console.WriteLine("What drive do you want to create a directory on ?");
            string alt_drive = Console.ReadLine();
            while (string.IsNullOrEmpty(alt_drive))
            {
                Console.WriteLine("Drive name can not be empty");
                alt_drive = Console.ReadLine();
            }
            Console.WriteLine("Enter the name of the folder that you want to create");
            string folder_name = Console.ReadLine();
            // null check
            while (string.IsNullOrEmpty(folder_name))
            {
                Console.WriteLine("Folder name can not be empty");
                folder_name = Console.ReadLine();
            }
            string other_drive = @$"{alt_drive}:\{folder_name}";
            if (Directory.Exists(other_drive))
            {
                Console.WriteLine("Folder already exist or can not detect your drive");
            }
            else
            {
                Directory.CreateDirectory(other_drive);
                Console.WriteLine("Directory created");
            }
        }
    }
}
