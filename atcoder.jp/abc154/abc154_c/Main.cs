using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        long N = long.Parse(Console.ReadLine());
        List<long> A = Console.ReadLine().Split(' ').Select(x => long.Parse(x)).ToList();

        long Acnt = A.Count();
        long Dcnt = A.Distinct().Count();

        if(Acnt == Dcnt)
        {
            Console.WriteLine("YES");
        }else
        {
            Console.WriteLine("NO");
        }
        //Console.ReadKey(true);

    }
}
