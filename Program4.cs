using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            int i = 0;
            Random ran = new Random();
            for (i = 0; i < n; i++)
            {
                A[i] = ran.Next(0, 2);
                Console.Write("{0}\t", A[i]);
            }
            Console.WriteLine();
            int b = 0;
            int maxb = 0;
            int maxc = 0;
            for (i = 0; i < n; i++)
            {
                if (A[i] == 1)
                { b = b + 1; }
                else
                {
                    if (b > maxb)
                    {
                        maxb = b;
                        maxc = i - b;
                    }
                    b = 0;
                }
            }
            Console.WriteLine(maxc + maxb - 1);
            Console.ReadKey();
        }
    }
}
