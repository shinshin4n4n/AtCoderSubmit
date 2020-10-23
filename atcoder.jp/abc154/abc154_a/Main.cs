using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] ST = Console.ReadLine().Split(' ');
        int[] AB = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        string U = Console.ReadLine();

        string S = ST[0];
        string T = ST[1];
        int A = AB[0];
        int B = AB[1];

        int ansa = A;
        int ansb = B;

        if (U == S) ansa--;
        if (U == T) ansb--;

        Console.WriteLine(ansa);
        Console.WriteLine("");
        Console.WriteLine(ansb);
    }
}
