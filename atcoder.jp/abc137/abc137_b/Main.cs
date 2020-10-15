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
            long[] KX= Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long K = KX[0];
            long X = KX[1];

            long min = X - K + 1;
            long max = X + K - 1;

            for(var i = min; i <= max; i++)
            {
                Console.Write(i);
                Console.Write(" ");
            }

        }        
    }
}
