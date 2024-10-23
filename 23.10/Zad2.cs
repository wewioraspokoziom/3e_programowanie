using System;

public class Zad2
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        while (x <= y)
        {
            Console.Write(x + " ");
            x++;
            Console.WriteLine(((x * 9 / 5) + 32) + " ");


        }

    }
}

