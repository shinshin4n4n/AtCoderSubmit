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
            int[] ABC = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int A = ABC[0];
            int B = ABC[1];
            int C = ABC[2];

            if(A == B &&
               B == C &&
               C == A )
            {
                Console.WriteLine("Yes");
            }else
            {
                Console.WriteLine("No");
            }
        }
    }
}
