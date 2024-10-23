using System;

public class zad4
{
    public static void Main(string[] args)

    {
        int i = Convert.ToInt32(Console.ReadLine());
        int x = 0;
        
        while (i >= 1)
        {
            for(x = 1; x < i; x++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
            i--;
        }
    }
    
}