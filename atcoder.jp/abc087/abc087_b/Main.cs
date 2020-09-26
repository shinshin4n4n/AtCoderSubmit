using System;
using System.Linq;
using System.Collections.Generic;


namespace AtCoderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            long A = long.Parse(Console.ReadLine());
            long B = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());
            long X = long.Parse(Console.ReadLine());

            long ans = 0;

            for(var a =0; a<=A; a++)
            {
                for (var b = 0; b <= B; b++) 
                {
                    for (var c = 0; c <= C; c++)
                    {
                        if (500 * a + 100 * b + c * 50 == X) ans++;  
                     }
                }
            }

            Console.WriteLine(ans);

        }
    }
}
