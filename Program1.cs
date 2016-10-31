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
            Console.Write("Количество строк и столбцов n: ");
            int n = int.Parse(Console.ReadLine());
            if ((n == 0) || (n == 1))
            {
                Console.WriteLine("У матрицы нет главной диагонали");
                Console.ReadKey();
                return;
            }
            int[,] A = new int[n, n];
            Random R = new Random();
            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = R.Next(-15, 16);
                    Console.Write("{0}\t", A[i, j]);
                }
                Console.WriteLine();
            }
            int sum = 0; //сумма
            int c = 0; //колво пройденных циклов
            for (int i = 1; i < n; i++)
            {
                for (int j = i - 1; j < i; j++)
                {
                    if (((A[i, j] % 2) == 0) && (i > j))
                    {
                        sum += A[i, j];
                        c++;
                    }
                }
            }
            if (c != 0)
            {
                sum = sum / c;
                Console.WriteLine("Среднее арифметическое четных элементов, расположенных ниже главной диагонали: {0}", sum);
            }
            else
            {
                Console.WriteLine("Невозможно подсчитать");
            }
            Console.ReadKey();
        }
    }
}
