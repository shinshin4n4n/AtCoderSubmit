using System;
using System.Linq;

namespace AtCoder0711
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            // int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            long[] ans =  new long [N];

                for(var x =1; x< 100; x++)
                {
                    for (var y = 1; y < 100; y++)
                    {
                        for (var z = 1; z < 100; z++) {
                        long n = x * x + y * y + z * z + x * y + y * z + z * x;
                        if(n<=N)
                        ans[n-1] += 1;
                        }
                    }
            }

            for (var i = 0; i < N; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}
