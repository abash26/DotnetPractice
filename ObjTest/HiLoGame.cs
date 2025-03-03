﻿namespace ObjTest;
static class HiLoGame
{
    public const int MAXIMUM = 10;
    static Random random = new Random();
    static int currentNumber = random.Next(1, MAXIMUM + 1);
    static int pot = 10;

    public static int GetPot() { return pot; }

    public static void Guess(bool higher)
    {
        int nextNumber = random.Next(1, MAXIMUM + 1);
        if ((higher && nextNumber >= currentNumber) || !higher && nextNumber <= currentNumber)
        {
            pot++;
            Console.WriteLine("You guessed right!");
        }
        else
        {
            pot--;
            Console.WriteLine("Bad luck, you guessed wrong");
        }
        currentNumber = nextNumber;
        Console.WriteLine($"The current number is {currentNumber}");
    }

    public static void Hint()
    {
        int half = MAXIMUM / 2;
        if (currentNumber >= half)
            Console.WriteLine($"The number is at least {half}");
        else Console.WriteLine($"The number is at most {half}");
        pot--;
    }
}
