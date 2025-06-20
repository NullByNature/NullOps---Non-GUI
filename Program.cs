using System;
using Null_Ops;


namespace NullOps
{
    class Program
    {
        static void Main()
        {
            bool runProgram = true;
            // While bool stays true
            while (runProgram)
            {
                Console.WriteLine("Null Ops v0.1.0-beta");
                Console.WriteLine("1. Directory Operations\n" +
                    "2. File operations");
                Console.Write("Input: ");
                string answer = Console.ReadLine();
                // Null check
                while (string.IsNullOrEmpty(answer))
                {
                    Console.WriteLine("Your answer can not be empty");
                    answer = Console.ReadLine();
                }
                // switch statement
                switch(answer)
                {
                    case "1":
                        Console.WriteLine("1. Create Directory\n" +
                            "2. Delete directory\n" +
                            "3. Scan directory\n");
                        string user_choice = Console.ReadLine();
                        
                        // Null check
                        while (string.IsNullOrEmpty(user_choice))
                        {
                            Console.WriteLine("Your answer can not be empty");
                            user_choice = Console.ReadLine();
                        }
                        if (user_choice == "1")
                        {
                            CreateDirectory cd = new CreateDirectory();
                            Console.WriteLine("Where do you want to create a new directory ? (more options in future updates)\n" +
                                "1. C drive\n" +
                                "2. D drive \n" +
                                "3. Other drive");
                            Console.Write("Input:");
                            string dir_choice = Console.ReadLine();
                            //if Null 
                            while (string.IsNullOrEmpty(dir_choice))
                            {
                                Console.WriteLine("Your answer can not be blank");
                                dir_choice = Console.ReadLine();
                            }
                            if (dir_choice == "1")
                            {
                                cd.Create_DirectoryC();
                            }
                            else if (dir_choice == "2")
                            {
                                cd.Create_DirectoryD();
                            }
                            else if (dir_choice == "3")
                            {
                                cd.Create_OtherDirectory();
                            }
                        }
                        else if (user_choice == "2")
                        {
                            Console.WriteLine("What drive do you want to delete a directory off of ?\n" +
                                "1. C Drive\n" +
                                "2. D Drive\n" +
                                "3. Other");
                            Console.Write("Input ");
                            string drive = Console.ReadLine();
                            // null check 
                            while (string.IsNullOrEmpty(drive))
                            {
                                Console.WriteLine("Your answer can't be blank");
                                drive = Console.ReadLine();
                            }
                            DeleteDirectory dd = new DeleteDirectory();
                            if (drive == "1")
                            {
                                dd.Delete_DirectoryC();
                            }
                            else if (drive == "2")
                            {
                                dd.Delete_DirectoryD();
                            }
                            else if (drive == "3")
                            {
                                dd.Delete_Directory_Other();
                            }
                        }
                        // Scan Directory
                        else if (user_choice == "3")
                        {
                            ScanFiles sf = new ScanFiles();
                            Console.WriteLine("Choose which directory to scan from the following options (more options in future updates)\n" +
                                "1. Documents\n" +
                                "2. Desktop\n" +
                                "3. Downloads");
                            Console.Write("Input:");
                            string choice = Console.ReadLine();
                            //if Null 
                            while (string.IsNullOrEmpty(choice))
                            {
                                Console.WriteLine("Your answer can not be blank");
                                choice = Console.ReadLine();
                            }
                            if (choice == "1")
                            {
                                sf.Scan_Documents();
                            }
                            else if (choice == "2")
                            {
                                sf.Scan_Desktop();
                            }
                            else if (choice == "3")
                            {
                                sf.Scan_Downloads();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input select from the followinb options");
                        }
                            break;
                    case "2":
                        Console.WriteLine("1. Create file\n" +
                            "2. Delete file\n" +
                            "3. Scan file for keywords \n" +
                            "4. Sort Files (in development)");
                        string user_choice_2 = Console.ReadLine();

                        // Null check
                        while (string.IsNullOrEmpty(user_choice_2))
                        {
                            Console.WriteLine("Your answer can not be empty");
                            user_choice_2 = Console.ReadLine();
                        }
                        // Create a file
                        if (user_choice_2 == "1")
                        {
                            CreateFile createFile = new CreateFile();
                            Console.WriteLine("In beta version will only create a text file on the desktop for now until I have time to develope the program further");
                            createFile.Desktop_file();
                        }
                        else if (user_choice_2 == "2")
                        {
                            DeleteFile deleteFile = new DeleteFile();
                            Console.WriteLine("In beta version will only delete a text file on the desktop for now until I have time to develope the program further");
                            deleteFile.Delete_Desktop_File();
                        }
                        else if (user_choice_2 == "3")
                        {
                            Keyword_Search keyword = new Keyword_Search();
                            keyword.Desktop_Search();
                        }
                        else if (user_choice_2 == "4")
                        {
                            Console.WriteLine("This section is currently in development, check back in a bit");
                        }
                            break;
                }
            }
        }
    }
}
