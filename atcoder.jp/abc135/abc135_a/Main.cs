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
            long[] AB= Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long A = AB[0];
            long B = AB[1];
            string ans = "IMPOSSIBLE";
            if ((A + B) % 2 == 0) ans = (Math.Abs(A + B) / 2).ToString();
            Console.WriteLine(ans);
        }        
    }
}
