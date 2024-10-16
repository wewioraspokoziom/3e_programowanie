using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Zad 1

        for(int i = 0; i <=10; i++)
        {
            Console.WriteLine(i + " ");
        }

        //Zad 2
        for (int b = 100; b >= 50; b--)
        {
            Console.Write(b + " ");
        }
        Console.WriteLine();

        //Zad 3
        int suma = 0;
        int c = 0;
        for (; c <= 100; c++)
        {
            int person = int.Parse(Console.ReadLine());
            if (person == 0)
            {
                break;
            }
            else
            {
                suma += person;
            }
        }
        Console.WriteLine("Suma to: " + suma);
        Console.WriteLine("Ilosc to: " + c);

        //Zad 4
        Console.WriteLine("Podaj poczatek przdzialu: ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj koniec przedzialu: ");
        int stop = int.Parse(Console.ReadLine());
        if(start < stop)
        {
            for(; start <= stop; start++)
            {
                if(start % 3 == 0)
                {
                    Console.Write(start + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Błąd");
        }
        Console.WriteLine() ;
        //Zad 5
        int dec = int.Parse(Console.ReadLine());
        string bin = "";
        for(; dec > 0;)
        {
            if (dec % 2 == 0)
            {
                bin += "0";
                dec = dec / 2;
            }
            else if (dec % 2 == 1)
            {
                bin += "1";
                dec = dec / 2;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Ta liczba to: " + bin);

        //Zad 6
        Console.WriteLine("Podaj wysokosc trojkata: ");
        int wysokosc = int.Parse(Console.ReadLine());
        
        for(int i = wysokosc; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

}
