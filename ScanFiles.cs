using System.IO;

namespace Null_Ops
{
    public class ScanFiles
    {
        public void Scan_Documents()
        {
            string documents_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string[] all_files = Directory.GetFiles(documents_path);
            foreach (string file in all_files)
            {
                Console.WriteLine(file);
            }
        }

        public void Scan_Desktop()
        {
            string desktop_path = Environment.GetFolderPath (Environment.SpecialFolder.DesktopDirectory);
            string[] all_files = Directory.GetFiles(desktop_path);
            foreach (string file in all_files)
            {
                Console.WriteLine(file);
            }
        }

        public void Scan_Downloads()
        {
            string download_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string[] all_files = Directory.GetFiles(download_path);
            foreach (string file in all_files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
