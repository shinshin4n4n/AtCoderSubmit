using System;
using System.Linq;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int[] NAB = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int N = NAB[0];
            int A = NAB[1];
            int B = NAB[2];

            Console.WriteLine(N-A+B);
        }
    }