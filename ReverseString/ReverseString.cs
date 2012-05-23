// ReverseString.cs
// trying to reverse any sentence the user inputs.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString
{
    class ReverseString
    {
        /// <summary>
        /// This program will take any string the user enters and
        /// completely reverse the order (like looking at it in
        /// a mirror).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // prompting a user for a sentence
            Console.WriteLine("Please enter a sentence");
            // taking user input and assigning it to userInput
            string userInput = Console.ReadLine();

            /// <summary>
            /// This section is flipping between string and char so
            /// the program will reverse the order of the string a
            /// user enters
            /// </summary>
            
            // This section is commented out because it was my first
            // attempt to solve the problem. I ended up finding a LINQ
            // query that made things easier to read and type. I am keeping
            // this here for historical value
            //char[] userInputArray = userInput.ToCharArray();
            //Array.Reverse(userInputArray);
            //string output = new string(userInputArray);
            //Console.Write("Here is your line in reverse: {0}", output);

            /// <summary>
            /// This section with utilize LINQ to reverse a user string
            /// </summary>
            // the initial information is getting pulled from the userInput string
            string output = new string(userInput.ToCharArray().Reverse().ToArray());
            // should output the sentence backwards. For example, if a user enters the
            // string, "I like bacon", the program will output this "nocab ekil I"
            Console.WriteLine("Here is your line in reverse: {0}", output);

            // this is present so I can ensure the cmd window stays open
            Console.ReadLine();
        } // end Main method
    } // end class ReverseString
} // end namespace
