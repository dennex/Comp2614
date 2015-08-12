using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// add namespace for StreamReader and File classes
using System.IO;

namespace COMP2614HomeLab03
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("USAGE: comp2614homelab03 datafile.txt");
                Console.ReadLine();
                return;
            }

            StreamReader reader = null;

            string lineFromFile;
            string result;

            double sum = 0.0;
            int intValue;
            char charValue;
            double floatingPointValue;

            string path = args[0];

            if (File.Exists(path))
            {
                Console.WriteLine("\n{0, -9} {1}\n{2}", "Data", "Determined Type", new string('-', 38));

                try
                {
                    reader = new StreamReader(path);

                    while (reader.Peek() > 0)
                    {
                        lineFromFile = reader.ReadLine();

                        // test for int type
                        if (int.TryParse(lineFromFile, out intValue))
                        {
                            result = "Integer";
                            sum += intValue;
                        }

                        // test for char type
                        else if (char.TryParse(lineFromFile, out charValue))
                        {
                            result = string.Format("Character (ASCII value {0})", (int)charValue);
                        }

                        // test for floating point type
                        else if (double.TryParse(lineFromFile, out floatingPointValue))
                        {
                            result = "Floating Point";
                            sum += floatingPointValue;
                        }

                        // not an int, char or floating point - must be a string
                        else
                        {
                            result = "Assumed to be string";
                        }

                        Console.WriteLine("{0, -9} {1}", lineFromFile, result);
                    }

                    Console.WriteLine("\n\nSum of all numeric values is approximately {0:n3}\n", sum);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("\nTrouble opening file: \n{0}\n", ex.Message);
                }

                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }
            else if (path != string.Empty)
            {
                Console.WriteLine("\nFile not found\n");
            }

            Console.ReadLine();
        }
    }
}
