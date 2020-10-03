using System;
using System.Linq;
using System.Collections.Generic;

namespace AtCoder201003
{
    class Program
    {
        static void Main(string[] args)
        {
            //long N = long.Parse(Console.ReadLine());
            long[] AB = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long A = AB[0];
            long B = AB[1];

            Console.Write((A + B) / 2);
            Console.Write(" ");
            Console.Write((A - B) / 2);
        }
    }
}
