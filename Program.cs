using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter a number (the numerator): ");
                int numerator = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter another number (the denominator): ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int remainder = numerator % denominator;

                Console.Write("The remainder is: {0}", remainder);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Enter numbers only" + "\r\n\r\n" + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stop trying to crash the program" + "\r\n\r\n" + ex);
            }

            Console.ReadLine();
        }
    }
}
