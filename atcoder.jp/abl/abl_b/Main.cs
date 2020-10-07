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
            long[] ABCD = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long A = ABCD[0];
            long B = ABCD[1];
            long C = ABCD[2];
            long D = ABCD[3];

            if(D<A || B<C){
                Console.WriteLine("No");
            }else
            Console.WriteLine("Yes");

        }
    }
}
