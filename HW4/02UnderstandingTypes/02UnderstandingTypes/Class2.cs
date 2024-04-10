

using System;



public class Class2
{
    public void programming1()
    {
        for (int i = 1; i <= 100; i++)
        {

            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }

    }

    public void programming2()
    {
        Console.WriteLine("Input the number");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < n - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write("*");
            }
            Console.Write("\n");

        }
    }

    public void programming3()
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


    public void programming4()
    {
        // Define a variable representing a birth date
        DateTime birthDate = new DateTime(2000, 1, 1); 
        DateTime currentDate = DateTime.Today;

        // Calculate how many days old the person is
        TimeSpan age = currentDate - birthDate;
        int daysOld = age.Days;
        Console.WriteLine($"You are {daysOld} days old.");

        // Calculate the date of the next 10,000 day anniversary
        int daysToNextAnniversary = 10000 - (daysOld % 10000);
        DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);
        Console.WriteLine($"Your next 10,000 day anniversary will be on {nextAnniversary.ToShortDateString()}.");

    }

    public void programming5()
    {
        DateTime currentTime = DateTime.Now;
        int hour = currentTime.Hour;
        if (hour >= 0) if (hour < 6) Console.WriteLine("Good Night");
        if (hour >= 6) if (hour < 12) Console.WriteLine("Good Morning");
        if (hour >= 12) if (hour < 18) Console.WriteLine("Good Afternoon");
        if (hour >= 18) if (hour < 24) Console.WriteLine("Good Evening");
    }

    public void programming6()
    {
        for(int i = 1; i <= 4;i++)
        {
            for(int j = 0; j <=24; j+= i)
            {
                Console.Write(j != 24 ? $"{j}," : $"{j}");
            }

            Console.WriteLine();
        }
    }
}
