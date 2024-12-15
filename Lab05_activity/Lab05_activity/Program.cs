using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Activity 1
            double a = 98, b = 0;
            double result = 0;
            try
            {
                result = SafeDivision(a, b);
                Console.WriteLine($"{a} divided by {b} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Attempted divide by zero.");
            }

            // Activity 2
            TestCatch2();
            Console.ReadLine();
        }

        // Activity 1
        static double SafeDivision(double x, double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }

        // Activity 2
        static void TestCatch2()
        {
            System.IO.StreamWriter sw = null;
            try
            {
                sw = new System.IO.StreamWriter(@"C:\test\test.txt");
                sw.WriteLine("Hello");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (System.IO.IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                // Ensure sw is not null before calling Close
                if (sw != null)
                {
                    sw.Close();
                }
            }
            Console.WriteLine("Done");
        }
    }
}
