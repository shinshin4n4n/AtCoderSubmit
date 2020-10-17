using System;
using System.Linq;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] x = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            List<double> xls = new List<double>();

            double ansm = 0;
            double ansy = 0;
            double ansc = 0;

            for(var i=0; i<N;i++){

                ansm += Math.Abs(x[i]);
                ansy += x[i]*x[i];
                xls.Add(Math.Abs(x[i]));
            }
            ansc = xls.Max();
            ansy = Math.Pow(ansy, 0.5);

            Console.WriteLine(ansm);
            Console.WriteLine(ansy);
            Console.WriteLine(ansc);

        }
    }