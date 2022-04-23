using System;

namespace MatrixSpirale
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество строк");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество столбцов");

            int m = int.Parse(Console.ReadLine());
            int[,] mas = new int[m, n];
            int k = 1;
            int t = 0;
            int i, j = 0;
            int n1 = n;
            int m1 = m;

            while (k <= n1 * m1)
            {
                if (k < mas.Length)
                {
                    for (i = t; i < n; i++)
                        mas[j, i] = k++;
                    j = n - 1;
                }
                if (k < mas.Length)
                {
                    for (i = t + 1; i < m; i++)
                        mas[i, j] = k++;
                    j = m - 1;
                }
                if (k < mas.Length)
                {
                    for (i = n - 2; i >= t; i--)
                        mas[j, i] = k++;
                    j = t;
                }
                if (k < mas.Length)
                {
                    for (i = m - 2; i > t; i--)
                        mas[i, j] = k++;
                    n--;
                    m--;
                    t++;
                    j = t;
                }
               
            }

            for (i = 0; i < mas.GetLength(0); i++)
            {
                for (j = 0; j < mas.GetLength(1); j++)
                    Console.Write("{0,2} ", mas[i, j]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
   

