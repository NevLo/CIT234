using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.Write("Input numerator: \n>>>");
                int.TryParse(Console.ReadLine(), out int testing);
                Console.Write("Input denominator: \n>>>");
                int.TryParse(Console.ReadLine(), out int denominator);
                Console.WriteLine(testing + "   " + denominator);


                int result = testing / denominator;
                Console.WriteLine($"Result: {result}");

                if(testing < 0 || denominator < 0)
                {
                    throw new TianException();
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("MESSAGE!");
                Console.WriteLine(ex.Message);
                Console.WriteLine();

                Console.WriteLine("TOSTRING!");
                Console.WriteLine(ex.ToString());
                Console.WriteLine();

                Console.WriteLine("STACKTRACE!");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();


            }
            finally
            {
                Console.WriteLine("Goodbye!!");
            }
        }
    }
}
