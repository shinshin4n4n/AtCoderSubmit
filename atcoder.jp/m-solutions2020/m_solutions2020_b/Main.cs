using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0725
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] ABC = intArray(Console.ReadLine());
            int A = ABC[0];
            int B = ABC[1];
            int C = ABC[2];
            int K = int.Parse(Console.ReadLine());

            int cnt = K;
            int ans = 0;

            for(var i = 0; i< K; i++)
            {
                if (A < B) { break; }
                B *= 2;
                cnt -= 1;
            }

            int remcnt = cnt;

            if (remcnt > 0)
            {
                for (var i = 0; i <= cnt; i++)
                {
                    if (B < C) {
                        ans++;
                        break;
                    }
                    if(remcnt == 0) { break; }
                    C *= 2;
                    remcnt -= 1;
                    continue;
                }
            }

            if (ans > 0) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }

        public static int[] intArray (string s)
        {
            int[] N = s.Split(' ').Select(x => int.Parse(x)).ToArray();
            return N;
        }
        public static long[] longArray(string s)
        {
            long[] N = s.Split(' ').Select(x => long.Parse(x)).ToArray();
            return N;
        }
    }
}
