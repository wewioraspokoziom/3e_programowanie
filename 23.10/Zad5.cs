using System;

public class Zad5
{
    public static void Main(string[] args)
    {
        double y = 0;
        while (true)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            if (x == 0)
            {
                break;
            }
            else
            {
               y+=x;
            }

        }
        Console.WriteLine("Ilosc liczb: " + (y);
    }
}