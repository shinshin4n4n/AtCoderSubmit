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
            int K = int.Parse(Console.ReadLine());

            string ans = "";

            for(var i = 0; i<K; i++)
            {
                ans += "ACL";
            }

            Console.WriteLine(ans);

        }
    }
}
