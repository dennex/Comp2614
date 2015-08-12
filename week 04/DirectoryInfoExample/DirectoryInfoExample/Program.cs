using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace DirectoryInfoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string dirName = @"C:\Program Files";

                DirectoryInfo dir = new DirectoryInfo(dirName);

                FileAttributes fa;

                Console.WriteLine("Directory: {0}", dir.FullName);
                Console.WriteLine("Parent   : {0}", dir.Parent.FullName);
                Console.WriteLine("Root     : {0}\n\n", dir.Root.FullName);

                Console.Write("Press enter to see subdirectories in {0}: ", dirName);
                Console.ReadLine();

                Console.WriteLine("Subdirectories in {0}", dirName);
                Console.WriteLine("{0, -40} {1, 10}", "Name", "File Count");
                Console.WriteLine(new string('-', 51));

                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    Console.WriteLine("{0, -40} {1, 10:N0}", subDir.Name, subDir.GetFiles().Count());
                }

                Console.Write("\nPress enter to see files in {0}: ", dirName);
                Console.ReadLine();

                Console.WriteLine("\n\nFiles in {0}", dirName);
                Console.WriteLine("{0, -30} {1}", "Name", "Attributes");
                Console.WriteLine(new string('-', 41));

                foreach (FileInfo file in dir.GetFiles())
                {
                    fa = file.Attributes;
                    Console.WriteLine("{0, -30} {1}", file.Name, fa.ToString());
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}\n", ex.Message);
            }
        }
    }
}
