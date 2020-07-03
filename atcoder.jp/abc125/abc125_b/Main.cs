using System;
using System.Linq;

namespace AtCoderPractice0704
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] V = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();
            int[] C = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();

            //V[i]-C[i]>0のものを全て選べば良い
            int ans = 0;
            for(var i =0; i<N; i++)
            {
                if (V[i] > C[i])
                {
                    ans += (V[i] - C[i]);
                }
            }
            Console.WriteLine(ans);
        }
    }
}
