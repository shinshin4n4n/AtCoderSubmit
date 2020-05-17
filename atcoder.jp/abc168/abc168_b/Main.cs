using System;
using System.Linq;
using System.Collections.Generic;

public class TripleDots
{
    public static void Main(string[] args)
    {
        int K = int.Parse(Console.ReadLine());

        string S = Console.ReadLine();

        int len = S.Length;

        if(K >= len){ Console.WriteLine(S);}
        else
        { Console.WriteLine(S.Substring(0, K) + "..."); }
    }
}

