using System;
using System.Linq;
using System.Collections.Generic;

public class colon
{
    public static void Main(string[] args)
    {
        //入力内容　複数
        string[] input = Console.ReadLine().Split(' ');

        //数字
        double A = int.Parse(input[0]);
        double B = int.Parse(input[1]);
        double H = double.Parse(input[2]);
        double M = double.Parse(input[3]);
        double ansans;

        if (H / 12 >= M / 60)
        {
            ansans = (A * A) + (B * B) - 2 * A * B * Math.Cos(2 * Math.PI * ((H+M/60)/12 - M / 60));

            Console.WriteLine(Math.Sqrt(ansans));
        }
        else
        {
            ansans = (A * A) + (B * B) - 2 * A * B * Math.Cos(2 * Math.PI * (M / 60- (H + M / 60) / 12));
            Console.WriteLine(Math.Sqrt(ansans));
        }
    }
}

