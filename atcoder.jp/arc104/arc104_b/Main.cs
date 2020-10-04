using System;
using System.Linq;
using System.Collections.Generic;
using System.IO.Pipes;

namespace AtCoder201003
{
    class Program
    {
        static void Main(string[] args)
        {
            //long N = long.Parse(Console.ReadLine());
            string[] NS = Console.ReadLine().Split(' ').ToArray();
            int N = int.Parse(NS[0]);
            string S = NS[1];
            int ans = 0;

            for (var j = 0; j < N; j++)
            {
                int c1 = 0;
                int c2 = 0;
                for (var i = j; i < N; i++)
                {
                    if(S[i] == 'G') { c1++; }
                    if (S[i] == 'C') { c1--; }
                    if (S[i] == 'A') { c2++; }
                    if (S[i] == 'T') { c2--; }

                    if (c1==0 && c2==0)
                    {
                        ans++;
                    }
                }
            }
            Console.WriteLine(ans);
        }

        public static int CountChar(string s, char c)
        {
            return s.Length - s.Replace(c.ToString(), "").Length;
        }
    }
}
