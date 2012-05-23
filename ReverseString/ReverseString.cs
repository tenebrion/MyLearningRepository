using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence");
            // taking user input and assigning it to userInput
            string userInput = Console.ReadLine();

            /// <summary>
            /// This section is flipping between string and char so
            /// the program will reverse the order of the string a
            /// user enters
            /// </summary>
            //char[] userInputArray = userInput.ToCharArray();
            //Array.Reverse(userInputArray);
            //string output = new string(userInputArray);
            //Console.Write("Here is your line in reverse: {0}", output);

            /// <summary>
            /// This section with utilize LINQ to reverse a user string
            /// </summary>
            // the initial information is getting pulled from the
            string output = new string(userInput.ToCharArray().Reverse().ToArray());
            Console.WriteLine("Here is your line in reverse: {0}", output);

            Console.ReadLine();
        }
    }
}
