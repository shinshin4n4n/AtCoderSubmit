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
            long[] abc = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long a = abc[0];
            long b = abc[1];
            long c = abc[2];

            //a+b + 2√ab < c
            //4ab < (c- (a+b))2

            long left = 4 * a * b;
            long right = (c - a - b) * (c - a - b);

            if(left < right && c > a + b )
            {
                Console.WriteLine("Yes");
            }else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
