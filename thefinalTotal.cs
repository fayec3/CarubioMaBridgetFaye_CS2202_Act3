using System;

int total = 10;
int num;

Console.Write("Enter an integer: ");
num = Convert.ToInt32(Console.ReadLine());

while (num != 0)
{
    if (num < 0)
    {
        Console.Write("Enter an integer: ");
        num = Convert.ToInt32(Console.ReadLine()); 
        continue; 
    }

    if (num % 2 == 0)
    {
        int square = num * num;
        total += square;
        Console.WriteLine($"The number is even.\n{square}");
    }
    else
    {
        int cube = num * num * num;
        total += cube;
        Console.WriteLine($"The number is odd.\n{cube}");
    }

    Console.Write("Enter an integer: ");
    num = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Nothing happened.");
