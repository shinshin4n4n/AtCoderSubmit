using System;
using System.Linq;

namespace AtCoderPractice0704
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long N = int.Parse(Console.ReadLine());
            long[] X = Console.ReadLine().Split(' ').Select(a => long.Parse(a)).ToArray();

            long Xmin = X.ToList().Min();
            long Xmax = X.ToList().Max();


            long minsouwa = 0;
            //体力の総和を出す
            for (var p = Xmin; p <= Xmax; p++)
            {
                long souwa = 0;
                for (var i = 0; i < N; i++)
                {
                    souwa += (X[i] - p) * (X[i] - p);
                }
                if (p == Xmin)
                {
                    minsouwa = souwa;
                    continue;
                }
                if (minsouwa >= souwa)
                {
                    minsouwa = souwa;
                }
            }
            Console.WriteLine(minsouwa);
        }
    }
}