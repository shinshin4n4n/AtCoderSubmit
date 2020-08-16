using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0815
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] L = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            long ans = 0;

            for (var i = 1; i <= N; i++)
            {
                for (var j = 1; j <= N; j++)
                {
                    if (i >= j) continue;
                    for (var k = 1; k <= N; k++)
                    {
                        if (j >= k) continue;
                        if (L[k - 1] == L[j - 1]) continue;
                        if (L[i - 1] == L[j - 1]) continue;
                        if (L[i - 1] == L[k - 1]) continue;
                        if (L[k - 1] < L[j - 1] + L[i - 1] && L[j - 1] < L[k - 1] + L[i - 1] && L[i - 1] < L[k - 1] + L[j - 1])
                            ans++;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
