using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] NM= Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long N = NM[0];
            long M = NM[1];

            long ans = 0;
            if (N == 1 && M == 1) { ans = 1; }
            if (N == 1 && M != 1) { ans = M-2; }
            if (N != 1 && M == 1) { ans = N - 2; }
            if (N != 1 && M != 1) { ans = (N - 2) * (M - 2);  }
            Console.WriteLine(ans);
        }        
    }
}
