using System;

namespace Gauss
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] b = { -2, 9, 13 };
            //double[,] A = { { 1,2,-4 } , {2,-1,3 },{-3,4,1 } };
            double[] b = { 9, -1, -8 };
            double[,] A = { { 10,2,-1 } , {-2,-5,1 },{-3,1,-5 } };
            double[] rezultat = Gauss(3, A,b);
            foreach (double item in rezultat)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        static double[] Gauss(long n, double[,] A, double[] b)
        {
            double[] x = new double[n];
            for(long k = 0; k < n - 1; k++)
            {
                double p;
                if (A[k, k] != 0)
                    p = A[k, k];
                else
                    return null;
                for(long j = k; j < n; j++)
                    A[k, j] /= p;

                b[k] /= p;
                for (long i = k + 1; i < n; i++) {
                    for (long l = k+1; l < n; l++)
                        A[i, l] -= A[k, l] * A[i, k];
                    b[i] -= b[k] * A[i, k];
                }

                Console.WriteLine();
                for (long q1 = 0; q1 < n; q1++)
                {
                    for (long q2 = 0; q2 < n; q2++)
                        Console.Write("   " + A[q1, q2]);
                    Console.WriteLine();
                }

            }
            Console.WriteLine();
            for (long q1 = 0; q1 < n; q1++)
            {
                for (long q2 = 0; q2 < n; q2++)
                    Console.Write("   " + A[q1, q2]);
                Console.WriteLine();
            }
            x[n-1] = b[n-1] / A[n-1, n-1];
            for(long k = n - 1; k >= 0; k--)
            {
                double s = 0;
                for(long i = k + 1; i < n; i++)
                    s += A[k, i] * x[i];
                x[k] = (b[k] - s) / A[k, k];
            }
            return x;
        }
    }
}
