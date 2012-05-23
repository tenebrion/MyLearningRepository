using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReturnDistinctValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] userNumbers = { 1, 3, 5, 3, 7, 3, 1, 1, 5 };

            HashSet<int> values = new HashSet<int>(userNumbers);

            foreach (int i in values)
            {
                Console.WriteLine("{0}", i);
            }

            Console.ReadLine();
        }
    }
}
