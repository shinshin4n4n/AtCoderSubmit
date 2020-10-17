using System;
using System.Linq;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            List<long> ansls = new List<long>();

            for(long i =1; i*i<=N; ++i ){
                if(N%i ==0){
                    ansls.Add(i);
                    if(i*i != N)ansls.Add(N/i);
                }
            } 

            var list = ansls.OrderBy(x => x).ToArray();

            for(var i =0; i<list.Length; i++){
                Console.WriteLine(list[i]);
            }


        }
    }