using System;
class Program
{
    public static void Main()
    {
        int TotalCoffeeCost = 0;
        Console.WriteLine("Which type of coffee do you want?");
        Console.WriteLine("1-Small , 2-Medium , 3-Large");
        int UserChoice=int.Parse(Console.ReadLine());
        switch (UserChoice)
        {
            case 1:
                TotalCoffeeCost += 1;
                break;
            case 2:
                TotalCoffeeCost += 2;
                break;
            case 3:
                TotalCoffeeCost += 3;
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid.",UserChoice);
                break;                
        }
        Console.WriteLine("Thank you for shopping with us.");
        Console.WriteLine("Your bill amount is : {0}", TotalCoffeeCost);
        Console.ReadKey();
    }
}