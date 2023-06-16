using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pary liczb " + n);
        szukanie(n);

        Console.ReadLine();
    }

    static void szukanie(int n)
    {
        for (int i = 1; i <= n / 2; i++)
        {
            Console.WriteLine("{0}+{1}", i, n - i);
        }
    }
}