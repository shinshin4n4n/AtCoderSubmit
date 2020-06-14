using System;

namespace AtCoder0614
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] x = new int[5];

            for (var i = 0; i < input.Length; i++) {
                x[i] = int.Parse(input[i]);
            }

            for (var i = 0; i < 5; i++) {
                if (x[i] == 0)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
        }
    }
}
