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
            int[] ND = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int N = ND[0];
            int D = ND[1];
            int ans = N / (2 * D + 1) + 1;
            if((N%(2*D +1) == 0))
            {
                ans -= 1;
            }

            //範囲2D +1 を見れる。
            Console.WriteLine(ans);
        }
    }
}
