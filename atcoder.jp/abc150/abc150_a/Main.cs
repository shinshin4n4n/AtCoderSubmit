using System;
using System.Linq;

namespace AtCoder_practice0801
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] KX = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int K = KX[0];
            int X = KX[1];

            if (500 * K >= X)
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
