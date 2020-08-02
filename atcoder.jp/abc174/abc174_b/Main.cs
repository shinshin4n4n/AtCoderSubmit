using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0802
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] ND = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int N = ND[0];
            int D = ND[1];
            int ans = 0;
            int[] XY = new int[2];
            int X;
            int Y;
            var list = new List<int[]>();

            for (var i = 0; i < N; i++)
            {
                XY = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                list.Add(XY);
            }

            for (var i = 0; i < N; i++) {
                int[] array = list[i].ToArray();
                 X = array[0];
                 Y = array[1];
                if(Math.Pow(X,2) + Math.Pow(Y, 2) <= Math.Pow(D, 2))
                {
                    ans++;
                }
            }

            Console.WriteLine(ans);

        }
    }
}
