using System;
using System.Linq;
using System.Collections.Generic;


namespace AtCoderPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NK  = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int N = NK[0];
            int K = NK[1];
            int[] d = new int[K];
            List<int[]> A = new List<int[]>();

            for(var i =0; i< K; i++)
            {
                d[i] = int.Parse(Console.ReadLine());
                int[] tmp = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                A.Add(tmp);
            }

            List<int> nonDis = new List<int>();
           
            for (var i =0; i<K; i++)
            {
                for(var j =0;j<d[i]; j++)
                {
                    nonDis.Add(A[i][j]);
                }
            }
            IEnumerable<int> Dis = nonDis.Distinct();
            Console.WriteLine(N - Dis.Count()) ;
            
        }
    }
}
