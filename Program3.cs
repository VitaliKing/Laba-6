using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int n = int.Parse(Console.ReadLine());
            if ((n == 1) || (n == 0))
            {
                Console.WriteLine("Такой массив не имеет смысла");
                Console.ReadKey();
                return;
            }
            int[] A = new int[n];
            int i = 0;
            Random R = new Random();
            Console.WriteLine("Массив:");
            for (i = 0; i < n; i++)
            {
                A[i] = R.Next(-15, 16);
                Console.Write("{0}\t", A[i]);
            }
            Console.WriteLine();
            int min = -16;
            int ind = 0;
            for (i = 0; i < n; i++)
            {
                if ((A[i] < 0) && (A[i] > min))
                {
                    min = A[i];
                    ind = i;
                }
            }
            if (min != -16)
            {
                int b = A[ind];
                A[ind] = A[n - 1];
                A[n - 1] = b;
                Console.WriteLine("Максимальный из минимальных элементов {0}:", min);
                for (i = 0; i < n; i++)
                {
                    Console.Write("{0}\t", A[i]);
                }
            }
            else
            {
                Console.WriteLine("Отрицательных элементов нет");
            }
            Console.ReadKey();
        }
    }
}
