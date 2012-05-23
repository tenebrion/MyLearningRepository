// ReturnDistinctValues.cs
// practicing my C# for fun
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReturnDistinctValues
{
    class ReturnDistinctValues
    {
        /// <summary>
        ///  This program is going to take a list of numbers
        ///  and only show the individual numbers and not each
        ///  number in the list
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // defining my list of numbers as an array
            int[] userNumbers = { 1, 3, 5, 3, 7, 3, 1, 1, 5 };

            // setting up the userNumbers in a HashSet
            // I need to learn more about HashSet and how to properly use it
            HashSet<int> values = new HashSet<int>(userNumbers);

            // Foreach loop to grab each integer from my HashSet values
            foreach (int i in values)
            {
                Console.WriteLine("{0}", i); // should see 1, 2, 5, 7
            } // end foreach loop

            Console.ReadLine();
        } // end Main method
    } // end class ReturnDisctinctValues
} // end namespace
