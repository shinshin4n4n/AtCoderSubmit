using System;
using System.Linq;
using System.Collections.Generic;

class AtCoder
{
    public static void Main(string[] args)
    {
        int[] NKM = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int N = NKM[0];
        int K = NKM[1];
        int M = NKM[2];

        int[] A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int souwa = 0;
        int ans = 0;

        for(var i = 0; i< N-1; i++)
        {
            souwa += A[i];
        }

        ans = M * N - souwa;


        //平均点　M以上→総得点がM*N以上
        //ans = MN - A1-An-1の点数の総得点

        if(ans <= K && ans >=0)
        {
         Console.WriteLine(ans);
         return;
        }else if(ans <= 0)
        {
            Console.WriteLine(0);
            return;
        }
        Console.WriteLine("-1");
    }
}