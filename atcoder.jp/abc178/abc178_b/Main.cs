using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace AtCoder0913
{
    class Program
    {
        static void Main(string[] args)
        {
      //      int Na = int.Parse(Console.ReadLine());
            long[] N = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray() ;

            long a = N[0];
            long b = N[1];
            long c = N[2];
            long d = N[3];

            List<long> list = new List<long>{ a * c, a*d, b*c, b*d};

            long max = list.Max();

            Console.WriteLine(max);

        }
    }
}
