using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Add this namespace for the StreamReader class.
using System.IO;

namespace TextFileReadingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // This object lets you read from a file.
            StreamReader streamReader = null;

            string path = string.Empty;
            string lineData;

            if (args.Length > 0)
            {
                path = args[0];
            }

            if (File.Exists(path))
            {
                // Read entire file line-by-line and display to the screen.
                try
                {
                    // Attempt to open the file.  It will throw
                    // an exception if there is a problem opening it, 
                    // hence the try/catch block.
                    streamReader = new StreamReader(path);

                    // Peek returns the ASCII value of the next character in 
                    // the file *without* advancing the file position.
                    // 
                    // This lets us see whether we've reached the end of the
                    // file yet.

                    //  while (!streamReader.EndOfStream) // alternate approach
                    while (streamReader.Peek() > 0)
                    {
                        // Read a line at a time, printing it to the screen.
                        lineData = streamReader.ReadLine();
                        Console.WriteLine(lineData);
                    }
                }

                // this block will execute if an exception is thrown in the try block
                catch (Exception ex)
                {
                    Console.WriteLine("\n{0}\n", ex.Message);
                }

                // this block always executes - used for resource cleanup.
                finally
                {
                    if (streamReader != null)
                    {
                        streamReader.Close();
                    }
                }
            }
            else
            {
                Console.WriteLine("\nFile not found.\n");
            }
        }
    }
}
