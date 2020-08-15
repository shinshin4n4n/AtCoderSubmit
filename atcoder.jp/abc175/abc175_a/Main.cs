using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0815
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int N = int.Parse(Console.ReadLine());
            //int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            string  S = Console.ReadLine();
            int ans = 0;

            if (S.IndexOf("R") != -1) { ans = 1; }
            if (S.IndexOf("RR") != -1) { ans = 2; }
            if (S == "RRR") { ans = 3; }
            Console.WriteLine(ans);
        }
    }
}
