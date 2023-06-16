using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Podaj ilosc cyfr: ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < a; i++)
        {
            int fibonaczi = Fibo(i);
            Console.Write(fibonaczi + " ");
        }
    }
    public static int Fibo(int a)
    {
        if ( a<= 1)
            return a;

        int b = 0;
        int c = 1;

        for (int i = 2; i <= a; i++)
        {
            int d = c;
            c = b + c;
            b = d;
        }

        return c;
    }
}