using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("wybierz liczbe od 1 do 20");
        Console.WriteLine("Odpowiedz liczbą ujemną, jeśli liczba jest mniejsza.");
        Console.WriteLine("Odpowiedz dodatnią, jeśli liczba jest większa.");
        Console.WriteLine("Odpowiedz zerem, jeśli zgadłem liczbę.");

        int dolna = 1;
        int gorna = 20;

        while (true)
        {
            int propozycja = (dolna + gorna) / 2;
            Console.WriteLine("Czy to jest liczba {0}?", propozycja);
            int odpowiedz = Convert.ToInt32(Console.ReadLine());

            if (odpowiedz < 0)
            {
                gorna = propozycja - 1;
            }
            else if (odpowiedz > 0)
            {
                dolna= propozycja + 1;
            }
            else
            {
                Console.WriteLine("Zgadłem liczbę! Wybrałeś liczbę {0}.", propozycja);
                break;
            }
        }

        Console.ReadLine();
    }
}