using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string S = Console.ReadLine();
        int ans = 0;

        for(var i =0; i< S.Length/2; i++)
        {
            if (S[i] == S[S.Length - 1 - i]) continue;
            ans++;
        }
        Console.WriteLine(ans);
    }
}
