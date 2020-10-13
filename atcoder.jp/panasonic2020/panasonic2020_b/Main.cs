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
            long[] HW = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long H = HW[0];
            long W = HW[1];

            if (H == 1 || W == 1)
            {
                Console.WriteLine(1);
            }
            else if (H % 2 == 1 && W % 2 == 1)
            {
                Console.WriteLine(H * W / 2 + 1);
            }
            else
            {
                Console.WriteLine(H * W / 2);
            }
        }
    }
}
