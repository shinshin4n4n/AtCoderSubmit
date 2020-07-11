using System;
using System.Linq;

namespace AtCoder0711
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int ans = 0;

            for(var i = 0; i < N; i++)
            {
                if((i+1) %2 == 1 && a[i]%2==1) { ans++; }
            }

            Console.WriteLine(ans);
        }
    }
}
