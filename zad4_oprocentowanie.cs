using System;

class Program
{
    static void Main()
    {
        

        Console.Write("Podaj początkową kwotę: ");
        int Kwota = int.Parse(Console.ReadLine());

        Console.Write("Podaj oprocentowanie w skali roku: ");
        int oprocentowanie = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        oprocentowanie = oprocentowanie /12/ 100;

        int Kwota2 = Kwota;
        
        Liczenie:
        for (int miesiac = 1; miesiac <= liczbaMiesiecy; miesiac++)
        {
            
            Kwota = Kwota * oprocentowanie + Kwota;

            if(miesiac<liczbaMiesiecy)
            {

                goto Liczenie;
            }
        }
        //podatek belki
        Kwota=Kwota-Kwota*0,19;
        Console.WriteLine("kwota oszczednosci: "+Kwota);
    }
}