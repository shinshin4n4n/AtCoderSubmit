using System;
using System.Linq;

namespace AtCoderPractic0718
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nk = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int N = nk[0];
            int K = nk[1];
            string S = Console.ReadLine();
            char[] cs = S.ToCharArray();

            if(cs[K-1] == 'A')
            {
                cs[K - 1] = 'a';
            }
            if (cs[K - 1] == 'B')
            {
                cs[K - 1] = 'b';
            }
            if (cs[K - 1] == 'C')
            {
                cs[K - 1] = 'c';
            }

            string ans = new string(cs);

            Console.WriteLine(ans);
            //k=1 hk=5 　k=2 h2=10 
        }
    }
}
