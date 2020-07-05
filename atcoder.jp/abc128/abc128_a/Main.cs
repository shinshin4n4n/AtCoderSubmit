using System;
using System.Linq;

namespace AtCoderPractice0705
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] AP = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int A = AP[0];
            int P = AP[1];
            int ans = (A * 3 + P) / 2;
            Console.WriteLine(ans);
        }
    }
}
