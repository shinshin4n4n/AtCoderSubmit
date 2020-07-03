using System;
using System.Linq;

namespace AtCoderPractice0704
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(a => int.Parse(a)).ToArray();

            int A = input[0];
            int B = input[1];
            int T = input[2];
            int ans = 0;
            for(var t =1; t<= T+0.5; t++)
            {
                if(t%A == 0) { ans += B; }
            }

            Console.WriteLine(ans);
        }
    }
}
