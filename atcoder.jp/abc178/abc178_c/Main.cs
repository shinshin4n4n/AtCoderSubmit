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
            long N = long.Parse(Console.ReadLine());
            //long[] N = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray() ;
            long all = 1;
            long tasu = 1;
            long hiku = 1;
            long hiku2 = 1;
            long ans = 0;
            long mod = 1000000000 + 7;

            for (var i = 0; i < N; i++)
            {


                all = all * 10 % mod;
                hiku = hiku * 9% mod;
                hiku2 = hiku2 * 9 % mod ;
                tasu =  tasu *8 % mod;

            }
            ans = (all + tasu - hiku - hiku2) % mod;
            if(ans < 0)
            {
                ans += mod;
            }
            Console.WriteLine(ans);

        }
    }
}
