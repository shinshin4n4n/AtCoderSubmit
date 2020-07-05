using System;
using System.Linq;

namespace AtCoder0705
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N % 1000 == 0) { Console.WriteLine(0); }
            else
            {
                Console.WriteLine(1000 - N % 1000);
            }
        }
    }
}
