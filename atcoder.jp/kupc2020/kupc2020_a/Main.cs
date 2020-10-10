using System;
using System.Linq;
using System.Collections.Generic;
using System.IO.Pipes;

namespace kyodai
{
    class kyodai
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int[]> xylist = new List<int[]>();
            int ans = 0;


            for(var i = 0; i< N; i++)
            {
                int[] xy = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                xylist.Add(xy);
            }

            for(var i =0; i< N-1; i++)
            {
                int x1 = xylist[i][0];
                int y1 = xylist[i][1];
                int x2 = xylist[i+1][0];
                int y2 = xylist[i+1][1];

                int d = Math.Abs(x2 - x1) + Math.Abs(y2 - y1);

                ans += d;
            }

                Console.WriteLine(ans);
        }
    }
}
