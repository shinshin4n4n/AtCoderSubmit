using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
        long[] NHW = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
        long N = NHW[0];
        long H = NHW[1];
        long W = NHW[2];

        List<long[]> abls = new List<long[]>();

        long ans = 0;

        for(var i =0; i< N; i++)
        {
            long[] ab = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            abls.Add(ab);
        }

        for(var i =0;i<N; i++)
        {
            if (abls[i][0] >= H && abls[i][1] >= W)
                ans++;
        }

        Console.WriteLine(ans);
        //Console.ReadKey(true);
        }        
    }
