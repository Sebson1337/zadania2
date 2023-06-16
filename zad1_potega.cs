using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Podaj a(podstawa)");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Podaj b(wykladnik)");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = Potega(a, b);
        Console.WriteLine("Wynik: " + c);
    }
    public static int Potega(int a, int b)
    {
        int c = 1;
        for (int i = 1; i <= b; i++)
        {
            c *= a;
        }
        return c;
    }
}