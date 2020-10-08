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
            string S = Console.ReadLine().Replace(" ","");
            int pcnt = 0;
            int wcnt = 0;
            int gcnt = 0;
            int ycnt = 0;

            //PWGY

            for(var i = 0; i< S.Length; i++)
            {
                if (S[i] == 'P') pcnt++;
                if (S[i] == 'W') wcnt++;
                if (S[i] == 'G') gcnt++;
                if (S[i] == 'Y') ycnt++;
            }

            if (pcnt * wcnt * gcnt * ycnt == 0)
            {
                Console.WriteLine("Three");
            }
            else
            {
                Console.WriteLine("Four");
            }
        }
    }
}
