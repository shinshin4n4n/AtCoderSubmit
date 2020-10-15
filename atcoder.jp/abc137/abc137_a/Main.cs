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
            //long N = long.Parse(Console.ReadLine());
            long[] AB= Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long A = AB[0];
            long B = AB[1];

            Console.WriteLine(Math.Max(A + B, Math.Max(A - B, A * B)));

        }        
    }
}
