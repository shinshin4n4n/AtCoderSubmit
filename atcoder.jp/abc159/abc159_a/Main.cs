using System;
using System.Linq;
using System.Collections.Generic;


namespace AtCoderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] NM = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long N = NM[0];
            long M = NM[1];

            long ans = 0;

            ans = N * (N - 1) /2+ M * (M - 1)/2;


            Console.WriteLine(ans);

        }
    }
}
