using System;

class Skiprow
{
    static void Main()
    {
        Console.Write("Enter n:");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Enter y:");
        int y = int.Parse(Console.ReadLine());
        
        for (int row = 1; row <= n; row++)
        {
            if (row != y)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
