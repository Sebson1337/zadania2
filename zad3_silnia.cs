using System;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main(string[] args)
    {
        double n, k,m;
        
        Liczba:
        {
            Console.Write("Podaj liczbę n wieksza od 5: ");
            n = Convert.ToInt32(Console.ReadLine());
        } 
        if(n>5)
        {
           Console.Write("Podaj liczbę k wieksza od 5: ");
           k = Convert.ToInt32(Console.ReadLine());

            if(k>5)
            {
                n = (n - 1) / n;
                k = (k - 1) / k;
                m = (n - k) / k;
                Console.Write(m);
            }
            else
            {
                Console.WriteLine("podana liczba nie jest wieksza od 5!   ");
                goto Liczba;
            }
        }
        else
        {
            Console.WriteLine("podana liczba nie jest wieksza od 5!   ");
            goto Liczba;
        }
    }
    }


