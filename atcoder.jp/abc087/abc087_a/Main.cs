using System;
using System.Linq;
using System.Collections.Generic;


namespace AtCoderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            long X = long.Parse(Console.ReadLine());
            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());

            //所持金K
            long K = X - A;

            while (K > 0)
            {
                K -= B;
                if (K < B) break;
            }
            Console.WriteLine(K);

        }
    }
}
