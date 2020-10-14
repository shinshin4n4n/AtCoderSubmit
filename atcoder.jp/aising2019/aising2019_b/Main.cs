using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] AB = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int A = AB[0];
            int B = AB[1];

            int[] P = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int acnt = 0;
            int abcnt = 0;
            int bcnt = 0;
            
            for(var i =0; i< N; i++)
            {
                if (P[i] <= A) acnt++;
                if (P[i] > A && P[i]<=B) abcnt++;
                if (P[i] > B) bcnt++;
            }


            Console.WriteLine(Math.Min(acnt, Math.Min(abcnt, bcnt)));

        }
    }
}
