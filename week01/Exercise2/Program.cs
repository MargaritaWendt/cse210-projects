using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string scoreInput = Console.ReadLine();
        int score = int.Parse(scoreInput);


        if (score >= 90)
        {
            Console.WriteLine("Your score is A.");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Your score is B.");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Your score is C.");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Your score is D.");
        }
        else
        {
            Console.WriteLine("Your score is F.");
        }

        if (score >= 70)
        {
            Console.WriteLine("Congratution! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you missed the course.");
        }
    }
}