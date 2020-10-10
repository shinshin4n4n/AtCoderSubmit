using System;
using System.Linq;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace kyodai
{
    class kyodai
    {
        static void Main(string[] args)
        {
            int[] HW = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int H = HW[0];
            int W = HW[1];
            List<string> S = new List<string>();

            for (var i = 0; i < H; i++)
            {
                S.Add(Console.ReadLine());
            }

            int ans = 0;

            //横向きの布団の敷き方を数える
            for (var h = 0; h < H; h++)
            {
                for (int w = 0; w < W - 1; w++)
                {
                    if (S[h][w] == S[h][w + 1] && S[h][w] == '.')
                    {
                        ans++;
                    }
                }
            }

            //縦向きの布団の敷き方を数える
            for (var w = 0; w < W; w++)
            {
                for (var h = 0; h < H-1; h++)
                {
                    if (S[h][w] == S[h+1][w]  && S[h][w] == '.')
                    {
                        ans++;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
