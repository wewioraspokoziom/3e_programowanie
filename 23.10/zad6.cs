using System;

public class zad6
{
    public static void Main(string[] args)
    {
        
        {
            int y = 1;
            Random rnd = new Random();
            int x = (rnd.Next(1, 11));
            while (true)
            {
               
                Console.Write("Odgadnij liczbe z przedzialu 1-10: ");
                int z = Convert.ToInt32(Console.ReadLine());
               
                if (x == z)
                {
                    Console.WriteLine("Odgadles liczbe!");
                    Console.Write("Ilosc prob: " + y);
                    break;
                }
                else
                {
                    Console.WriteLine("Niestety nie odgadnales");
                    y++;
                    continue;
                    
                }
            }
        }
    }
}