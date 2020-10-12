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
            int[] NM = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int N = NM[0];
            int M = NM[1];
            int[] A = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int sum = 0;
            int cnt = 0;
            int sho = 0;
            //総投票数　Aの総和
            for(var i =0; i<N; i++)
            {
                sum += A[i];
            }

            if(sum % (4*M) == 0)
            {
                sho = sum / (4 * M);
            }else
            {
                sho = sum / (4 * M) + 1;
            }


            for (var i = 0; i < N; i++)
            {
             if(A[i] >= sho)
                {
                    cnt++;
                }
            }
            if(cnt >= M)
            {
                Console.Write("Yes");
            }else
            {
                Console.Write("No");
            }
        }
    }
}
