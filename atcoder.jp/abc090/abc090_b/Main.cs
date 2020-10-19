using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
        int[] AB = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int A = AB[0];
        int B = AB[1];
        int anscnt = 0;

        string astr = A.ToString();
        string bstr = B.ToString();

        for(var i =A; i<=B; i++)
        {
            if (kaibun(i)) anscnt++;
        }

        Console.WriteLine(anscnt);
        //Console.ReadKey(true);
    }
    
    public static bool kaibun(int num)
    {
        string numstr = num.ToString();
        bool ans  = false;

        for(var i =0; i< numstr.Length/2; i++)
        {
            if (numstr[i] != numstr[numstr.Length - 1 - i]) {
                ans = false;
                break;
            }
            ans = true;
        }
        return ans;
    }
            
  }
