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
            long N = long.Parse(Console.ReadLine());
            long[] p= Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();

            long cnt = 0;

            for(var i =0; i<N; i++)
            {
                if (p[i] == i+1) cnt++;
            }

            if (cnt == N - 2 || cnt == N)
            {
                Console.WriteLine("YES");
            }else
            {
                Console.WriteLine("NO");
            }
        }        
    }
}
