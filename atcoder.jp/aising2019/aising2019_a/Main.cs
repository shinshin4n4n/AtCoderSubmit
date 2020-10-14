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
            int H = int.Parse(Console.ReadLine());
            int W = int.Parse(Console.ReadLine());

            Console.WriteLine((N - H+1) * (N - W+1));

        }
    }
}
