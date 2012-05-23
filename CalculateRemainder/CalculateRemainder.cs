// CalculateRemainder.cs
// just practicing skill necessary to learn C#
// also working on commenting at the same time.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateRemainder
{
    class CalculateRemainder
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// The purpose of this is to determine the remainder of a
            /// division problem. I have just enough experience to understand
            /// the purpose of a try/catch statement which I have included
            /// </summary>
            /// The program is going to start with a try block
            try
            {
                // Asking the user to input the numerator
                Console.Write("Please enter a number (the numerator): ");
                // assigning the input values from the user to numerator
                int numerator = Convert.ToInt32(Console.ReadLine());
                // asking the user to input the denominator
                Console.Write("Please enter another number (the denominator): ");
                // assigning the denominator value from the user to denominator
                int denominator = Convert.ToInt32(Console.ReadLine());

                int remainder = numerator % denominator; // sets up the division problem

                Console.Write("The remainder is: {0}", remainder); //  outputs value
            } // end try block
                // the first catch statement for the FormatException
                // this means anything other than a number
            catch (FormatException ex)
            {
                // tells the user they need to input a number and not a letter
                // also included line breaks and added detailed error message.
                // I know this is not recommended in full out programs, but I am
                // in the learning process
                Console.WriteLine("Enter numbers only" + "\r\n\r\n" + ex);
            } // end catch FormatException
                // this attempts to catch any other value not covered under
                // the FormatException catch statement
            catch (Exception ex)
            {
                // this lets the user know why the program crashed so they can provide
                // me with detailed information.
                Console.WriteLine("Stop trying to crash the program" + "\r\n\r\n" + ex);
            } // end catch general exception

            Console.ReadLine(); // this is here so the cmd window will not close on me
        } // end Main
    } // end Class CalculateRemainder
} // end namespace CalculateRemainder
