using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0802
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            //int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            if (X >= 30)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
