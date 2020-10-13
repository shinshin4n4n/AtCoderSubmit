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
            string s = Console.ReadLine();
            int rcnt = 0;
            int bcnt = 0;

            for(var i =0; i< s.Length; i++)
            {
                if (s[i] == 'R') rcnt++;
                if (s[i] == 'B') bcnt++;
            }


            if (rcnt > bcnt)
            {
                Console.WriteLine("Yes");
            }else { 
                Console.WriteLine("No");
            }
        }
    }
}
