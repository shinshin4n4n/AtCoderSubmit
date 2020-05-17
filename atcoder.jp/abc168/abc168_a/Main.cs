using System;
using System.Linq;
using System.Collections.Generic;

public class Therefore
{
    public static void Main(string[] args)
    {
        //数字入力
        int N = int.Parse(Console.ReadLine());

        if (N % 10 == 3) { Console.WriteLine("bon"); }
        else if (N % 10 == 0 ||
                      N % 10 == 1 ||
                      N % 10 == 6 ||
                      N % 10 == 8) { Console.WriteLine("pon"); }
        else { Console.WriteLine("hon"); }

    }
}