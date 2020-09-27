using System;
using System.Linq;
using System.Collections.Generic;


namespace AtCoderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());
            int[] AB  = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int A = AB[0];
            int B = AB[1];

            bool OKflg = false;

            for(var i = A; i<=B; i++)
            {
                if (i % K == 0) OKflg = true;
            }

            if (OKflg == true)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("NG");
            }
        }
    }
}
