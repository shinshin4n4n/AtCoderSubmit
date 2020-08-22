using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder0822
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string N = Console.ReadLine();
            //long[] NXT = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            int[] nc = new int[N.Length];
            int ans = 0;

            for (var i=0; i<N.Length; i++)
            {
                string s = N[i].ToString();
                nc[i] = int.Parse(s);

                ans += nc[i];
            }

         if(ans % 9 == 0) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }
    }
}
