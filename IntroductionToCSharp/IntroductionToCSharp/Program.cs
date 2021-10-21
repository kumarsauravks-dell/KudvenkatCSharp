using System;
class Customer
{
    protected int Id;
}
class CorporateCustomer:Customer
{
    public void Print()
    {
        Id = 101;
        Console.WriteLine("Id is {0}.", Id);
    }
}
class Program
{
    public static void Main()
    {
        CorporateCustomer CC = new CorporateCustomer();
        CC.Print();
        Console.ReadKey();
    }
}