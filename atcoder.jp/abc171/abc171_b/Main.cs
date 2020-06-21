using System;

namespace AtCoder0621
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string[] ps = Console.ReadLine().Split(' ');

            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int[] p = new int[N];
            for (var i = 0; i < ps.Length; i++) {
                p[i] = int.Parse(ps[i]);
            }

            Array.Sort(p);

            int ans = 0;

            for(var i =0; i<K; i++)
            {
                ans += p[i];
            }

            Console.WriteLine(ans);

        }
    }
}
