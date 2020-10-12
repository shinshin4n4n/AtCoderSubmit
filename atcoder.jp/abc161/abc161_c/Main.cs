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
            long[] NK = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToArray();
            long N = NK[0];
            long K = NK[1];

            //Kで割った余り　と、　（余りーK）のAbsの大小のうち、小さい方
            long mod = N % K;
            long modmns = Math.Abs(mod - K);
            
            if(mod >= modmns)
            {
                Console.WriteLine(modmns);
            }
            else
            {
                Console.WriteLine(mod);
            }
        }
    }
}
