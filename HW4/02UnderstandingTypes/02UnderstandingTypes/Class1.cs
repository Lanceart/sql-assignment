

using System;
using System.Numerics;



public class Class1
{
    public void Programming1()
    {
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "Type", "Size", "Minimum Value", "Maximum Value");
        Console.WriteLine(new String('-', 75));

        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "short", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "int", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "long", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "float", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "double", sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0,-8} {1,5} {2,30} {3,30}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

    }

    public void programming2()
    {
        Console.Write("Enter the number of centuries: ");
        int centuries = int.Parse(Console.ReadLine());

        int years = centuries * 100;
        int days = (int)(years * 365.2422); // Average including leap years
        long hours = days * 24L;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 1000;
        BigInteger microseconds = milliseconds * 1000;
        BigInteger nanoseconds = microseconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }

    public void randomGenerator()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 4); // upper bound is exclusive

        while (true)
        {
            Console.WriteLine("Guess the number (between 1 and 3): ");
            // Convert the user's typed answer from string to int
            int guessedNumber = int.Parse(Console.ReadLine());

            // Check if the guess is outside the valid range
            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is outside of the valid range. Please guess a number between 1 and 3.");
            }
            else if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                break; // Exit the loop if the guess is correct
            }
        }
    }
}
