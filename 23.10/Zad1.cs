using System;

public class Zad1
{
    public static void Main(string[] args)
    {
        //Zadanie 1
        int i = 1;
        int n = Convert.ToInt32(Console.ReadLine());

        while (i <= n)
        {
            if(i % 2 == 1)
            {
                Console.Write(i + " ");
            }
            i++;
        }
        Console.WriteLine();
        //Zadanie 2
        int z = Convert.ToInt32(Console.ReadLine());
        int s = Convert.ToInt32(Console.ReadLine());

        while (z <= s)
        {
            for (; z <= s; z = z + 33)
            {
                Console.Write(z + " ");
                z++;
            }
            
           
        }
      
            
        

    }
}