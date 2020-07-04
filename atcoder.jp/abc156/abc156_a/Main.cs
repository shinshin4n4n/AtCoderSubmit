using System;
using System.Linq;

namespace AtCoderPractice0704
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long[] NR = Console.ReadLine().Split(' ').Select(a => long.Parse(a)).ToArray();

            long  N = NR[0];
            long  R = NR[1];
            long ans;

            if (N >= 10)
            {
                ans = R;
            }
            else
            {
                ans = R + 100 * (10 - N);
            }

            Console.WriteLine(ans);
        }
    }
}
