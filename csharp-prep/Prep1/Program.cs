using System;

class Program
{
    static void Main(string[] args)
    {
        string _fName;
        string _lName;
        
        Console.WriteLine("What is your first name?:");
        _fName = Console.ReadLine();
        Console.WriteLine("What is your last name?:");
        _lName = Console.ReadLine();

        Console.WriteLine($"Your name is {_lName}, {_fName} {_lName}");
    }
}