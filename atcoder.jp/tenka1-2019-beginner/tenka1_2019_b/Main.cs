using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
        int N = int.Parse(Console.ReadLine());
        string S = Console.ReadLine();
        int K = int.Parse(Console.ReadLine());
        char[] ans = new char[S.Length];

        for(var idx =0; idx<N; idx++)
        {
            if(S[idx] == S[K-1])
            {
                ans[idx] = S[K-1];
            }else
            {
                ans[idx] = '*';
            }
            Console.Write(ans[idx]);
        }
        //Console.ReadKey(true);
    }
                
  }
