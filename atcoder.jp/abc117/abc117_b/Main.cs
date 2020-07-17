using System;
using System.Linq;

namespace AtCoderPractic0717
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] L = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var LS = L.ToList();

            LS.Sort();

           int[] LI =  LS.ToArray();

            int sum = 0;

            for (var i = 0; i < L.Length - 1; i++)
            {
                sum += LI[i];
            }

            if (sum > LI[N-1])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
