using System;

int total = 10; // Declare total
int num;

Console.Write("Enter an integer: ");
num = Convert.ToInt32(Console.ReadLine());

// Loop until the user enters 0
while (num != 0)
{
    // Check if the number is negative and prompt again
    if (num < 0)
    {
        Console.Write("Enter an integer: ");
        num = Convert.ToInt32(Console.ReadLine()); // Ask again
        continue; // Skip the rest of the loop and re-check input
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

    // Ask for a new number (to avoid infinite loop)
    Console.Write("Enter an integer: ");
    num = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Nothing happened.");
