using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 1.5;
        int n = 10;

        double estimatedValue = EstimateExp(x, n);
        Console.WriteLine("wartość funkcji e^x: " + estimatedValue);
    }
    static double EstimateExp(double x, int n)
    {
        double sum = 1.0;
       double term = 1.0;

            for (int i = 1; i < n; i++)
        {
            term *= x / i;
            sum += term;
        }

        return sum;
    }
}