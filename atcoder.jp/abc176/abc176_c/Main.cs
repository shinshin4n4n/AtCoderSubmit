using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0822
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            long ans = 0;

            for (var i=0; i<A.Length-1; i++)
            {
                if(A[i] <= A[i + 1]) { continue; }

                ans += (A[i] - A[i+1]);

                A[i + 1] = A[i]; 
            }

       Console.WriteLine(ans);
        }
        }
    }
