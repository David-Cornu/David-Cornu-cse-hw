using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;

        Console.WriteLine("What is your grade percent?:");
        grade = Convert.ToInt32(Console.ReadLine());

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is an A.");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is an B.");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is an C.");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is an D.");
        }
        else
        {
            Console.WriteLine("Your grade is an F");
        }
    }
}