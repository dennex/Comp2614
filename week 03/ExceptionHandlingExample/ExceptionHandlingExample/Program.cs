using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = Convert.ToInt32("ten"); // throws FormatException
                // string clParam = args[0];         // throws IndexOutOfRangeException
                // throw new NullReferenceException("Something terrible has happened!");
                Console.WriteLine("Next statement in Try Block");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Handling type IndexOutOfRange\n{0}\n", ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Handling type FormatException\n{0}\n", ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Handling type Exception\n{0}\n", ex.Message);
            }

            finally
            {
                Console.WriteLine("Finally Block executed");
            }

            Console.WriteLine("Next statement in program");
        }
    }
}
