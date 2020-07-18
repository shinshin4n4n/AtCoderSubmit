using System;
using System.Linq;

namespace AtCoderPractic0718
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] h = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            //h[0] = h1  h[N-1] = hN
            int ans = 0;
            int active = 0;

            for(int i=0; i<N; i++)
            {
                if(active >= h[i])
                {
                    active = h[i];
                }
                else
                {
                    ans += h[i] - active;
                    active = h[i];
                }
            }

            Console.WriteLine(ans);
            //k=1 hk=5 　k=2 h2=10 

        }
    }
}
