using System;
using System.Linq;

namespace AtCoder0711
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] lrd = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int L = lrd[0];
            int R = lrd[1];
            int d = lrd[2];

            int ans = 0;

            for(var i = L; i <= R; i++)
            {
                if(i %d == 0) { ans++; }
            }

            Console.WriteLine(ans);
        }
    }
}
