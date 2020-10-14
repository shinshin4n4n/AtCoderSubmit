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
            long[] a = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long ans = 0;
            for(var i =0; i< N-1; i++)
            {
                ans = Gcd(a[i], a[i + 1]);
                a[i + 1] = ans;
            }

            if (N == 1) ans = a[0];

            Console.WriteLine(ans);
        }

        public static long Gcd(long a, long b)
        {
            if (a < b)
                // 引数を入替えて自分を呼び出す
                return Gcd(b, a);
            while (b != 0)
            {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}
