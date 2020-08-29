using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0829
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //long N = long.Parse(Console.ReadLine());
            long[] DTS = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            long D = DTS[0];
            long T = DTS[1];
            long S = DTS[2];

            if(D <= S * T) { Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
        }
    }
}

