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
            List<int> alist = new List<int>();
            List<int> inputlist = new List<int>();
            int amax = 0;
            int asecond = 0;

            for (var i = 0; i< N; i++)
            {
                int a = int.Parse(Console.ReadLine());
                alist.Add(a);
                inputlist.Add(a);
            }

            amax = alist.Max();
            alist.Sort();
            asecond = alist[N-2];

            alist = inputlist;


            for(var i =0; i< N; i++)
            {
                if (alist[i] != amax)
                {
                    Console.WriteLine(amax);
                }
                else
                {
                    Console.WriteLine(asecond);
                }
            }
        }
    }
}
