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
            long  K = NR[1];
            long ans=0;

            while (N /K >=1)
            {
                ans++;
                N /= K;
            }

            Console.WriteLine(ans+1);
        }
    }
}
