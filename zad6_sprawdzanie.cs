using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Podaj liczbe: ");
        int x = int.Parse(Console.ReadLine());
        
        int n = 1;
        int liczba = 1;

        while (liczba < x)
        {
            n++;
            liczba *= n;
        }

        if (liczba == x)
        {
            Console.WriteLine("Liczba jest silnią liczby " + n);
        }
        else
        {
            Console.WriteLine("Liczba nie jest silnia zadnej liczby");
        }
    }
}
