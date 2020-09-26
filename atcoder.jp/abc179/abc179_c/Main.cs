using System;
using System.Linq;
using System.Collections.Generic;


namespace AtCoderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            long cnt = 0;

            for (var A = 1; A < N; A++)
            {
                cnt += (N - 1)/A;
            }

            Console.WriteLine(cnt);

        }
    }
}
