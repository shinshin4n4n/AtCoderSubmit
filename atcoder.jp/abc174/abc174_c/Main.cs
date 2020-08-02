using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0802
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long K = long.Parse(Console.ReadLine());
            long seven = 7;
            long ans = 1;
            if (K % 2 != 0)
            {
                for (var i = 1; i < 1000000; i++)
                {
                    if (seven % K == 0)
                    {
                        break;
                    }
                    else
                    {
                        seven = seven * 10 + 7;
                        if (seven > K) { seven %= K; }
                        ans++;
                    }
                    //}
                }
            }
            if (ans > K || K %2==0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                var test = seven % K;
                Console.WriteLine(ans);
            }
        }
    }
}
