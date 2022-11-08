using System;

namespace Iacobi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            decimal[,] a = { { 10, 2, -1 }, { -2, -5, 1 }, { -3, 1, -5 } };
            decimal[] b = {  9, -1 ,-8 };
            decimal eps = (decimal)Math.Pow(10, -1);
            int k = (int)Iacobi(3, eps, a, b)[0];
            decimal[] x = (decimal[]) Iacobi(3, eps, a, b)[1];
            Console.WriteLine(k);
            Console.WriteLine();
            for(int i=0;i<x.Length;i++)
                Console.WriteLine(x[i]);
            Console.ReadKey();
        }
        
        static object[] Iacobi(int n, decimal eps, decimal[,] a, decimal[] b)
        {
            decimal[][] x = new decimal[n][];
            for (int i = 0; i < n; i++)
                x[i] = new decimal[n];

            for (int i = 0; i < n; i++)
                x[0][i] = b[i] / a[i, i];

            bool run = true;
            do
            {
            int k = 1;
                for (int i = 0; i < n; i++)
                {
                    decimal s = 0;
                    for (int j = 0; j < n && j != i; j++)
                        s += a[i, j] * x[k - 1][j];
                    x[k + 1][i] = (b[i] - s) / a[i, i];
                }
                //Console.WriteLine(k);
                if (Max(k, x) < eps)
                    run = false;
            } while (run);

            return new object[2] { x.Length - 1, x[x.Length - 1] };
        }

        private static decimal Max(int k, decimal[][] x)
        {
            decimal max = Math.Abs(x[k][ 0] - x[k - 1][ 0]);
            for (int i = 1; i < x.Length; i++)
            {
                decimal current = Math.Abs(x[k][ i] - x[k - 1][ i]);
                if (current > max)
                    max = current;
            }
            return max;
        }
    }
}
