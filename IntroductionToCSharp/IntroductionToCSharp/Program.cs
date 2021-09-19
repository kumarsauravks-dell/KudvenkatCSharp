using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter First Name");
        string firstName=Console.ReadLine();
        Console.WriteLine("Enter Last Name");
        string lastName = Console.ReadLine();
        Console.WriteLine("Welcome " + firstName + " " + lastName);
        Console.WriteLine("Welcome {0} {1}", firstName, lastName);
        Console.ReadKey();
    }
}