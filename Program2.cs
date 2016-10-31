using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("Задан пустой массив");
                Console.ReadKey();
                return;
            }
            int[] A = new int[n];
            Random R = new Random();
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                A[i] = R.Next(-15, 16);
                Console.Write("{0}\t", A[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n - 1; i++)
            {
                for (int k = i + 1; k < n; k++)
                {
                    if (A[i] == A[k])
                    {
                        Console.WriteLine("Есть одинаковые элементы");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            Console.WriteLine("Все элементы уникальны");
            Console.ReadKey();
        }
    }
}
