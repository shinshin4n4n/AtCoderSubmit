using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0822
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            long[] NXT = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long N = NXT[0];
            long X = NXT[1];
            long T = NXT[2];
            if (N % X == 0)
            {
                Console.WriteLine((N / X ) * T);
            }
            else
            {
                Console.WriteLine((N / X + 1) * T);
            }
        }
    }
}
